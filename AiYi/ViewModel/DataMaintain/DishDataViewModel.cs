using AiYi.Model;
using AiYi.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class DishDataViewModel : ViewModelBase
    {
        ObservableCollection<Product> AllProductList;
        public DishDataViewModel()
        {
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

            ProductList = AllProductList;

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

        private bool _imageMode = false;
        /// <summary>
        /// 图片模式是否开启
        /// </summary>
        public bool ImageMode
        {
            get { return _imageMode; }
            set { Set(ref _imageMode, value); }
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
                var productList = AllProductList.Where(c => c.Name.Contains(SearchName));
                ProductList = new ObservableCollection<Product>(productList);
            }
            else
            {
                ProductList = AllProductList;
            }
        });

        /// <summary>
        /// 查看详情
        /// </summary>
        public ICommand DetailCommand => new RelayCommand<Product>((e) =>
        {
            if (e is Product product)
            {
                DishDetailView window = new DishDetailView();
                window.Show();
            }
        });

        /// <summary>
        /// 新增
        /// </summary>
        public ICommand AddCommand => new RelayCommand(() =>
        {
            DishDataEditView window = new DishDataEditView();
            window.Show();
        });
        #endregion


    }
}
