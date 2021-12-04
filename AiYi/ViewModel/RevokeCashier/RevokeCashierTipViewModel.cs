using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class RevokeCashierTipViewModel : ViewModelBase
    {
        public RevokeCashierTipViewModel()
        {
            OrderNO = "1506150009";

            CheckPwdVisibility = Visibility.Visible;
            CXDDVisibility = Visibility.Collapsed;
        }

        #region 属性
        private string _orderNO;
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNO
        {
            get { return _orderNO; }
            set
            {
                Set(ref _orderNO, value);
            }
        }

        private string _msg;
        /// <summary>
        /// 提示消息
        /// </summary>
        public string Msg
        {
            get { return _msg; }
            set { Set(ref _msg, value); }
        }

        private Visibility _checkPwdVisibility;
        /// <summary>
        /// 密码输入隐藏显示
        /// </summary>
        public Visibility CheckPwdVisibility
        {
            get { return _checkPwdVisibility; }
            set { Set(ref _checkPwdVisibility, value); }
        }

        private Visibility _CXDDVisibility;
        /// <summary>
        /// 撤销隐藏显示
        /// </summary>
        public Visibility CXDDVisibility
        {
            get { return _CXDDVisibility; }
            set { Set(ref _CXDDVisibility, value); }
        }
        #endregion


        #region 命令
        /// <summary>
        /// 验证密码
        /// </summary>
        public ICommand CheckPwdCommand => new RelayCommand(() =>
        {
            Msg = "";
            CheckPwdVisibility = Visibility.Collapsed;
            CXDDVisibility = Visibility.Visible;
        });



        #endregion


    }
}
