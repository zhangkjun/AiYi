using AiYi.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class CashierCardDetailViewModel : ViewModelBase
    {
        public CashierCardDetailViewModel()
        {
            StoreCardUser = new StoreCardUser { Name = "宇宙人", CardNO = "007", PhoneNum = "12345678912", TotalRecharge = Math.Round(999.99, 2), TotalCost = Math.Round(555.99, 2), Balance = Math.Round(666.99, 2), TotalGive = Math.Round(200.99, 2), TotalGiveCost = Math.Round(99.99, 2), GiveBalance = Math.Round(180.99, 2), Score = Math.Round(2108.00, 2) };
        }

        #region 属性
        private StoreCardUser _storeCardUser;
        /// <summary>
        /// 列表
        /// </summary>
        public StoreCardUser StoreCardUser
        {
            get { return _storeCardUser; }
            set { Set(ref _storeCardUser, value); }
        }
        #endregion


        #region 命令
        /// <summary>
        /// 储值卡结账
        /// </summary>
        /// </summary>
        public ICommand StoreCardCostCommand => new RelayCommand(() =>
        {
            TipView tipWindow = new TipView("收款成功");
            tipWindow.Show();

            var windows = System.Windows.Application.Current.Windows;
            foreach (Window window in windows)
            {
                string name = window.Name;
                if (name == "CashierCardMain")
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
