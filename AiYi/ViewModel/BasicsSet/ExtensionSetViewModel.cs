using GalaSoft.MvvmLight;
using System.Windows;

namespace AiYi.ViewModel
{
    public class ExtensionSetViewModel : ViewModelBase
    {
        public ExtensionSetViewModel()
        {
            LocalIP = "192.168.10.11";

            SwitchboardIPVisbie = Visibility.Collapsed;
        }

        #region 属性
        private bool _isExtension;
        /// <summary>
        /// 设为分机
        /// </summary>
        public bool IsExtension
        {
            get { return _isExtension; }
            set
            {
                Set(ref _isExtension, value);

                SwitchboardIPVisbie = Visibility.Collapsed;
                if (value)
                {
                    SwitchboardIPVisbie = Visibility.Visible;
                }
            }
        }

        private Visibility _switchboardIPVisbie;
        /// <summary>
        /// 总机IP隐藏显示
        /// </summary>
        public Visibility SwitchboardIPVisbie
        {
            get { return _switchboardIPVisbie; }
            set { Set(ref _switchboardIPVisbie, value); }
        }

        private string _localIP;
        /// <summary>
        /// 本机IP
        /// </summary>
        public string LocalIP
        {
            get { return _localIP; }
            set { Set(ref _localIP, value); }
        }
        #endregion

    }
}
