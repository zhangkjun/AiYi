using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiYi.ViewModel
{
    public class OrderManageMainViewModel: ViewModelBase
    {
        public OrderManageMainViewModel()
        {
            OrderManageList = new ObservableCollection<OrderManage>();
            for (int i = 0; i < 30; i++)
            {
                OrderManageList.Add(new OrderManage() { DeskNO = i.ToString(), Date = DateTime.Now.ToString(), FWY = "张三" + i, OrderNO = DateTime.Now.ToString("yyyyMMddHHmmss") }); ;
            }

            OrderProductList = new ObservableCollection<OrderProduct>();
            for (int i = 0; i < 20; i++)
            {
                OrderProductList.Add(new OrderProduct() { Name="猪肉丸螺蛳粉"+i, Price ="38.00",Amount=1,Remark=""});
            }


        }

        #region 属性
        private ObservableCollection<OrderManage> _orderManageList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<OrderManage> OrderManageList
        {
            get { return _orderManageList; }
            set { Set(ref _orderManageList, value); }
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

    }

    public class OrderManage
    {
        public string DeskNO { get; set; }
        public string Date { get; set; }
        public string FWY { get; set; }
        public string OrderNO { get; set; }
    }




}
