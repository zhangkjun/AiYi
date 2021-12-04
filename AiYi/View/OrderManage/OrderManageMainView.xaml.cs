using AiYi.Common;
using AiYi.Service;
using CommonServiceLocator;
using System.Windows;
using System.Windows.Controls;

namespace AiYi.View
{
    /// <summary>
    /// OrderManageMainView.xaml 的交互逻辑
    /// </summary>
    public partial class OrderManageMainView : UserControl
    {
        public OrderManageMainView()
        {
            InitializeComponent();

            this.BtnChangeNum.Click += BtnChangeNum_Click;
        }

        private void BtnChangeNum_Click(object sender, RoutedEventArgs e)
        {
            this.popupNum.IsOpen = true;
        }


        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                popupMore.PlacementTarget = button;
                popupMore.IsOpen = true;
            }
        }

        private void BtnAddDish_Click(object sender, RoutedEventArgs e)
        {           
            ContentPresenter contentPresenter = (ContentPresenter)ControlHelper.FindParent<ContentPresenter>(this);
            TabControl tabControl = (TabControl)ControlHelper.FindParent<TabControl>(contentPresenter);

            SimpleIoc.Default.GetInstance<FrameNavigationService>().NavigateTo("order");

            tabControl.SelectedIndex = 0;
        }
    }
}
