using GalaSoft.MvvmLight;

namespace AiYi.ViewModel
{
    public class PrintSetViewModel : ViewModelBase
    {
        public PrintSetViewModel()
        {
            IsIntimidate = true;
        }

        private bool _isIntimidate;
        /// <summary>
        /// 是否打单
        /// </summary>
        public bool IsIntimidate
        {
            get { return _isIntimidate; }
            set { Set(ref _isIntimidate, value); }
        }

    }
}
