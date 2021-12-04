
namespace AiYi.Model
{
    /// <summary>
    /// 商户基本信息表
    /// </summary>
    public class Merchant : ViewModelBase
    {
        private long _Id;
        /// <summary>
        /// 商户编号
        /// </summary>
        public long Id
        {
            get { return _Id; }
            set { Set(ref _Id, value); }
        }
        private string _Name;
        /// <summary>
        /// 商户名称
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { Set(ref _Name, value); }
        }
        private string _ShortName;
        /// <summary>
        /// 商户简称
        /// </summary>
        public string ShortName
        {
            get { return _ShortName; }
            set { Set(ref _ShortName, value); }
        }
    }
}
