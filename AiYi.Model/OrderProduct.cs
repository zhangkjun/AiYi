using GalaSoft.MvvmLight;

namespace AiYi.Model
{
    /// <summary>
    /// 订单详情
    /// </summary>
    public class OrderProduct : ViewModelBase
    {
        private long _Id;
        /// <summary>
        /// 编号
        /// </summary>
        public long Id
        {
            get { return _Id; }
            set { Set(ref _Id, value); }
        }
        private string _OrderId;
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderId
        {
            get { return _OrderId; }
            set { Set(ref _OrderId, value); }
        }
        private long _ProductId;
        /// <summary>
        /// 产品编号
        /// </summary>
        public long ProductId
        {
            get { return _ProductId; }
            set { Set(ref _ProductId, value); }
        }
        private decimal _Quantity;
        /// <summary>
        /// 产品数量
        /// </summary>
        public decimal Quantity
        {
            get { return _Quantity; }
            set { Set(ref _Quantity, value); }
        }
        private decimal _ProductPrice;
        /// <summary>
        /// 产品单价
        /// </summary>
        public decimal ProductPrice
        {
            get { return _ProductPrice; }
            set { Set(ref _ProductPrice, value); }
        }
        private decimal _TotalPrice;
        /// <summary>
        /// 产品总监
        /// </summary>
        public decimal TotalPrice
        {
            get { return _TotalPrice; }
            set { Set(ref _TotalPrice, value); }
        }
        private string _Notes;
        /// <summary>
        /// 产品备注
        /// </summary>
        public string Notes
        {
            get { return _Notes; }
            set { Set(ref _Notes, value); }
        }
        private int _IsPrint;
        /// <summary>
        /// 后台是否已经打印
        /// </summary>
        public int IsPrint
        {
            get { return _IsPrint; }
            set { Set(ref _IsPrint, value); }
        }
        private int _Batch;
        /// <summary>
        /// 点菜批次
        /// </summary>
        public int Batch
        {
            get { return _Batch; }
            set { Set(ref _Batch, value); }
        }
    }
}
