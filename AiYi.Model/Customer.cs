using GalaSoft.MvvmLight;

namespace AiYi.Model
{
    /// <summary>
    /// 登录用户基本信息
    /// </summary>
    public class Customer : ViewModelBase
    {
        private long _Id;
        /// <summary>
        /// 用户编号
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
        private string _UserName;
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return _UserName; }
            set { Set(ref _UserName, value); }
        }
        private string _Password;
        /// <summary>
        ///用户密码
        /// </summary>
        public string Password
        {
            get { return _Password; }
            set { Set(ref _Password, value); }
        }
        private string _Token;
        /// <summary>
        ///Token
        /// </summary>
        public string Token
        {
            get { return _Token; }
            set { Set(ref _Token, value); }
        }
        private string _PrivateKey;
        /// <summary>
        ///用户私钥
        /// </summary>
        public string PrivateKey
        {
            get { return _PrivateKey; }
            set { Set(ref _PrivateKey, value); }
        }

        //
    }
}
