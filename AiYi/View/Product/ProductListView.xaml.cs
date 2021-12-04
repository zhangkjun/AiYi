using System;
using System.Windows.Controls;

namespace AiYi.View
{
    /// <summary>
    /// ProductListView.xaml 的交互逻辑
    /// </summary>
    public partial class ProductListView : UserControl
    {
        public ProductListView()
        {
            InitializeComponent();

            DataGridProductList.LoadingRow += new EventHandler<DataGridRowEventArgs>(DataGridProductList_LoadingRow);
        }

        private void DataGridProductList_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

    }
}
