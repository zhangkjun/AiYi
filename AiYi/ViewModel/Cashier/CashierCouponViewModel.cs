using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class CashierCouponViewModel : ViewModelBase
    {
        public CashierCouponViewModel()
        {
        }


        #region 属性
        private string _couponCode;
        /// <summary>
        /// 优惠券号码
        /// </summary>
        public string CouponCode
        {
            get { return _couponCode; }
            set
            {
                Set(ref _couponCode, value);
            }
        }

        private string _couponName;
        /// <summary>
        /// 优惠券名称
        /// </summary>
        public string CouponName
        {
            get { return _couponName; }
            set
            {
                Set(ref _couponName, value);
            }
        }

        private string _couponCompany;
        /// <summary>
        /// 发券单位
        /// </summary>
        public string CouponCompany
        {
            get { return _couponCompany; }
            set
            {
                Set(ref _couponCompany, value);
            }
        }

        private string _effectiveDate;
        /// <summary>
        /// 有效日期
        /// </summary>
        public string EffectiveDate
        {
            get { return _effectiveDate; }
            set
            {
                Set(ref _effectiveDate, value);
            }
        }

        private string _usageRule;
        /// <summary>
        /// 使用规则
        /// </summary>
        public string UsageRule
        {
            get { return _usageRule; }
            set
            {
                Set(ref _usageRule, value);
            }
        }

        private string _msg;
        /// <summary>
        /// 提示消息
        /// </summary>
        public string Msg
        {
            get { return _msg; }
            set { Set(ref _msg, value); }
        }
        #endregion


        #region 命令
        /// <summary>
        /// 验证优惠券
        /// </summary>
        public ICommand CheckCouponCommand => new RelayCommand(() =>
        {
            Msg = "";
            if (!string.IsNullOrEmpty(CouponCode))
            {
                CouponName = "XXXXXXXX";
                CouponCompany = "单位YYYYYYYY";
                EffectiveDate = "2020年10月";
                UsageRule = "使用规则XXXXXXX";
            }
            else
            {
                Msg = "优惠券号码不能为空";
            }
        });
        #endregion

    }
}
