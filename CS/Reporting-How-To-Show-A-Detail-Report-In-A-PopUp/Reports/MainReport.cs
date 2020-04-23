using DevExpress.XtraReports.UI;

namespace ShowDetailReportInPopup.Reports {
    public partial class MainReport {
        public MainReport() {
            InitializeComponent();
        }

        private void tableCell_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRTableCell cell = sender as XRTableCell;
            cell.Tag = string.Format("{0},{1}", GetCurrentColumnValue("CategoryID"), GetCurrentColumnValue("CategoryName"));
        }
    }
}
