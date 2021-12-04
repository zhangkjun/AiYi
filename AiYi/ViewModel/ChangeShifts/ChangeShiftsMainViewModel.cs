using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class ChangeShiftsMainViewModel : ViewModelBase
    {
        public ChangeShiftsMainViewModel()
        {
            JBSJ = DateTime.Now.ToString("yyyy年MM月dd日");
            CZY = "宇宙人";
            YYSR = "299999.99";
            KPSR = "3333.99";
            XJSK = "2888.88";
            CZKSK = "44444.55";
            YLKSK = "3333.33";
        }

        #region 属性
        private string _jbsj;
        /// <summary>
        /// 交班时间
        /// </summary>
        public string JBSJ
        {
            get { return _jbsj; }
            set { Set(ref _jbsj, value); }
        }

        private string _czy;
        /// <summary>
        /// 操作员
        /// </summary>
        public string CZY
        {
            get { return _czy; }
            set { Set(ref _czy, value); }
        }

        private string _yysr;
        /// <summary>
        /// 营业收入
        /// </summary>
        public string YYSR
        {
            get { return _yysr; }
            set { Set(ref _yysr, value); }
        }

        private string _kpsr;
        /// <summary>
        /// 卡片收入
        /// </summary>
        public string KPSR
        {
            get { return _kpsr; }
            set { Set(ref _kpsr, value); }
        }

        private string _xjsk;
        /// <summary>
        /// 现金收款
        /// </summary>
        public string XJSK
        {
            get { return _xjsk; }
            set { Set(ref _xjsk, value); }
        }

        private string _czksk;
        /// <summary>
        /// 储值卡收款
        /// </summary>
        public string CZKSK
        {
            get { return _czksk; }
            set { Set(ref _czksk, value); }
        }

        private string _ylksk;
        /// <summary>
        /// 银联卡收款
        /// </summary>
        public string YLKSK
        {
            get { return _ylksk; }
            set { Set(ref _ylksk, value); }
        }
        #endregion


        #region 命令
        /// <summary>
        /// 退出登录
        /// </summary>
        public ICommand QuitCommand => new RelayCommand(() =>
        {
            SimpleIoc.Default.GetInstance<INavigationService>().NavigateTo("login");
        });
        #endregion

    }
}
