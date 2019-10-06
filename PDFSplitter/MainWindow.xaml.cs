using Microsoft.Win32;
using PDFSplitter.Core;
using System.Text;
using System.Windows;

namespace PDFSplitter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            System.Text.Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            InitializeComponent();
        }

        private void FileChooseBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dog = new OpenFileDialog();
            dog.Filter = "PDF Files|*.pdf";
            if (dog.ShowDialog() == true)
            {
                FileChosen.Text = dog.FileName;
            }
        }

        private void GenerateBtn_Click(object sender, RoutedEventArgs e)
        {
            var pdf = new PDFTextExtractor();
            pdf.SplitPDF(FileChosen.Text, SearchExpr.Text);
        }
    }
}
