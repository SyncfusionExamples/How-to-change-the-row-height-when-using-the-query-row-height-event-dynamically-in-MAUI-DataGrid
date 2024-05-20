using Syncfusion.Maui.DataGrid.Helper;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void dataGrid_QueryRowHeight(object sender, Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
                e.Handled = true;
            }
        }

        private void dataGrid_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName!.Equals("Width"))
            {
                var VisibleRowCount = dataGrid.GetVisualContainer().ScrollRows.GetVisibleLines().Count;
                for (int i = 0; i < VisibleRowCount; i++)
                {
                    dataGrid.InvalidateRowHeight(i);
                }
            }
        }

        private void dataGrid_ColumnResizing(object sender, Syncfusion.Maui.DataGrid.DataGridColumnResizingEventArgs e)
        {
            var VisibleRowCount = dataGrid.GetVisualContainer().ScrollRows.GetVisibleLines().Count;
            for (int i = 0; i < VisibleRowCount; i++)
            {
                dataGrid.InvalidateRowHeight(i);
            }
        }
    }

}
