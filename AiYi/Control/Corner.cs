﻿using System.Windows;

namespace AiYi.Control
{
    /// <summary>
    /// 附加属性 圆角值
    /// </summary>
    public class Corner
    {
        #region 圆角值
        public static CornerRadius GetValue(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(ValueProperty);
        }

        public static void SetValue(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(ValueProperty, value);
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached("Value", typeof(CornerRadius), typeof(Corner), new PropertyMetadata(default));
        #endregion
    }
}
