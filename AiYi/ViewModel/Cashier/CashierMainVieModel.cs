using AiYi.Service;
using AiYi.View;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class CashierMainVieModel : ViewModelBase
    {
        public CashierMainVieModel()
        {
            ReceivableMoney = Math.Round(136.2, 2);

            PayTypeList = new ObservableCollection<PayType>();
            PayTypeList.Add(new PayType { TypeID = "1", TypeName = "现金", IsChecked = true });
            PayTypeList.Add(new PayType { TypeID = "2", TypeName = "银行卡", IsChecked = false });
            PayTypeList.Add(new PayType { TypeID = "3", TypeName = "储值卡", IsChecked = false });
            PayTypeList.Add(new PayType { TypeID = "4", TypeName = "支付宝", IsChecked = false });
            PayTypeList.Add(new PayType { TypeID = "5", TypeName = "微信支付", IsChecked = false });




        }

        #region 属性
        private double _receivableMoney = 0.0;
        /// <summary>
        /// 应收总额
        /// </summary>
        public double ReceivableMoney
        {
            get { return _receivableMoney; }
            set
            {
                Set(ref _receivableMoney, value);
            }
        }

        private double _actualReceipts;
        /// <summary>
        /// 实际收款
        /// </summary>
        public double ActualReceipts
        {
            get { return _actualReceipts; }
            set
            {
                Set(ref _actualReceipts, value);
            }
        }

        private double _giveChange = Math.Round(0.0, 2);
        /// <summary>
        /// 找零
        /// </summary>
        public double GiveChange
        {
            get { return _giveChange; }
            set
            {
                Set(ref _giveChange, value);
            }
        }


        private ObservableCollection<PayType> _payTypeList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<PayType> PayTypeList
        {
            get { return _payTypeList; }
            set { Set(ref _payTypeList, value); }
        }

        private double _discount = 100;
        /// <summary>
        /// 折扣
        /// </summary>
        public double Discount
        {
            get { return _discount; }
            set
            {
                Set(ref _discount, value);
            }
        }
        #endregion


        #region 命令
        /// <summary>
        /// 实际收款值改变事件
        /// </summary>
        /// </summary>
        public ICommand ActualReceiptsChangedCommand => new RelayCommand<TextBox>((e) =>
        {
            if (e is TextBox textBox)
            {
                string getStr = textBox.Text;
                if (!string.IsNullOrEmpty(getStr))
                {
                    string pattern = @"^[0-9]+.?[0-9]*$";
                    if (Regex.IsMatch(getStr, pattern))
                    {
                        ActualReceipts = Convert.ToDouble(getStr);
                        GiveChange = Math.Round(ActualReceipts - ReceivableMoney, 2); ;
                        if (GiveChange < 0)
                        {
                            GiveChange = Math.Round(0.0, 2);
                        }
                    }
                }
            }
        });

        /// <summary>
        /// 收款
        /// </summary>
        /// </summary>
        public ICommand ReceivablesCommand => new RelayCommand<Window>((e) =>
        {
            if (e is Window window)
            {
                if (window != null)
                {
                    var PayType = PayTypeList.FirstOrDefault(c => c.IsChecked);
                    if (PayType != null)
                    {
                        if (PayType.TypeID == "1" || PayType.TypeID == "2")
                        {
                            TipView tipWindow = new TipView("收款成功");
                            tipWindow.Show();
                            window.Close();
                            SimpleIoc.Default.GetInstance<FrameNavigationService>().NavigateTo("order");
                        }
                        else if (PayType.TypeID == "3")
                        {
                            CashierCardMainView cardMainWindow = new CashierCardMainView();
                            cardMainWindow.Show();
                        }
                        else if (PayType.TypeID == "4" || PayType.TypeID == "5")
                        {
                            CashierQRCodeView qrcodeViewWindow = new CashierQRCodeView();
                            qrcodeViewWindow.Show();
                        }
                    }

                }
            }
        });

        /// <summary>
        /// 设置折扣
        /// </summary>
        /// </summary>
        public ICommand SetDiscountCommand => new RelayCommand<string>((e) =>
        {
            if (e is string str)
            {
                if (!string.IsNullOrEmpty(str))
                {
                    Discount = Convert.ToDouble(str);
                }
            }
        });


        /// <summary>
        /// 优惠券界面
        /// </summary>
        /// </summary>
        public ICommand JumpCouponCommand => new RelayCommand(() =>
        {
            CashierCouponView window = new CashierCouponView();
            window.Show();
        });


        #endregion
    }

    public class PayType
    {
        public string TypeID { get; set; }
        public string TypeName { get; set; }
        public bool IsChecked { get; set; }
    }


}
