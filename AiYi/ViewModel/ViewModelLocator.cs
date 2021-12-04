using AiYi.Service;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Views;

namespace AiYi.ViewModel
{
    /// <summary>
    /// ViewModel绑定器
    /// </summary>
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {

            //   ServiceLocator.SetLocatorProvider(() => ServiceLocatorProvider());


            //if (true)//)!ViewModelBase.IsInDesignModeStatic)
            //{
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<TipViewModel>();
            SimpleIoc.Default.Register<DeskViewModel>();
            SimpleIoc.Default.Register<HaveMealsNumViewModel>();
            SimpleIoc.Default.Register<AddToDeskViewModel>();
            SimpleIoc.Default.Register<OrderMainViewModel>();
            SimpleIoc.Default.Register<ProductDetailViewModel>();
            SimpleIoc.Default.Register<ProductDeleteViewModel>();
            SimpleIoc.Default.Register<CashierMainVieModel>();
            SimpleIoc.Default.Register<CashierCouponViewModel>();
            SimpleIoc.Default.Register<CashierCardSearchViewModel>();
            SimpleIoc.Default.Register<CashierCardDetailViewModel>();
            SimpleIoc.Default.Register<CashierQRCodeViewModel>();
            SimpleIoc.Default.Register<RevokeCashierMainViewModel>();
            SimpleIoc.Default.Register<RevokeCashierTipViewModel>();
            SimpleIoc.Default.Register<ChangeShiftsMainViewModel>();
            SimpleIoc.Default.Register<DishDataViewModel>();
            SimpleIoc.Default.Register<DishDetailViewModel>();
            SimpleIoc.Default.Register<DishDelTipViewModel>();
            SimpleIoc.Default.Register<DishDataEditViewModel>();
            SimpleIoc.Default.Register<DishCategoryViewModel>();
            SimpleIoc.Default.Register<DishCategoryDetailViewModel>();
            SimpleIoc.Default.Register<DishCategoryEditViewModel>();
            SimpleIoc.Default.Register<DishCategoryDelTipViewModel>();
            SimpleIoc.Default.Register<BusinessAnalysisMainViewModel>();
            SimpleIoc.Default.Register<PrintSetViewModel>();
            SimpleIoc.Default.Register<SmallTicketMachineSetViewModel>();
            SimpleIoc.Default.Register<ExtensionSetViewModel>();
            SimpleIoc.Default.Register<AccountManageViewModel>();
            SimpleIoc.Default.Register<AccountLogoutTipViewModel>();
            SimpleIoc.Default.Register<AboutInfoViewModel>();
            SimpleIoc.Default.Register<MemberMainViewModel>();
            SimpleIoc.Default.Register<MemberInfoViewModel>();
            SimpleIoc.Default.Register<MemberCostDetailViewModel>();
            SimpleIoc.Default.Register<TakeOutMainViewModel>();
            SimpleIoc.Default.Register<OrderManageMainViewModel>();
            SimpleIoc.Default.Register<NumKeyboardViewModel>();
            SimpleIoc.Default.Register(() => CreateNavigationService());
            SimpleIoc.Default.Register(() => CreateDeskNavigationService());
            SimpleIoc.Default.Register(() => CreateCashierCardNavigationService());
            //}
        }

        #region 导航
        private INavigationService CreateNavigationService()
        {
            NavigationService navigationService = new NavigationService();
            navigationService.Configure("login", new Uri("/AiYi;component/View/LoginView.xaml", UriKind.Relative));
            navigationService.Configure("main", new Uri("/AiYi;component/View/MainView.xaml", UriKind.Relative));
            return navigationService;
        }

        /// <summary>
        /// 选座界面导航
        /// </summary>
        private FrameNavigationService CreateDeskNavigationService()
        {
            FrameNavigationService navigationService = new FrameNavigationService();
            navigationService.Configure("desk", new Uri("/AiYi;component/View/Desk/DeskView.xaml", UriKind.Relative));
            navigationService.Configure("changProduct", new Uri("/AiYi;component/View/Desk/ChangProductView.xaml", UriKind.Relative));
            navigationService.Configure("order", new Uri("/AiYi;component/View/Order/OrderMainView.xaml", UriKind.Relative));
            return navigationService;
        }

        /// <summary>
        /// 储值卡界面导航
        /// </summary>
        private CashierCardFrameNavigationService CreateCashierCardNavigationService()
        {
            CashierCardFrameNavigationService navigationService = new CashierCardFrameNavigationService();
            navigationService.Configure("search", new Uri("/AiYi;component/View/Cashier/CashierCardSearchView.xaml", UriKind.Relative));
            navigationService.Configure("detail", new Uri("/AiYi;component/View/Cashier/CashierCardDetailView.xaml", UriKind.Relative));
            return navigationService;
        }
        #endregion

