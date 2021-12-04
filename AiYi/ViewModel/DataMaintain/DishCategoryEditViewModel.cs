using AiYi.Model;
using GalaSoft.MvvmLight;

namespace AiYi.ViewModel
{
    public class DishCategoryEditViewModel : ViewModelBase
    {
        public DishCategoryEditViewModel()
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

    }
}
