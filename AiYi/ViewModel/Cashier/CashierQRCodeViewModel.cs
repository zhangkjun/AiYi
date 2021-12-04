using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class CashierQRCodeViewModel : ViewModelBase
    {
        public CashierQRCodeViewModel()
        {
            ReceivableMoney = Math.Round(136.2, 2);
            CodeStateVisbie = Visibility.Collapsed;
        }

        #region 属性
        private double _receivableMoney = 0.0;
        /// <summary>
        /// 应收总额
        /// </summary>
        public double ReceivableMoney
        {
            get { return _receivableMoney; }
            set
            {
                Set(ref _receivableMoney, value);
            }
        }


        private Visibility _codeStateVisbie;
        /// <summary>
        /// 隐藏显示
        /// </summary>
        public Visibility CodeStateVisbie
        {
            get { return _codeStateVisbie; }
            set { Set(ref _codeStateVisbie, value); }
        }

        #endregion


        #region 命令


        /// <summary>
        /// 支付
        /// </summary>
        public ICommand PayCommand => new RelayCommand(() =>
        {
            CodeStateVisbie = Visibility.Visible;
        });

        /// <summary>
        /// 关闭
        /// </summary>
        public ICommand CloseCommand => new RelayCommand(() =>
        {
            var windows = System.Windows.Application.Current.Windows;
            foreach (Window window in windows)
            {
                string name = window.Name;
                if (name == "CashierQRCode")
                {
                    window.Close();
                }
                if (name == "CashierMain")
                {
                    window.Close();
                }
            }
        });
        #endregion

    }
}
