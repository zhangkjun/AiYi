using GalaSoft.MvvmLight;

namespace AiYi.Model
{
    /// <summary>
    /// 桌台区域列表
    /// </summary>
  
    public class DeskCategory : ViewModelBase
    {
        private long _Id;
        /// <summary>
        /// 区域列表编号
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
        /// 区域名称
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
        private int _Status;
        /// <summary>
        /// 状态1正常2下架3删除
        /// </summary>
        public int Status
        {
            get { return _Status; }
            set { Set(ref _Status, value); }
        }
    }
}
