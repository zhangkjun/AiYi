using System.Windows;
using System.Windows.Media;

namespace AiYi.Control
{
    /// <summary>
    /// 附加属性-图标
    /// </summary>
    public class Icon
    {
        #region 图标
        public static Geometry GetGeometry(DependencyObject obj)
        {
            return (Geometry)obj.GetValue(GeometryProperty);
        }
        public static void SetGeometry(DependencyObject obj, Geometry value)
        {
            obj.SetValue(GeometryProperty, value);
        }
        public static readonly DependencyProperty GeometryProperty =
            DependencyProperty.RegisterAttached("Geometry", typeof(Geometry), typeof(Icon), new PropertyMetadata(default));
        #endregion


        public static UIElement GetContent(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(ContentProperty);
        }
        public static void SetContent(DependencyObject obj, UIElement value)
        {
            obj.SetValue(ContentProperty, value);
        }
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.RegisterAttached("Content", typeof(UIElement), typeof(Icon), new PropertyMetadata(default));



        #region 宽度
        public static double GetWidth(DependencyObject obj)
        {
            return (double)obj.GetValue(WidthProperty);
        }
        public static void SetWidth(DependencyObject obj, double value)
        {
            obj.SetValue(WidthProperty, value);
        }
        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.RegisterAttached("Width", typeof(double), typeof(Icon), new PropertyMetadata(12.0));
        #endregion

        #region 高度
        public static double GetHeight(DependencyObject obj)
        {
            return (double)obj.GetValue(HeightProperty);
        }
        public static void SetHeight(DependencyObject obj, double value)
        {
            obj.SetValue(HeightProperty, value);
        }
        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.RegisterAttached("Height", typeof(double), typeof(Icon), new PropertyMetadata(12.0));
        #endregion
    }
}
