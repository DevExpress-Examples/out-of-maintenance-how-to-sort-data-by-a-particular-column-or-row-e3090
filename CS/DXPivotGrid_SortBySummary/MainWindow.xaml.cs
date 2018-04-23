using System.Windows;
using DevExpress.Xpf.PivotGrid;

namespace DXPivotGrid_SortBySummary {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = 
                (new nwindDataSetTableAdapters.SalesPersonTableAdapter()).GetData();
        }
        private void pivotGridControl1_Loaded(object sender, RoutedEventArgs e) {

            // Locks the pivot grid from updating while the Sort by Summary
            // settings are being customized.
            pivotGridControl1.BeginUpdate();
            try {

                // Specifies a data field whose summary values should be used to sort values
                // of the Product Name field.
                fieldProductName.SortByField = fieldUnitPrice;

                // Specifies a column by which the Product Name field values should be sorted.
                fieldProductName.SortByConditions.Add(new SortByCondition(fieldYear, "1994"));
                fieldProductName.SortByConditions.Add(new SortByCondition(fieldMonth, "9"));
            }
            finally {

                // Unlocks the pivot grid and applies changes.
                pivotGridControl1.EndUpdate();
            }
        }
    }
}
