using AiYi.Model;
using AiYi.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class OrderMainViewModel : ViewModelBase
    {
        ObservableCollection<Product> AllProductList;
        public OrderMainViewModel()
        {
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




            AllProductList = new ObservableCollection<Product>();
            int num = 1;
            for (int i = 0; i < 16; i++)
            {
                AllProductList.Add(new Product() { Id = num, Name = "火爆腰花" + (i + 1), WebPrice = Convert.ToDecimal("45.40"), Premium = "例份", CategoryId = (i + 1), ChooseCount = 0, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571480364770&di=b63fbcf7c97589d3bbea4f2f7f0c30d5&imgtype=0&src=http%3A%2F%2Fwww.cookcai.com%2FA_User%2FProduct_image%2F20150613102347260.JPG" });
                num++;
                AllProductList.Add(new Product() { Id = num, Name = "家常拌土鸡" + (i + 1), WebPrice = Convert.ToDecimal("45.40"), Premium = "例份", CategoryId = (i + 1), ChooseCount = 1, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571480393250&di=cd5bce378e66ba31033cf1004feec3e6&imgtype=0&src=http%3A%2F%2Fimg8.lamaqun.com%2Fupload%2Ftopic%2Fday_130625%2F201306251302094890.jpg" });
                num++;
                AllProductList.Add(new Product() { Id = num, Name = "青椒皮蛋" + (i + 1), WebPrice = Convert.ToDecimal("45.40"), Premium = "例份", CategoryId = (i + 1), ChooseCount = 3, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571480417069&di=37ac947b2305711e9a63b20dc97925c0&imgtype=0&src=http%3A%2F%2Fpic.pingguolv.com%2Fuploads%2Fallimg%2F180411%2F148-1P411000003.jpg" });
                num++;
                AllProductList.Add(new Product() { Id = num, Name = "红烧肉" + (i + 1), WebPrice = Convert.ToDecimal("45.40"), Premium = "例份", CategoryId = (i + 1), ChooseCount = 0, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571480440313&di=4b751e8b2c8f7492cbc27debb67a5265&imgtype=0&src=http%3A%2F%2Fimages.91160.com%2Fnews%2Fother%2F201510%2F2015102811411684249.jpg" });
                num++;
                AllProductList.Add(new Product() { Id = num, Name = "干煸肥肠" + (i + 1), WebPrice = Convert.ToDecimal("45.40"), Premium = "例份", CategoryId = (i + 1), ChooseCount = 5, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571480479128&di=6168b64ceecbfb4c5cf178ccb10ab81e&imgtype=0&src=http%3A%2F%2Fwww.tmianyang.com%2FStorePicture%2F201509171151073373.jpg" });
                num++;
            }

            SelectedCategory = CategoryList[0];

        }


        #region 属性
        private ObservableCollection<Product> _productList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<Product> ProductList
        {
            get { return _productList; }
            set { Set(ref _productList, value); }
        }


        private ObservableCollection<Category> _categoryList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<Category> CategoryList
        {
            get { return _categoryList; }
            set { Set(ref _categoryList, value); }
        }

        private Category _selectedCategory;
        /// <summary>
        /// 选中的菜品类别
        /// </summary>
        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                Set(ref _selectedCategory, value);
                var productList = AllProductList.Where(c => c.CategoryId == SelectedCategory.Id);
                ProductList = new ObservableCollection<Product>(productList);
            }
        }

        private bool _imageMode = false;
        /// <summary>
        /// 图片模式是否开启
        /// </summary>
        public bool ImageMode
        {
            get { return _imageMode; }
            set { Set(ref _imageMode, value); }
        }


        private Visibility _searchVisbie = Visibility.Collapsed;
        /// <summary>
        /// 搜索页面隐藏显示
        /// </summary>
        public Visibility SearchVisbie
        {
            get { return _searchVisbie; }
            set { Set(ref _searchVisbie, value); }
        }


        private ObservableCollection<Product> _searchProductList;
        /// <summary>
        /// 搜索列表
        /// </summary>
        public ObservableCollection<Product> SearchProductList
        {
            get { return _searchProductList; }
            set { Set(ref _searchProductList, value); }
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

        private Visibility _remarkVisbie = Visibility.Collapsed;
        /// <summary>
        /// 备注页面隐藏显示
        /// </summary>
        public Visibility RemarkVisbie
        {
            get { return _remarkVisbie; }
            set { Set(ref _remarkVisbie, value); }
        }

        #endregion

        #region 命令
        /// <summary>
        /// 菜品选择
        /// </summary>
        public ICommand ProductCommand => new RelayCommand<Product>((e) =>
        {
            if (e is Product product)
            {
                product.ChooseCount++;
            }
        });



        /// <summary>
        /// 类别选择
        /// </summary>
        public ICommand CategoryCommand => new RelayCommand<Category>((e) =>
        {
            if (e is Category category)
            {
                SelectedCategory = category;
                var productList = ProductList.Where(c => c.CategoryId == SelectedCategory.Id);

                ProductList = new ObservableCollection<Product>(productList);
            }
        });


        /// <summary>
        /// 切换界面
        /// </summary>
        public ICommand JumpCommand => new RelayCommand<string>((e) =>
        {
            if (e is string str)
            {
                if (str == "search")
                {
                    SearchVisbie = Visibility.Visible;

                    if (SearchProductList == null)
                    {
                        SearchProductList = new ObservableCollection<Product>();
                    }

                    SearchName = "";

                    SearchProductList.Add(new Product() { Id = 1, Name = "宫保鸡丁", WebPrice = Convert.ToDecimal("32.90"), Premium = "例份", ChooseCount = 5, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571488367033&di=40dd352654d24c754f9c4db40fc33ffa&imgtype=0&src=http%3A%2F%2F5b0988e595225.cdn.sohucs.com%2Fimages%2F20170627%2Fa5adf4ed0066495588254b00af4cbec7.png" });
                    SearchProductList.Add(new Product() { Id = 2, Name = "水煮鱼", WebPrice = Convert.ToDecimal("68.90"), Premium = "例份", ChooseCount = 1, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571488388783&di=be5750b196eba824a47473914a74bdd6&imgtype=0&src=http%3A%2F%2Fmmb-toutiao.oss-cn-shanghai.aliyuncs.com%2FtoutiaoImage%2F46ae351be31b5751c79b7bae97eb5461.jpeg" });

                    SearchProductList.Add(new Product() { Id = 3, Name = "三杯鸡", WebPrice = Convert.ToDecimal("32.90"), Premium = "例份", ChooseCount = 0, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571488440253&di=dd624444be8a939b50dc5ee3215a44c9&imgtype=0&src=http%3A%2F%2Fstatic.i3.xywy.com%2Fcms%2F20150223%2Ff64df59a29f090e7851414649eac3fa575266.jpg" });
                    SearchProductList.Add(new Product() { Id = 4, Name = "牛肉面", WebPrice = Convert.ToDecimal("32.90"), Premium = "例份", ChooseCount = 0, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571488462786&di=95032737d7a2726c0f55ab11919126df&imgtype=0&src=http%3A%2F%2Fwww.shang360.com%2Fupload%2Farticle%2F20170921%2F61527424561505970415.jpg" });
                    SearchProductList.Add(new Product() { Id = 5, Name = "番茄炒蛋", WebPrice = Convert.ToDecimal("32.90"), Premium = "例份", ChooseCount = 0, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571488478309&di=286bbc4d12246e2a30577b5c1559baee&imgtype=0&src=http%3A%2F%2Ffile.vivijk.com%2Fuploadfile%2F2016%2F1125%2F20161125020033214.jpg" });

                    SearchProductList.Add(new Product() { Id = 6, Name = "家常豆腐", WebPrice = Convert.ToDecimal("32.90"), Premium = "例份", ChooseCount = 0, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571488499191&di=6ed7da9188e3698f6c14401c10ca5733&imgtype=0&src=http%3A%2F%2Fcp1.douguo.com%2Fupload%2Fcaiku%2Fb%2Fd%2Fa%2Fyuan_bd77a6d1cbc89b16f45efc8230eb188a.jpeg" });

                    SearchProductList.Add(new Product() { Id = 7, Name = "蒜香排骨", WebPrice = Convert.ToDecimal("32.90"), Premium = "例份", ChooseCount = 0, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571488526290&di=760346ae2b933adad73f5ff0558a8eb3&imgtype=0&src=http%3A%2F%2Fdingyue.nosdn.127.net%2FAv235mxt2Oz34WG4jg5rSazwGI7iteIBqS8dap18pK4pt1539053477547compressflag.jpg" });
                    SearchProductList.Add(new Product() { Id = 8, Name = "油焖大虾", WebPrice = Convert.ToDecimal("32.90"), Premium = "例份", ChooseCount = 0, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571488553283&di=a6ef37cb750757f88a56500ea988916a&imgtype=0&src=http%3A%2F%2Fi2.chuimg.com%2F71678a1a4d1043b9a238504dc5148fe7_1280w_1013h.jpg%3FimageView2%2F2%2Fw%2F600%2Finterlace%2F1%2Fq%2F90" });
                    SearchProductList.Add(new Product() { Id = 9, Name = "咖喱鸡", WebPrice = Convert.ToDecimal("32.90"), Premium = "例份", ChooseCount = 0, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571488572907&di=522c4d4d60d75d4ef6a0761324345bd0&imgtype=0&src=http%3A%2F%2Fcp1.douguo.com%2Fupload%2Fcaiku%2Fe%2Fb%2Fb%2Fyuan_eb9c15fe075276815b21235a652387fb.jpeg" });
                    SearchProductList.Add(new Product() { Id = 10, Name = "可乐鸡翅", WebPrice = Convert.ToDecimal("32.90"), Premium = "例份", ChooseCount = 0, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571488589699&di=1dd29bc63f96e99953b8c768c79430e3&imgtype=0&src=http%3A%2F%2Fmmb-toutiao.oss-cn-shanghai.aliyuncs.com%2FtoutiaoImage%2Fd8b20fa56f1f983295b9cedc32aea2ce.jpeg" });

                }
                else if (str == "remark")
                {
                    RemarkVisbie = Visibility.Visible;
                }
            }

        });




        /// <summary>
        /// 关闭界面
        /// </summary>
        public ICommand CloseCommand => new RelayCommand<string>((e) =>
        {
            if (e is string str)
            {
                if (str == "search")
                {
                    SearchVisbie = Visibility.Collapsed;
                }
                else if (str == "remark")
                {
                    RemarkVisbie = Visibility.Collapsed;
                }
            }
        });


        /// <summary>
        /// 搜索
        /// </summary>
        public ICommand SearchCommand => new RelayCommand(() =>
        {
            if (!string.IsNullOrEmpty(SearchName))
            {
                var productList = AllProductList.Where(c => c.Name.Contains(SearchName));
                SearchProductList = new ObservableCollection<Product>(productList);
            }
        });


        /// <summary>
        /// 进入收银
        /// </summary>
        public ICommand JumpCashierCommand => new RelayCommand(() =>
        {
            RemarkVisbie = Visibility.Collapsed;
            CashierMainView window = new CashierMainView();
            window.Show();
        });


        #endregion

    }
}
