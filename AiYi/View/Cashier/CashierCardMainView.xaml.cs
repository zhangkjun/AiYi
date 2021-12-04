using AiYi.Service;
using CommonServiceLocator;

namespace AiYi.View
{
    /// <summary>
    /// CashierCardMainView.xaml 的交互逻辑
    /// </summary>
    public partial class CashierCardMainView
    {
        public CashierCardMainView()
        {
            InitializeComponent();

            SimpleIoc.Default.GetInstance<CashierCardFrameNavigationService>().Initial(mainFrame);

            SimpleIoc.Default.GetInstance<CashierCardFrameNavigationService>().NavigateTo("search");
        }
    }
}
