using GalaSoft.MvvmLight;

namespace AiYi.Model
{
    /// <summary>
    /// 桌台列表
    /// </summary>
    public class Desk : ViewModelBase
    {
        private long _Id;
        /// <summary>
        ///编号
        /// </summary>
        public long Id
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
        private string _Name;
        /// <summary>
        /// 桌台名称
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { Set(ref _Name, value); }
        }
        private decimal _WebPrice;
        /// <summary>
        /// 包间费用
        /// </summary>
        public decimal WebPrice
        {
            get { return _WebPrice; }
            set { Set(ref _WebPrice, value); }
        }
        private int _Status;
        /// <summary>
        /// 状态1正常2下架3已经删除
        /// </summary>
        public int Status
        {
            get { return _Status; }
            set { Set(ref _Status, value); }
        }
        private long _OrderId;
        /// <summary>
        /// 排序编号
        /// </summary>
        public long OrderId
        {
            get { return _OrderId; }
            set { Set(ref _OrderId, value); }
        }
        private decimal _FreePrice;
        /// <summary>
        /// 消费多少免包间费用
        /// </summary>
        public decimal FreePrice
        {
            get { return _FreePrice; }
            set { Set(ref _FreePrice, value); }
        }
        //
    }
}
