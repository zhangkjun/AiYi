
namespace AiYi.View
{
    /// <summary>
    /// TipView.xaml 的交互逻辑
    /// </summary>
    public partial class TipView
    {
        public TipView(string msg)
        {
            InitializeComponent();

            TBMsg.Text = msg;
        }
    }
}
