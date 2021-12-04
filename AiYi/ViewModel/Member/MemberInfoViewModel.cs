using AiYi.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class MemberInfoViewModel : ViewModelBase
    {
        public MemberInfoViewModel()
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
        /// 会员消费明细
        /// </summary>
        public ICommand MemberCostDetailCommand => new RelayCommand(() =>
        {
            MemberCostDetailView window = new MemberCostDetailView();
            window.Show();
        });

        /// <summary>
        /// 确定充值
        /// </summary>
        public ICommand ReChargeCommand => new RelayCommand(() =>
        {
            TipView window = new TipView("充值成功！");
            window.Show();
        });
        #endregion

    }
}
