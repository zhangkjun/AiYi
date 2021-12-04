using AiYi.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class AddToDeskViewModel : ViewModelBase
    {
        public AddToDeskViewModel()
        {
        }


        /// <summary>
        /// 追加连台
        /// </summary>
        public ICommand AddToDeskCommand => new RelayCommand(() =>
        {
            TipView window = new TipView("连台只针对未点菜桌台，请核实后重新操作！");
            window.Show();
        });

    }
}
