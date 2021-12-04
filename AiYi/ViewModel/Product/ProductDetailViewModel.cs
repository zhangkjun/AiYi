using AiYi.Model;
using AiYi.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class ProductDetailViewModel : ViewModelBase
    {
        public ProductDetailViewModel()
        {
            YDAmount = 5;
            ZSAmount = 0;

            GetProduct = new Product() { Id = 1, Name = "家常拌土鸡", WebPrice = Convert.ToDecimal("45.40"), Premium = "例份", ChooseCount = 1, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571480393250&di=cd5bce378e66ba31033cf1004feec3e6&imgtype=0&src=http%3A%2F%2Fimg8.lamaqun.com%2Fupload%2Ftopic%2Fday_130625%2F201306251302094890.jpg" };
        }


        #region 属性
        private Product _getProduct;
        /// <summary>
        /// 获得的菜品
        /// </summary>
        public Product GetProduct
        {
            get { return _getProduct; }
            set
            {
                Set(ref _getProduct, value);
            }
        }

        private int _ydAmount;
        /// <summary
        /// 已点数量
        /// </summary>
        public int YDAmount
        {
            get { return _ydAmount; }
            set { Set(ref _ydAmount, value); }
        }

        private int _zsAmount;
        /// <summary
        /// 赠送数量
        /// </summary>
        public int ZSAmount
        {
            get { return _zsAmount; }
            set { Set(ref _zsAmount, value); }
        }
        #endregion

        #region 命令
        /// <summary>
        /// 已点数量操作
        /// </summary>
        public ICommand SetYDAmountCommand => new RelayCommand<string>((e) =>
        {
            if (e is string str)
            {
                if (str == "zj")
                {
                    YDAmount++;
                }
                else if (str == "js")
                {
                    if (YDAmount > 0)
                    {
                        if (YDAmount == 1)
                        {
                            ProductDeleteView window = new ProductDeleteView();
                            window.Show();
                        }
                        else
                        {
                            YDAmount--;
                        }
                    }
                }
            }
        });

        /// <summary>
        /// 赠送数量操作
        /// </summary>
        public ICommand SetZSAmountCommand => new RelayCommand<string>((e) =>
        {
            if (e is string str)
            {
                if (str == "zj")
                {
                    ZSAmount++;
                }
                else if (str == "js")
                {
                    if (ZSAmount > 0)
                    {
                        ZSAmount--;
                    }
                }
            }
        });
        #endregion

    }
}
