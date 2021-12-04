using AiYi.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class RevokeCashierMainViewModel : ViewModelBase
    {
        public RevokeCashierMainViewModel()
        {
            OrderList = new ObservableCollection<Order>();
            for (int i = 0; i < 20; i++)
            {
                OrderList.Add(new Order { ID = i + 1, CreateTime = "12:25", OrderNO = "1506150009", TotalPrice = Math.Round(108.0, 2) });
            }
        }

        #region 属性
        private ObservableCollection<Order> _orderList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<Order> OrderList
        {
            get { return _orderList; }
            set { Set(ref _orderList, value); }
        }

        private Order _selectedOrder;
        /// <summary>
        /// 选中的项
        /// </summary>
        public Order SelectedOrder
        {
            get { return _selectedOrder; }
            set { Set(ref _selectedOrder, value); }
        }
        #endregion

        #region 命令
        /// <summary>
        /// 获取订单详情
        /// </summary>
        public ICommand GetOrderInfoCommand => new RelayCommand(() =>
        {

        });

        /// <summary>
        /// 撤销订单
        /// </summary>
        public ICommand RevokeOrderCommand => new RelayCommand(() =>
        {
            RevokeCashierTipView window = new RevokeCashierTipView();
            window.Show();
        });

        /// <summary>
        /// 搜索
        /// </summary>
        public ICommand SearchCommand => new RelayCommand(() =>
        {

        });
        #endregion

    }

    public class Order
    {
        public int ID { get; set; }
        public string CreateTime { get; set; }

        public string OrderNO { get; set; }
        public double TotalPrice { get; set; }
    }

}
