using GalaSoft.MvvmLight;

namespace AiYi.Model
{
    /// <summary>
    /// 参考测试类
    /// </summary>
    class Test : ViewModelBase
    {
        private string title;
        /// <summary>
        /// 标题(请写清楚备注)
        /// </summary>
        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }
    }
}
