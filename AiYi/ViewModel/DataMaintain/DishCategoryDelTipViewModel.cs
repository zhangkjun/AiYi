using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class DishCategoryDelTipViewModel : ViewModelBase
    {
        public DishCategoryDelTipViewModel()
        {
        }


        #region 命令
        /// <summary>
        /// 跳转编辑界面
        /// </summary>
        public ICommand DelCommand => new RelayCommand<Window>((e) =>
        {
            if (e is Window window)
            {
                if (window != null)
                {
                    window.Close();

                    var windows = System.Windows.Application.Current.Windows;
                    foreach (Window getWindow in windows)
                    {
                        string name = getWindow.Name;
                        if (name == "DishCategoryDetail")
                        {
                            getWindow.Close();
                        }
                    }
                }
            }
        });

        #endregion

    }
}
