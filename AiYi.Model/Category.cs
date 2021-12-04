using GalaSoft.MvvmLight;

namespace AiYi.Model
{
    /// <summary>
    /// 产品分类
    /// </summary>
    public class Category : ViewModelBase
    {
        private long _Id;
        /// <summary>
        /// 分类编号
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
        /// 分类名称
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { Set(ref _Name, value); }
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

        private string _Code;
        /// <summary>
        /// 类别编码
        /// </summary>
        public string Code
        {
            get { return _Code; }
            set { Set(ref _Code, value); }
        }

    }
}
