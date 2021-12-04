using AiYi.Model;
using AiYi.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class DishCategoryDetailViewModel : ViewModelBase
    {
        public DishCategoryDetailViewModel()
        {
            GetCategory = new Category() { Code = "L-A6", Name = "凉菜" };
        }

        #region 属性
        private Category _getCategory;
        /// <summary>
        /// 选中的菜品类别
        /// </summary>
        public Category GetCategory
        {
            get { return _getCategory; }
            set
            {
                Set(ref _getCategory, value);
            }
        }
        #endregion


        #region 命令
        /// <summary>
        /// 跳转删除界面
        /// </summary>
        public ICommand JumpDelCommand => new RelayCommand(() =>
        {
            DishCategoryDelTipView tipWindow = new DishCategoryDelTipView();
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
                    DishCategoryEditView editWindow = new DishCategoryEditView();
                    editWindow.Show();
                }
            }
        });

        #endregion

    }
}
