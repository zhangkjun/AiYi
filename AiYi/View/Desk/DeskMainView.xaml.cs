using AiYi.Service;
using CommonServiceLocator;
using System.Windows.Controls;

namespace AiYi.View
{
    public partial class DeskMainView : UserControl
    {
        public DeskMainView()
        {
            InitializeComponent();

            SimpleIoc.Default.GetInstance<FrameNavigationService>().Initial(mainFrame);

            SimpleIoc.Default.GetInstance<FrameNavigationService>().NavigateTo("desk");
        }
    }
}
