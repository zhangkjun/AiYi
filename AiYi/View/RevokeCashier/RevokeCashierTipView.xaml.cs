using System.Windows;
using System.Windows.Media;

namespace AiYi.View
{
    /// <summary>
    /// RevokeCashierTipView.xaml 的交互逻辑
    /// </summary>
    public partial class RevokeCashierTipView
    {
        public RevokeCashierTipView()
        {
            InitializeComponent();


            TBPwd.TextDecorations = new TextDecorationCollection(new TextDecoration[] {
                new TextDecoration() {
                     Location= TextDecorationLocation.Strikethrough,
                      Pen= new Pen(Brushes.Black, 10f) {
                          DashCap =  PenLineCap.Round,
                           StartLineCap= PenLineCap.Round,
                            EndLineCap= PenLineCap.Round,
                             DashStyle= new DashStyle(new double[] {0.0,1.2 }, 0.6f)
                      }
                }

            });

        }
    }
}
