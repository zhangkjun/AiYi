using System.Windows;
using System.Windows.Input;

namespace AiYi.Control
{
    public class BaseWindow : Window
    {
        public BaseWindow()
        {
            Owner = App.Current.MainWindow;
            WindowState = Owner.WindowState;
            Width = Owner.Width;
            Height = Owner.Height;
            Left = Owner.Left;
            Top = Owner.Top;
            Owner.StateChanged += (sender, e) =>
            {
                WindowState = Owner.WindowState;
                Width = Owner.Width;
                Height = Owner.Height;
                Left = Owner.Left;
                Top = Owner.Top;
            };


            #region 绑定系统Command
            CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, (sender, e) =>
            {
                WindowState = WindowState.Minimized;
            }));

            CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, (sender, e) =>
            {
                WindowState = WindowState.Maximized;
            }));

            CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand, (sender, e) =>
            {
                WindowState = WindowState.Normal;
            }));

            CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, (sender, e) =>
            {
                Close();
            }));
            #endregion
        }
    }
}
