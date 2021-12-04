using AiYi.Model;
using GalaSoft.MvvmLight;
using System;

namespace AiYi.ViewModel
{
    public class ProductDeleteViewModel : ViewModelBase
    {
        public ProductDeleteViewModel()
        {
            GetProduct = new Product() { Id = 1, Name = "家常拌土鸡", WebPrice = Convert.ToDecimal("45.40"), Premium = "例份", ChooseCount = 1, Images = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571480393250&di=cd5bce378e66ba31033cf1004feec3e6&imgtype=0&src=http%3A%2F%2Fimg8.lamaqun.com%2Fupload%2Ftopic%2Fday_130625%2F201306251302094890.jpg" };

        }


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

    }
}
