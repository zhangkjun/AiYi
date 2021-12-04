using AiYi.Service;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class CashierCardSearchViewModel : ViewModelBase
    {
        public CashierCardSearchViewModel()
        {
            StoreCardUserList = new ObservableCollection<StoreCardUser>();
            for (int i = 0; i < 10; i++)
            {
                StoreCardUserList.Add(new StoreCardUser { Name = "宇宙人" + (i + 1), CardNO = "007", PhoneNum = "12345678912" });
                StoreCardUserList.Add(new StoreCardUser { Name = "张三丰" + (i + 1), CardNO = "010", PhoneNum = "12545678912" });
            }
        }

        #region 属性
        private ObservableCollection<StoreCardUser> _storeCardUserList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<StoreCardUser> StoreCardUserList
        {
            get { return _storeCardUserList; }
            set { Set(ref _storeCardUserList, value); }
        }

        #endregion

        #region 命令
        /// <summary>
        /// 储值卡详情
        /// </summary>
        public ICommand StoreCardDetailCommand => new RelayCommand<StoreCardUser>((e) =>
        {
            if (e is StoreCardUser user)
            {
                SimpleIoc.Default.GetInstance<CashierCardFrameNavigationService>().NavigateTo("detail", user);
            }
        });
        #endregion

    }

    public class StoreCardUser
    {
        public string Name { get; set; }

        public string CardNO { get; set; }
        public string PhoneNum { get; set; }
        /// <summary>
        /// 充值总额
        /// </summary>
        public double TotalRecharge { get; set; }
        /// <summary>
        /// 消费总额
        /// </summary>
        public double TotalCost { get; set; }
        /// <summary>
        /// 储值余额
        /// </summary>
        public double Balance { get; set; }
        /// <summary>
        /// 赠送总额
        /// </summary>
        public double TotalGive { get; set; }
        /// <summary>
        /// 赠送消费总额
        /// </summary>
        public double TotalGiveCost { get; set; }
        /// <summary>
        /// 赠送余额
        /// </summary>
        public double GiveBalance { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        public double Score { get; set; }
    }
}
