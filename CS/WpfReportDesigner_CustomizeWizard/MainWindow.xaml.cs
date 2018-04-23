using System.Windows;

namespace WpfReportDesigner_CustomizeWizard {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            reportDesigner.Loaded += ReportDesigner_Loaded;
        }

        void ReportDesigner_Loaded(object sender, RoutedEventArgs e) {
            reportDesigner.Loaded -= ReportDesigner_Loaded;
            reportDesigner.ActualCommands.NewDocumentCommand.Execute(null);
        }
    }
}
