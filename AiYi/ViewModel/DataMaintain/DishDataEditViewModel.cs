using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class DishDataEditViewModel : ViewModelBase
    {
        public DishDataEditViewModel()
        {
            EditProduct = new Product() { Name = "青椒玉米", Number = "A6", WebPrice = 18, HYJ = 17, TJ = 15, Premium = "份", CategoryId = 1, Spec = "", SPBZ = true, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1572169939377&di=0327e3f556e9e0dd375cde6ab1a25adf&imgtype=0&src=http%3A%2F%2Fimgqn.koudaitong.com%2Fupload_files%2F2014%2F10%2F11%2FFrNWCrNSo6QtAkSzMCzHhSXcFlaD.jpg%2521730x0.jpg" };

            PremiumList = new ObservableCollection<string>();
            PremiumList.Add("份");
            PremiumList.Add("盘");
            PremiumList.Add("个");


            CategoryList = new ObservableCollection<Category>();
            CategoryList.Add(new Category() { Id = 1, Name = "特价菜" });
            CategoryList.Add(new Category() { Id = 2, Name = "新菜品" });
            CategoryList.Add(new Category() { Id = 3, Name = "推荐菜" });
            CategoryList.Add(new Category() { Id = 4, Name = "凉菜" });
            CategoryList.Add(new Category() { Id = 5, Name = "热菜" });
            CategoryList.Add(new Category() { Id = 6, Name = "大菜" });
            CategoryList.Add(new Category() { Id = 7, Name = "炒菜" });
            CategoryList.Add(new Category() { Id = 8, Name = "蒸菜" });
            CategoryList.Add(new Category() { Id = 9, Name = "烧菜" });
            CategoryList.Add(new Category() { Id = 10, Name = "炖菜" });
            CategoryList.Add(new Category() { Id = 11, Name = "家常菜" });
            CategoryList.Add(new Category() { Id = 12, Name = "川菜" });
            CategoryList.Add(new Category() { Id = 13, Name = "东北菜" });
            CategoryList.Add(new Category() { Id = 14, Name = "广东菜" });
            CategoryList.Add(new Category() { Id = 15, Name = "湖南菜" });
            CategoryList.Add(new Category() { Id = 16, Name = "甜品" });


        }

        #region 属性
        private Product _editProduct;
        /// <summary>
        /// 获得的菜品
        /// </summary>
        public Product EditProduct
        {
            get { return _editProduct; }
            set
            {
                Set(ref _editProduct, value);
            }
        }

        private ObservableCollection<string> _premiumList;
        /// <summary>
        /// 单位列表
        /// </summary>
        public ObservableCollection<string> PremiumList
        {
            get { return _premiumList; }
            set { Set(ref _premiumList, value); }
        }

        private ObservableCollection<Category> _categoryList;
        /// <summary>
        /// 分类列表
        /// </summary>
        public ObservableCollection<Category> CategoryList
        {
            get { return _categoryList; }
            set { Set(ref _categoryList, value); }
        }

        #endregion

        #region 命令


        /// <summary>
        /// 设置单位
        /// </summary>
        /// </summary>
        public ICommand SetPremiumCommand => new RelayCommand<string>((e) =>
        {
            if (e is string str)
            {
                if (!string.IsNullOrEmpty(str))
                {
                    //Premium = str;
                }
            }
        });

        #endregion

    }
}
