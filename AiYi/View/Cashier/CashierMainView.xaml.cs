using System.Windows;

namespace AiYi.View
{
    /// <summary>
    /// CashierMainView.xaml 的交互逻辑
    /// </summary>
    public partial class CashierMainView
    {
        public CashierMainView()
        {
            InitializeComponent();

            this.BtnDiscount.Click += BtnDiscount_Click;
            this.BtnDiscountWC.Click += BtnDiscountWC_Click;
        }

        private void BtnDiscount_Click(object sender, RoutedEventArgs e)
        {
            this.popupDiscount.IsOpen = true;
        }

        private void BtnDiscountWC_Click(object sender, RoutedEventArgs e)
        {
            this.popupDiscount.IsOpen = false;
        }

    }
}
