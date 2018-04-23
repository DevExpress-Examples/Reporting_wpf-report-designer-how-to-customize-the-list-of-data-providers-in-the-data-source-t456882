Imports System.Windows

Namespace WpfReportDesigner_CustomizeWizard
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            AddHandler reportDesigner.Loaded, AddressOf ReportDesigner_Loaded
        End Sub

        Private Sub ReportDesigner_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RemoveHandler reportDesigner.Loaded, AddressOf ReportDesigner_Loaded
            reportDesigner.ActualCommands.NewDocumentCommand.Execute(Nothing)
        End Sub
    End Class
End Namespace
