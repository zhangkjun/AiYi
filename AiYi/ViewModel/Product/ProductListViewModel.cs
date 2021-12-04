using AiYi.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class ProductListViewModel : ViewModelBase
    {
        public ProductListViewModel()
        {
            OrderProductList = new ObservableCollection<OrderProduct>();
            for (int i = 0; i < 4; i++)
            {
                OrderProductList.Add(new OrderProduct() { Id = 1, Name = "火爆腰花", Remark = "赠送", Amount = 1, Price = "45.4" });
                OrderProductList.Add(new OrderProduct() { Id = 2, Name = "宫保鸡丁", Remark = "", Amount = 1, Price = "32.4" });
                OrderProductList.Add(new OrderProduct() { Id = 3, Name = "干煸鳝鱼", Remark = "", Amount = 3, Price = "53.5" });
            }

            if (OrderProductList != null && OrderProductList.Count > 0)
            {
                ProductListVisbie = Visibility.Visible;
            }
            else
            {
                ProductListVisbie = Visibility.Collapsed;
            }


            Census();
        }


        #region 属性
        private ObservableCollection<OrderProduct> _orderProductList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<OrderProduct> OrderProductList
        {
            get { return _orderProductList; }
            set { Set(ref _orderProductList, value); }
        }

        private int _totalAmount;
        /// <summary
        /// 菜总份数
        /// </summary>
        public int TotalAmount
        {
            get { return _totalAmount; }
            set { Set(ref _totalAmount, value); }
        }

        private string _totalPrice;
        /// <summary
        /// 总价格
        /// </summary>
        public string TotalPrice
        {
            get { return _totalPrice; }
            set { Set(ref _totalPrice, value); }
        }

        private Visibility _productListVisbie;
        /// <summary>
        /// 列表隐藏显示
        /// </summary>
        public Visibility ProductListVisbie
        {
            get { return _productListVisbie; }
            set { Set(ref _productListVisbie, value); }
        }

        #endregion


        #region 命令


        /// <summary>
        /// 选中事件
        /// </summary>
        public ICommand SelectedCommand => new RelayCommand<OrderProduct>((e) =>
        {
            if (e is OrderProduct orderProduct)
            {
                ProductDetailView window = new ProductDetailView();
                window.Show();
            }
        });
        #endregion


        #region 方法
        public void Census()
        {
            int allAmount = 0;
            decimal allPrice = 0;
            foreach (var item in OrderProductList)
            {
                allAmount += item.Amount;
                allPrice += Convert.ToDecimal(item.Price);
            }
            TotalAmount = allAmount;
            TotalPrice = allPrice.ToString();
        }
        #endregion

    }

    public class OrderProduct : ViewModelBase
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { Set(ref _id, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }

        private string _remark;
        public string Remark
        {
            get { return _remark; }
            set { Set(ref _remark, value); }
        }

        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { Set(ref _amount, value); }
        }

        private string _price;
        public string Price
        {
            get { return _price; }
            set { Set(ref _price, value); }
        }


    }

}
