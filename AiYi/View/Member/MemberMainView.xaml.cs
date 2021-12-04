using AiYi.ViewModel;
using CommonServiceLocator;
using System.Windows;
using System.Windows.Controls;

namespace AiYi.View
{
    public partial class MemberMainView : UserControl
    {
        public MemberMainView()
        {
            InitializeComponent();

            BtnCalendar.Click += BtnCalendar_Click;

            TBBirthday.TextChanged += TBBirthday_TextChanged;
        }

        private void BtnCalendar_Click(object sender, RoutedEventArgs e)
        {
            popupCalendar.IsOpen = true;
        }

        private void TBBirthday_TextChanged(object sender, TextChangedEventArgs e)
        {
            popupCalendar.IsOpen = false;
        }


        int loadcount = 0;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (loadcount == 1)
            {
                SimpleIoc.Default.GetInstance<MemberMainViewModel>().Init();
            }
            loadcount++;
        }
    }
}
