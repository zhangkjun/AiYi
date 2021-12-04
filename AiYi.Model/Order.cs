
namespace AiYi.Model
{
    /// <summary>
    /// 订单
    /// </summary>
    public class Order : ViewModelBase
    {
        private string _Id;
        /// <summary>
        /// 订单号
        /// </summary>
        public string Id
        {
            get { return _Id; }
            set { Set(ref _Id, value); }
        }
        private long _MerchantId;
        /// <summary>
        /// 商户编号
        /// </summary>
        public long MerchantId
        {
            get { return _MerchantId; }
            set { Set(ref _MerchantId, value); }
        }
        private string _DeskId;
        /// <summary>
        /// 就餐桌台的json数据，为空则为不需要桌台的模式
        /// </summary>
        public string DeskId
        {
            get { return _DeskId; }
            set { Set(ref _DeskId, value); }
        }
        private string _Waiter;
        /// <summary>
        /// 服务员的json数据
        /// </summary>
        public string Waiter
        {
            get { return _Waiter; }
            set { Set(ref _Waiter, value); }
        }
        private long _Cashier;
        /// <summary>
        /// 收银员的编号
        /// </summary>
        public long Cashier
        {
            get { return _Cashier; }
            set { Set(ref _Cashier, value); }
        }
        private decimal _Amount;
        /// <summary>
        /// 订单金额
        /// </summary>
        public decimal Amount
        {
            get { return _Amount; }
            set { Set(ref _Amount, value); }
        }
        private decimal _WipingZero;
        /// <summary>
        /// 抹零金额
        /// </summary>
        public decimal WipingZero
        {
            get { return _WipingZero; }
            set { Set(ref _WipingZero, value); }
        }
        private decimal _DiscountAmount;
        /// <summary>
        /// 折扣金额
        /// </summary>
        public decimal DiscountAmount
        {
            get { return _DiscountAmount; }
            set { Set(ref _DiscountAmount, value); }
        }
        private decimal _TableFee;
        /// <summary>
        /// 包间费用
        /// </summary>
        public decimal TableFee
        {
            get { return _TableFee; }
            set { Set(ref _TableFee, value); }
        }
        private decimal _TrueAmount;
        /// <summary>
        /// 实收金额
        /// </summary>
        public decimal TrueAmount
        {
            get { return _TrueAmount; }
            set { Set(ref _TrueAmount, value); }
        }
        private DateTime _CreateTime;
        /// <summary>
        /// 点餐时间
        /// </summary>
        public DateTime CreateTime
        {
            get { return _CreateTime; }
            set { Set(ref _CreateTime, value); }
        }
        private DateTime _PayTime;
        /// <summary>
        /// 买单时间
        /// </summary>
        public DateTime PayTime
        {
            get { return _PayTime; }
            set { Set(ref _PayTime, value); }
        }
        private long _Mealtimes;
        /// <summary>
        /// 餐次编号
        /// </summary>
        public long Mealtimes
        {
            get { return _Mealtimes; }
            set { Set(ref _Mealtimes, value); }
        }
        private int _Staus;
        /// <summary>
        /// 当前单子状态0点餐中1结账未支付，2支付成功
        /// </summary>
        public int Staus
        {
            get { return _Staus; }
            set { Set(ref _Staus, value); }
        }
    }
}