        /// <summary>
        /// 主页面
        /// </summary>
        public MainViewModel Main
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainViewModel>();
            }
        }

        /// <summary>
        /// 登录视图模型
        /// </summary>
        public LoginViewModel Login
        {
            get
            {
                return SimpleIoc.Default.GetInstance<LoginViewModel>();
            }
        }

        /// <summary>
        /// 消息视图模型
        /// </summary>
        public TipViewModel Tip
        {
            get
            {
                return SimpleIoc.Default.GetInstance<TipViewModel>();
            }
        }

        #region 选座订餐 - 视图模型
        /// <summary>
        /// 选座视图模型
        /// </summary>
        public DeskViewModel Desk
        {
            get
            {
                return SimpleIoc.Default.GetInstance<DeskViewModel>();
            }
        }

        /// <summary>
        /// 设置用餐人数视图模型
        /// </summary>
        public HaveMealsNumViewModel HaveMealsNum
        {
            get
            {
                return SimpleIoc.Default.GetInstance<HaveMealsNumViewModel>();
            }
        }

        /// <summary>
        /// 设置用餐人数视图模型
        /// </summary>
        public AddToDeskViewModel AddToDesk
        {
            get
            {
                return SimpleIoc.Default.GetInstance<AddToDeskViewModel>();
            }
        }

        /// <summary>
        /// 点餐视图
        /// </summary>
        public OrderMainViewModel OrderMain
        {
            get
            {
                return SimpleIoc.Default.GetInstance<OrderMainViewModel>();
            }
        }

        /// <summary>
        /// 菜品详情视图
        /// </summary>
        public ProductDetailViewModel ProductDetail
        {
            get
            {
                return SimpleIoc.Default.GetInstance<ProductDetailViewModel>();
            }
        }

        /// <summary>
        /// 菜品删除视图
        /// </summary>
        public ProductDeleteViewModel ProductDelete
        {
            get
            {
                return SimpleIoc.Default.GetInstance<ProductDeleteViewModel>();
            }
        }
        #endregion

        #region 收银视图模型
        /// <summary>
        /// 收银主界面视图模型
        /// </summary>
        public CashierMainVieModel CashierMain
        {
            get
            {
                return SimpleIoc.Default.GetInstance<CashierMainVieModel>();
            }
        }

        /// <summary>
        /// 收银优惠券视图模型
        /// </summary>
        public CashierCouponViewModel CashierCoupon
        {
            get
            {
                return SimpleIoc.Default.GetInstance<CashierCouponViewModel>();
            }
        }

        /// <summary>
        /// 储值卡搜索视图模型
        /// </summary>
        public CashierCardSearchViewModel CashierCardSearch
        {
            get
            {
                return SimpleIoc.Default.GetInstance<CashierCardSearchViewModel>();
            }
        }

        /// <summary>
        /// 储值卡详情视图模型
        /// </summary>
        public CashierCardDetailViewModel CashierCardDetail
        {
            get
            {
                return SimpleIoc.Default.GetInstance<CashierCardDetailViewModel>();
            }
        }

        /// <summary>
        /// 二维码视图模型
        /// </summary>
        public CashierQRCodeViewModel CashierQRCode
        {
            get
            {
                return SimpleIoc.Default.GetInstance<CashierQRCodeViewModel>();
            }
        }
        #endregion

        #region 撤销收银视图模型
        /// <summary>
        /// 撤销收银主界面视图模型
        /// </summary>
        public RevokeCashierMainViewModel RevokeCashierMain
        {
            get
            {
                return SimpleIoc.Default.GetInstance<RevokeCashierMainViewModel>();
            }
        }

        /// <summary>
        /// 撤销收银提示视图模型
        /// </summary>
        public RevokeCashierTipViewModel RevokeCashierTip
        {
            get
            {
                return SimpleIoc.Default.GetInstance<RevokeCashierTipViewModel>();
            }
        }
        #endregion

        #region 交接班视图模型
        /// <summary>
        /// 交接班主界面视图模型
        /// </summary>
        public ChangeShiftsMainViewModel ChangeShiftsMain
        {
            get
            {
                return SimpleIoc.Default.GetInstance<ChangeShiftsMainViewModel>();
            }
        }
        #endregion

        #region 菜品资料维护视图模型
        /// <summary>
        /// 菜品资料视图模型
        /// </summary>
        public DishDataViewModel DishData
        {
            get
            {
                return SimpleIoc.Default.GetInstance<DishDataViewModel>();
            }
        }
        /// <summary>
        /// 菜品资料详情视图模型
        /// </summary>
        public DishDetailViewModel DishDetail
        {
            get
            {
                return SimpleIoc.Default.GetInstance<DishDetailViewModel>();
            }
        }

        /// <summary>
        /// 菜品资料删除提示视图模型
        /// </summary>
        public DishDelTipViewModel DishDelTip
        {
            get
            {
                return SimpleIoc.Default.GetInstance<DishDelTipViewModel>();
            }
        }

        /// <summary>
        /// 菜品资料编辑视图模型
        /// </summary>
        public DishDataEditViewModel DishDataEdit
        {
            get
            {
                return SimpleIoc.Default.GetInstance<DishDataEditViewModel>();
            }
        }

        /// <summary>
        /// 菜品类别视图模型
        /// </summary>
        public DishCategoryViewModel DishCategory
        {
            get
            {
                return SimpleIoc.Default.GetInstance<DishCategoryViewModel>();
            }
        }

        /// <summary>
        /// 菜品类别详情视图模型
        /// </summary>
        public DishCategoryDetailViewModel DishCategoryDetail
        {
            get
            {
                return SimpleIoc.Default.GetInstance<DishCategoryDetailViewModel>();
            }
        }

        /// <summary>
        /// 菜品类别编辑视图模型
        /// </summary>
        public DishCategoryEditViewModel DishCategoryEdit
        {
            get
            {
                return SimpleIoc.Default.GetInstance<DishCategoryEditViewModel>();
            }
        }

        /// <summary>
        /// 菜品类别删除视图模型
        /// </summary>
        public DishCategoryDelTipViewModel DishCategoryDelTip
        {
            get
            {
                return SimpleIoc.Default.GetInstance<DishCategoryDelTipViewModel>();
            }
        }
        #endregion

        #region 营业分析视图模型
        /// <summary>
        /// 营业分析视图模型
        /// </summary>
        public BusinessAnalysisMainViewModel BusinessAnalysisMain
        {
            get
            {
                return SimpleIoc.Default.GetInstance<BusinessAnalysisMainViewModel>();
            }
        }
        #endregion

        #region 基础信息设置视图模型
        /// <summary>
        /// 厨房打印设置视图模型
        /// </summary>
        public PrintSetViewModel PrintSet
        {
            get
            {
                return SimpleIoc.Default.GetInstance<PrintSetViewModel>();
            }
        }

        /// <summary>
        /// 小票机设置视图模型
        /// </summary>
        public SmallTicketMachineSetViewModel SmallTicketMachineSet
        {
            get
            {
                return SimpleIoc.Default.GetInstance<SmallTicketMachineSetViewModel>();
            }
        }

        /// <summary>
        /// 总机分机设置视图模型
        /// </summary>
        public ExtensionSetViewModel ExtensionSet
        {
            get
            {
                return SimpleIoc.Default.GetInstance<ExtensionSetViewModel>();
            }
        }

        /// <summary>
        /// 账号管理视图模型
        /// </summary>
        public AccountManageViewModel AccountManage
        {
            get
            {
                return SimpleIoc.Default.GetInstance<AccountManageViewModel>();
            }
        }

        /// <summary>
        /// 账号注销提示视图模型
        /// </summary>
        public AccountLogoutTipViewModel AccountLogoutTip
        {
            get
            {
                return SimpleIoc.Default.GetInstance<AccountLogoutTipViewModel>();
            }
        }

        /// <summary>
        /// 关于视图模型
        /// </summary>
        public AboutInfoViewModel AboutInfo
        {
            get
            {
                return SimpleIoc.Default.GetInstance<AboutInfoViewModel>();
            }
        }
        #endregion

        #region 会员管理视图模型
        /// <summary>
        /// 会员管理主界面视图模型
        /// </summary>
        public MemberMainViewModel MemberMain
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MemberMainViewModel>();
            }
        }

        /// <summary>
        /// 会员详情视图模型
        /// </summary>
        public MemberInfoViewModel MemberInfo
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MemberInfoViewModel>();
            }
        }

        /// <summary>
        /// 会员消费明细视图模型
        /// </summary>
        public MemberCostDetailViewModel MemberCostDetail
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MemberCostDetailViewModel>();
            }
        }
        #endregion

        #region 外卖管理视图模型
        /// <summary>
        /// 外卖管理主界面视图模型
        /// </summary>
        public TakeOutMainViewModel TakeOutMain
        {
            get
            {
                return SimpleIoc.Default.GetInstance<TakeOutMainViewModel>();
            }
        }
        #endregion

        #region 订单管理视图模型
        /// <summary>
        /// 订单管理主界面视图模型
        /// </summary>
        public OrderManageMainViewModel OrderManageMain
        {
            get
            {
                return SimpleIoc.Default.GetInstance<OrderManageMainViewModel>();
            }
        }

        /// <summary>
        /// 数字键盘界面视图模型
        /// </summary>
        public NumKeyboardViewModel NumKeyboard
        {
            get
            {
                return SimpleIoc.Default.GetInstance<NumKeyboardViewModel>();
            }
        }
        #endregion

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}