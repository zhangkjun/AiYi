using AiYi.Service;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class ChangProductViewModel : ViewModelBase
    {
        public ChangProductViewModel()
        {
            OrderProductList = new ObservableCollection<OrderProduct>();
            for (int i = 0; i < 4; i++)
            {
                OrderProductList.Add(new OrderProduct() { Name = "火爆腰花", Remark = "赠送", Amount = 1, Price = "45.4" });
                OrderProductList.Add(new OrderProduct() { Name = "宫保鸡丁", Remark = "", Amount = 1, Price = "32.4" });
                OrderProductList.Add(new OrderProduct() { Name = "干煸鳝鱼", Remark = "", Amount = 3, Price = "53.5" });
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

        #region 命令
        /// <summary>
        /// 命令Command
        /// </summary>
        public ICommand BackCommand => new RelayCommand(() =>
        {
            SimpleIoc.Default.GetInstance<FrameNavigationService>().NavigateTo("desk");
        });

        #endregion


    }



}
