using System;
using System.Windows;
using System.Windows.Controls;
using NumberButton = System.Windows.Controls.Button;

namespace AiYi.Control
{
    /// <summary>
    /// 数字选择器
    /// </summary>
    public class NumberPicker : System.Windows.Controls.ContentControl
    {
        TextBlock tbAmount;
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            tbAmount = (TextBlock)Template.FindName("Amount", this);
            tbAmount.Text = Number.ToString();
            NumberButton btnLeft = (NumberButton)Template.FindName("BtnLeft", this);
            btnLeft.Click += (sender, e) =>
            {
                Number = Convert.ToInt32(tbAmount.Text);
                if (Number > 1)
                {
                    Number--;
                    tbAmount.Text = Number.ToString();
                }
            };
            NumberButton btnRight = (NumberButton)Template.FindName("BtnRight", this);
            btnRight.Click += (sender, e) =>
            {
                Number = Convert.ToInt32(tbAmount.Text);

                Number++;
                tbAmount.Text = Number.ToString();
            };
        }


        public int Number
        {
            get { return (int)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }
        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number", typeof(int), typeof(NumberPicker), new PropertyMetadata(1, OnValueChanged));

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is NumberPicker picker && picker.tbAmount != null)
            {
                picker.tbAmount.Text = e.NewValue.ToString();
            }
        }
    }
}
