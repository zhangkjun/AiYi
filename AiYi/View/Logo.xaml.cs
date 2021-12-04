using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace AiYi.View
{
    /// <summary>
    /// Logo.xaml 的交互逻辑
    /// </summary>
    public partial class Logo
    {
        private Storyboard story;
        public Logo()
        {
            InitializeComponent();
            story = Resources["OnLoaded"] as Storyboard;
        }

        public bool Run
        {
            get { return (bool)GetValue(RunProperty); }
            set { SetValue(RunProperty, value); }
        }

        public static readonly DependencyProperty RunProperty =
            DependencyProperty.Register("Run", typeof(bool), typeof(Logo), new PropertyMetadata(false, RunStatePropertyChangedCallback));


        private static void RunStatePropertyChangedCallback(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is Logo logo)
            {
                if (logo.Run)
                {
                    logo.Start();
                }
                else
                {
                    logo.Stop();
                }
            }
        }

        public void Start()
        {
            if (Visibility != Visibility.Visible)
            {
                Visibility = Visibility.Visible;
                story.Begin();
            }
        }

        public void Stop()
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                story.Stop();
                Visibility = Visibility.Collapsed;
            }));
        }
    }
}
