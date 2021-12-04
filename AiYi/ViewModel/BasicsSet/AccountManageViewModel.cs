using AiYi.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class AccountManageViewModel : ViewModelBase
    {
        public AccountManageViewModel()
        {
            CurrentAccount = "宇宙人";
        }


        #region 属性
        private string _currentAccount;
        /// <summary>
        /// 当前账号
        /// </summary>
        public string CurrentAccount
        {
            get { return _currentAccount; }
            set { Set(ref _currentAccount, value); }
        }
        #endregion

        #region 命令


        /// <summary>
        /// 注销Command
        /// </summary>
        public ICommand LogoutCommand => new RelayCommand(() =>
        {
            AccountLogoutTipView window = new AccountLogoutTipView();
            window.Show();
        });

        #endregion

    }
}
