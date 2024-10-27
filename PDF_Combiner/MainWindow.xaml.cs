using Microsoft.VisualBasic;
using Microsoft.Win32;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PDF_Combiner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly string DESKTOPPATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonDirectorie_Click(object sender, RoutedEventArgs e)
        {
            var vfbd = new OpenFileDialog();

            // Establecer el directorio inicial en el escritorio del usuario
            vfbd.InitialDirectory = DESKTOPPATH;
            vfbd.Title = "Select PDF files";
            vfbd.CheckFileExists = true;
            vfbd.CheckPathExists = true;
            vfbd.Multiselect = true; // Permitir la selección de múltiples archivos

            // Filtrar los archivos PDF
            vfbd.Filter = "PDF Files (*.pdf)|*.pdf";

            if (vfbd.ShowDialog() == true)
            {
                // Obtener todos los archivos seleccionados
                var selectedDirectories = vfbd.FileNames; // FileNames devuelve todos los archivos seleccionados

                // Unir los nombres de los archivos en una cadena separada por comas
                TextField.Text = string.Join(", ", selectedDirectories); // Mostrar todos los archivos seleccionados en el TextField
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }

        private void Window_Closed(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnFusion_Click(object sender, RoutedEventArgs e)
        {// Verificar si el TextField está vacío
            if (string.IsNullOrWhiteSpace(TextField.Text))
            {
                MessageBox.Show("Por favor selecciona al menos dos archivos PDF.");
                return;
            }

            // Obtener la lista de archivos PDF desde TextField (separados por comas o puntos y comas)
            var pdfFiles = TextField.Text.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(f => f.Trim())  // Eliminar espacios adicionales
                                         .Where(f => f.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase)) // Filtrar solo PDFs
                                         .ToArray();

            // Verificar que hay al menos dos archivos PDF
            if (pdfFiles.Length < 2)
            {
                MessageBox.Show("Por favor selecciona al menos dos archivos PDF para fusionar.");
                return;
            }

            // Nombre del archivo PDF resultante en el escritorio
            var outputFilePath = System.IO.Path.Combine(DESKTOPPATH, "FusionadoPDF.pdf"); ;

            try
            {
                // Crear un documento vacío donde se fusionarán los archivos PDF
                using (PdfDocument outputDocument = new PdfDocument())
                {
                    foreach (string pdfFile in pdfFiles)
                    {
                        // Abrir cada archivo PDF
                        using (PdfDocument inputDocument = PdfReader.Open(pdfFile, PdfDocumentOpenMode.Import))
                        {
                            // Añadir todas las páginas del PDF actual al documento de salida
                            for (int i = 0; i < inputDocument.PageCount; i++)
                            {
                                PdfPage page = inputDocument.Pages[i];
                                outputDocument.AddPage(page);
                            }
                        }
                    }

                    // Guardar el documento fusionado en el escritorio
                    outputDocument.Save(outputFilePath);
                }

                MessageBox.Show($"Archivos PDF fusionados con éxito. Guardado en el escritorio: {outputFilePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al fusionar los archivos PDF: {ex.Message}");
            }
        }
    }
}
