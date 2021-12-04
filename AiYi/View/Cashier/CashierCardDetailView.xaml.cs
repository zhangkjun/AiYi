using System.Windows;
using System.Windows.Controls;

namespace AiYi.View
{
    /// <summary>
    /// CashierCardDetailView.xaml 的交互逻辑
    /// </summary>
    public partial class CashierCardDetailView : UserControl
    {
        public CashierCardDetailView()
        {
            InitializeComponent();
            this.BtnCharge.Click += BtnCharge_Click;
            this.BtnCanel.Click += BtnCanel_Click;
        }

        private void BtnCharge_Click(object sender, RoutedEventArgs e)
        {
            this.popupCharge.IsOpen = true;
        }

        private void BtnCanel_Click(object sender, RoutedEventArgs e)
        {
            this.popupCharge.IsOpen = false;
        }
    }
}
