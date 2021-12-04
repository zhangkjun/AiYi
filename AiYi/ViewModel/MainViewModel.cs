using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Title = "AiYi";
        }

        private string title = "AiYi";
        /// <summary>
        /// 窗口标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }

        /// <summary>
        /// 修改标题
        /// </summary>
        public ICommand ChangeTitleCommand => new RelayCommand(() =>
        {
            Title = "Hello AiYi";
        });

        //mvvminpc 属性
        //mvvmrelay 命令
        //mvvmrelaycanexecute 命令(附带Canexecute)
        //mvvmrelaygeneric 命令(带参)
    }
}