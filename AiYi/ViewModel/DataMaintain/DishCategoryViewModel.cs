using AiYi.Model;
using AiYi.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class DishCategoryViewModel : ViewModelBase
    {
        ObservableCollection<Category> AllCategoryList;
        public DishCategoryViewModel()
        {
            AllCategoryList = new ObservableCollection<Category>();

            AllCategoryList.Add(new Category() { Id = 1, Name = "特价菜" });
            AllCategoryList.Add(new Category() { Id = 2, Name = "新菜品" });
            AllCategoryList.Add(new Category() { Id = 3, Name = "推荐菜" });
            AllCategoryList.Add(new Category() { Id = 4, Name = "凉菜" });
            AllCategoryList.Add(new Category() { Id = 5, Name = "热菜" });
            AllCategoryList.Add(new Category() { Id = 6, Name = "大菜" });
            AllCategoryList.Add(new Category() { Id = 7, Name = "炒菜" });
            AllCategoryList.Add(new Category() { Id = 8, Name = "蒸菜" });
            AllCategoryList.Add(new Category() { Id = 9, Name = "烧菜" });
            AllCategoryList.Add(new Category() { Id = 10, Name = "炖菜" });
            AllCategoryList.Add(new Category() { Id = 11, Name = "家常菜" });
            AllCategoryList.Add(new Category() { Id = 12, Name = "川菜" });
            AllCategoryList.Add(new Category() { Id = 13, Name = "东北菜" });
            AllCategoryList.Add(new Category() { Id = 14, Name = "广东菜" });
            AllCategoryList.Add(new Category() { Id = 15, Name = "湖南菜" });
            AllCategoryList.Add(new Category() { Id = 16, Name = "甜品" });

            CategoryList = AllCategoryList;
        }

        #region 属性
        private ObservableCollection<Category> _categoryList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<Category> CategoryList
        {
            get { return _categoryList; }
            set { Set(ref _categoryList, value); }
        }

        private string _searchName;
        /// <summary>
        /// 搜索关键字
        /// </summary>
        public string SearchName
        {
            get { return _searchName; }
            set
            {
                Set(ref _searchName, value);
            }
        }
        #endregion


        #region 命令
        /// <summary>
        /// 搜索
        /// </summary>
        public ICommand SearchCommand => new RelayCommand(() =>
        {
            if (!string.IsNullOrEmpty(SearchName))
            {
                var categoryList = AllCategoryList.Where(c => c.Name.Contains(SearchName));
                CategoryList = new ObservableCollection<Category>(categoryList);
            }
            else
            {
                CategoryList = AllCategoryList;
            }
        });

        /// <summary>
        /// 查看详情
        /// </summary>
        public ICommand DetailCommand => new RelayCommand<Category>((e) =>
        {
            if (e is Category category)
            {
                DishCategoryDetailView window = new DishCategoryDetailView();
                window.Show();
            }
        });

        /// <summary>
        /// 新增
        /// </summary>
        public ICommand AddCommand => new RelayCommand(() =>
        {
            DishCategoryEditView window = new DishCategoryEditView();
            window.Show();
        });
        #endregion

    }
}
