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
    public class TakeOutMainViewModel : ViewModelBase
    {
        ObservableCollection<TakeOutOrder> AllOrderList;
        public TakeOutMainViewModel()
        {
            OrderVisibility = Visibility.Collapsed;
            AllOrderList = new ObservableCollection<TakeOutOrder>();

            for (int i = 0; i < 20; i++)
            {
                AllOrderList.Add(new TakeOutOrder { OrderNO = "201911031407", LXR = "张三", LXDH = "12345678925", XFJE = "126.00", XFJEZT = "已付款", XDSJ = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), SHDZ = "广东省珠海市香洲区吉大炼金大厦", SCY = "小陈", SCYDH = "65879632145" });
            }
            TakeOutOrderList = AllOrderList;

            OrderProductList = new ObservableCollection<OrderProduct>();
            for (int i = 0; i < 4; i++)
            {
                OrderProductList.Add(new OrderProduct() { Id = 1, Name = "火爆腰花", Remark = "赠送", Amount = 1, Price = "45.4" });
                OrderProductList.Add(new OrderProduct() { Id = 2, Name = "宫保鸡丁", Remark = "", Amount = 1, Price = "32.4" });
                OrderProductList.Add(new OrderProduct() { Id = 3, Name = "干煸鳝鱼", Remark = "", Amount = 3, Price = "53.5" });
            }

        }

        #region 属性
        private ObservableCollection<TakeOutOrder> _takeOutOrderList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<TakeOutOrder> TakeOutOrderList
        {
            get { return _takeOutOrderList; }
            set { Set(ref _takeOutOrderList, value); }
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

        private TakeOutOrder _selectedTakeOutOrder;
        /// <summary>
        /// 选中的订单
        /// </summary>
        public TakeOutOrder SelectedTakeOutOrder
        {
            get { return _selectedTakeOutOrder; }
            set
            {
                Set(ref _selectedTakeOutOrder, value);

                OrderVisibility = Visibility.Visible;

            }
        }

        private Visibility _orderVisibility;
        /// <summary>
        /// 订单隐藏显示
        /// </summary>
        public Visibility OrderVisibility
        {
            get { return _orderVisibility; }
            set
            {
                Set(ref _orderVisibility, value);

            }
        }

        private ObservableCollection<OrderProduct> _orderProductList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<OrderProduct> OrderProductList
        {
            get { return _orderProductList; }
            set { Set(ref _orderProductList, value); }
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
                var orderList = AllOrderList.Where(c => c.LXDH.Contains(SearchName));
                TakeOutOrderList = new ObservableCollection<TakeOutOrder>(orderList);
            }
            else
            {
                TakeOutOrderList = AllOrderList;
            }
        });

        /// <summary>
        /// 确定送达
        /// </summary>
        public ICommand ConfirmCommand => new RelayCommand(() =>
        {
            TipView window = new TipView("送达成功");
            window.Show();
        });

        /// <summary>
        /// 取消交易
        /// </summary>
        public ICommand CancelCommand => new RelayCommand(() =>
        {
            SelectedTakeOutOrder = null;
            TipView window = new TipView("订单取消成功");
            window.Show();
        });

        /// <summary>
        /// 关闭订单
        /// </summary>
        public ICommand CloseCommand => new RelayCommand(() =>
        {
            SelectedTakeOutOrder = null;
            OrderVisibility = Visibility.Collapsed;
        });
        #endregion


    }


    public class TakeOutOrder
    {
        public string OrderNO { get; set; }
        public string LXR { get; set; }
        public string LXDH { get; set; }
        public string XFJE { get; set; }
        public string XFJEZT { get; set; }
        public string XDSJ { get; set; }
        public string SHDZ { get; set; }
        public string SCY { get; set; }
        public string SCYDH { get; set; }
    }



}
