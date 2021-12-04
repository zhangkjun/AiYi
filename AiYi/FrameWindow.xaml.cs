using CommonServiceLocator;
using GalaSoft.MvvmLight.Views;
using System.Windows;

namespace AiYi
{
    public partial class FrameWindow : Window
    {
        public FrameWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 跳转至登录
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
             SimpleIoc.Default.GetInstance<INavigationService>().NavigateTo("login");
            //SimpleIoc.Default.GetInstance<INavigationService>().NavigateTo("login");
        }
    }
}
