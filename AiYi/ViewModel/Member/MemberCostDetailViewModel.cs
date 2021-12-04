using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace AiYi.ViewModel
{
    public class MemberCostDetailViewModel : ViewModelBase
    {
        public MemberCostDetailViewModel()
        {
            CardNO = "510241214";
            Name = "宇宙人";

            MemberCostDetailList = new ObservableCollection<MemberCostDetail>();
            for (int i = 0; i < 10; i++)
            {
                MemberCostDetailList.Add(new MemberCostDetail { CostDate = "2015.01.25", CostMoney = 100.00, BalanceMoney = 1900.00 });
                MemberCostDetailList.Add(new MemberCostDetail { CostDate = "2014.12.03", CostMoney = 215.00, BalanceMoney = 1685.00 });
                MemberCostDetailList.Add(new MemberCostDetail { CostDate = "2014.11.26", CostMoney = 300.00, BalanceMoney = 1385.00 });
                MemberCostDetailList.Add(new MemberCostDetail { CostDate = "2014.11.13", CostMoney = 485.00, BalanceMoney = 900.00 });

            }
        }

        #region 属性
        private ObservableCollection<MemberCostDetail> _memberCostDetailList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<MemberCostDetail> MemberCostDetailList
        {
            get { return _memberCostDetailList; }
            set { Set(ref _memberCostDetailList, value); }
        }

        private string _cardNO;
        /// <summary>
        /// 会员卡号
        /// </summary>
        public string CardNO
        {
            get { return _cardNO; }
            set
            {
                Set(ref _cardNO, value);
            }
        }

        private string _name;
        /// <summary>
        /// 会员姓名
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                Set(ref _name, value);
            }
        }
        #endregion

    }

    public class MemberCostDetail
    {
        public string CostDate { get; set; }
        public double CostMoney { get; set; }

        public double BalanceMoney { get; set; }
    }

}
