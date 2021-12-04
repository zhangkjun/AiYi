
namespace AiYi.Model
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Product : ViewModelBase
    {
        private long _Id;
        /// <summary>
        /// 商品编号
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
        private string _Number;
        /// <summary>
        /// 商品代码
        /// </summary>
        public string Number
        {
            get { return _Number; }
            set { Set(ref _Number, value); }
        }
        private string _Name;
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { Set(ref _Name, value); }
        }
        private string _Images;
        /// <summary>
        /// 商品图片的url
        /// </summary>
        public string Images
        {
            get { return _Images; }
            set { Set(ref _Images, value); }
        }
        private decimal _WebPrice;
        /// <summary>
        /// 商品价格
        /// </summary>
        public decimal WebPrice
        {
            get { return _WebPrice; }
            set { Set(ref _WebPrice, value); }
        }
        private string _Premium;
        /// <summary>
        /// 计量单位
        /// </summary>
        public string Premium
        {
            get { return _Premium; }
            set { Set(ref _Premium, value); }
        }
        private decimal _Quantity;
        /// <summary>
        /// 商品库存量
        /// </summary>
        public decimal Quantity
        {
            get { return _Quantity; }
            set { Set(ref _Quantity, value); }
        }
        private int _Status;
        /// <summary>
        /// 商品状态1正常2已经沽清3已经删除
        /// </summary>
        public int Status
        {
            get { return _Status; }
            set { Set(ref _Status, value); }
        }
        private long _OrderId;
        /// <summary>
        /// 商品排序编号
        /// </summary>
        public long OrderId
        {
            get { return _OrderId; }
            set { Set(ref _OrderId, value); }
        }

        private long _CategoryId;
        /// <summary>
        /// 所属分类
        /// </summary>
        public long CategoryId
        {
            get { return _CategoryId; }
            set { Set(ref _CategoryId, value); }
        }

        private int _ChooseCount;
        /// <summary>
        /// 已点份数
        /// </summary>
        public int ChooseCount
        {
            get { return _ChooseCount; }
            set { Set(ref _ChooseCount, value); }
        }


        private decimal _hyj;
        /// <summary>
        /// 会员价
        /// </summary>
        public decimal HYJ
        {
            get { return _hyj; }
            set { Set(ref _hyj, value); }
        }



        private decimal _tj;
        /// <summary>
        /// 特价
        /// </summary>
        public decimal TJ
        {
            get { return _tj; }
            set { Set(ref _tj, value); }
        }


        private string _spec;
        /// <summary>
        /// 规格
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { Set(ref _spec, value); }
        }


        private bool _spbz;
        /// <summary>
        /// 收牌标志    
        /// </summary>
        public bool SPBZ
        {
            get { return _spbz; }
            set { Set(ref _spbz, value); }
        }

    }
}
