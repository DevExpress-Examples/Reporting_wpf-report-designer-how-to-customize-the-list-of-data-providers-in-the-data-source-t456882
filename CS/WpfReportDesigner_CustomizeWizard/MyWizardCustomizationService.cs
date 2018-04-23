using System.Collections.Generic;
using DevExpress.DataAccess.Native.Sql.ConnectionStrategies;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.Utils.IoC;
using DevExpress.Xpf.DataAccess.DataSourceWizard;
using DevExpress.Xpf.Reports.UserDesigner.ReportWizard;
using DevExpress.Xpf.Reports.UserDesigner.ReportWizard.Pages;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Wizards;
using DevExpress.DataAccess.UI.Wizard;
using DevExpress.XtraReports.Wizards.Presenters;

namespace WpfReportDesigner_CustomizeWizard {
    public class MyWizardCustomizationService : IWizardCustomizationService {
        void IDataSourceWizardCustomizationService.CustomizeDataSourceWizard(DataSourceWizardCustomizationModel customization, ViewModelSourceIntegrityContainer container) {
            if(customization.StartPage == typeof(ChooseDataSourceTypePage<IDataSourceModel>)) {
                customization.Model.DataSourceType = DataSourceType.Xpo;
                customization.StartPage = typeof(ConnectionPropertiesPage<IDataSourceModel>);
            }
            CustomizeProviders(container);
        }

        void IWizardCustomizationService.CustomizeReportWizard(ReportWizardCustomizationModel customization, ViewModelSourceIntegrityContainer container) {
            if(customization.StartPage == typeof(ChooseReportTypePage<XtraReportModel>)) {
                customization.Model.ReportType = ReportType.Standard;
                customization.Model.DataSourceType = DataSourceType.Xpo;
                customization.StartPage = typeof(ConnectionPropertiesPage<XtraReportModel>);
            }
            CustomizeProviders(container);
        }

        bool IDataSourceWizardCustomizationService.TryCreateDataSource(IDataSourceModel model, out object dataSource, out string dataMember) {
            dataSource = null;
            dataMember = null;
            return false;
        }

        bool IWizardCustomizationService.TryCreateReport(XtraReportModel model, out XtraReport report) {
            report = null;
            return false;
        }

        static void CustomizeProviders(IntegrityContainer container) {
            var providers = container.Resolve<List<ProviderLookupItem>>();
            providers.RemoveAll((ProviderLookupItem x) => x.ProviderKey != "MSSqlServer");
        }
    }
}
