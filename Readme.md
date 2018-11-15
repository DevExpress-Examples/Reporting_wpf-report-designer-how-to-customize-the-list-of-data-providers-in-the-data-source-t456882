<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfReportDesigner_CustomizeWizard/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfReportDesigner_CustomizeWizard/MainWindow.xaml))
* **[MyWizardCustomizationService.cs](./CS/WpfReportDesigner_CustomizeWizard/MyWizardCustomizationService.cs) (VB: [MyWizardCustomizationService.vb](./VB/WpfReportDesigner_CustomizeWizard/MyWizardCustomizationService.vb))**
<!-- default file list end -->
# WPF Report Designer - How to customize the list of data providers in the Data Source Wizard


<p>This example illustrates how to customize the list of data providers displayed on the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument114853">Specify a Connection String</a> page of the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument115389">Data Source wizard</a> and <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument115390">Report wizard</a> (e.g., to leave only the <strong>Microsoft SQL Server</strong> option), as well as make the wizard always start with this page.</p>
<p>To do this, assign an object implementing the <strong>DevExpress.Xpf.Reports.UserDesigner.IWizardCustomizationService</strong> interface to the <strong>ReportDesigner.ServicesRegistry</strong> property.<br><br><strong>See Also<br></strong><a href="https://www.devexpress.com/Support/Center/p/T600080">WPF Report Designer - How to register a custom page in the Report Wizard</a></p>

<br/>


