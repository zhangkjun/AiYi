using AiYi.Model;
using AiYi.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class DishDetailViewModel : ViewModelBase
    {
        public DishDetailViewModel()
        {
            GetDish = new Product() { Id = 1, Name = "家常拌土鸡", WebPrice = Convert.ToDecimal("45.40"), Premium = "例份", ChooseCount = 1, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571480393250&di=cd5bce378e66ba31033cf1004feec3e6&imgtype=0&src=http%3A%2F%2Fimg8.lamaqun.com%2Fupload%2Ftopic%2Fday_130625%2F201306251302094890.jpg" };

        }

        #region 属性
        private Product _getDish;
        /// <summary>
        /// 选中的菜品
        /// </summary>
        public Product GetDish
        {
            get { return _getDish; }
            set
            {
                Set(ref _getDish, value);
            }
        }
        #endregion

        #region 命令
        /// <summary>
        /// 跳转删除界面
        /// </summary>
        public ICommand JumpDelCommand => new RelayCommand(() =>
        {
            DishDelTipView tipWindow = new DishDelTipView();
            tipWindow.Show();
        });

        /// <summary>
        /// 跳转编辑界面
        /// </summary>
        public ICommand JumpEditCommand => new RelayCommand<Window>((e) =>
        {
            if (e is Window window)
            {
                if (window != null)
                {
                    window.Close();
                    DishDataEditView editWindow = new DishDataEditView();
                    editWindow.Show();
                }
            }
        });

        #endregion

    }
}
