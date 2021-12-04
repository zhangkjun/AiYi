namespace AiYi.Common
{
    public class ControlHelper
    {
        #region 递归找父级TabControl
        /// <summary>
        /// 递归找父级TabControl
        /// </summary>
        /// <param name="reference">依赖对象</param>
        public static UIElement FindParent<T>(UIElement reference)
        {
            DependencyObject dObj = VisualTreeHelper.GetParent(reference);
            if (dObj == null)
                return default;
            if (dObj.GetType() == typeof(T))
                return (UIElement)dObj;
            else
                return FindParent<T>((UIElement)dObj);
        }
        #endregion
    }
}
