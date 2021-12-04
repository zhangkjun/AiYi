using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System.Windows;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class AccountLogoutTipViewModel : ViewModelBase
    {
        public AccountLogoutTipViewModel()
        {
        }


        #region 命令
        /// <summary>
        /// 注销账号
        /// </summary>
        public ICommand LogoutCommand => new RelayCommand<Window>((e) =>
        {
            if (e is Window window)
            {
                window.Close();
                SimpleIoc.Default.GetInstance<INavigationService>().NavigateTo("login");
            }
        });
        #endregion

    }
}
