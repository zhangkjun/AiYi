using AiYi.Service;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class HaveMealsNumViewModel : ViewModelBase
    {
        public HaveMealsNumViewModel()
        {
            HaveNumber = 1;
        }

        #region 属性
        private int _haveNumber;
        /// <summary
        /// 用餐人数
        /// </summary>
        public int HaveNumber
        {
            get { return _haveNumber; }
            set { Set(ref _haveNumber, value); }
        }
        #endregion

        #region 命令
        /// <summary>
        /// 设置用餐人数
        /// </summary>
        public ICommand SetHaveMealsNumCommand => new RelayCommand<string>((e) =>
        {
            if (e is string num)
            {
                HaveNumber = Convert.ToInt32(num);
            }
        });

        /// <summary>
        /// 人数操作
        /// </summary>
        public ICommand SetNumCommand => new RelayCommand<string>((e) =>
        {
            if (e is string str)
            {
                if (str == "zj")
                {
                    HaveNumber++;
                }
                else if (str == "js")
                {
                    if (HaveNumber > 1)
                    {
                        HaveNumber--;
                    }
                }
            }
        });


        /// <summary>
        /// 进入点餐界面
        /// </summary>
        /// </summary>
        public ICommand JumpOrderCommand => new RelayCommand<Window>((e) =>
        {
            if (e is Window window)
            {
                if (window != null)
                {
                    window.Close();

                    SimpleIoc.Default.GetInstance<FrameNavigationService>().NavigateTo("order");
                }
            }
        });


        /// <summary>
        /// 关闭当前界面
        /// </summary>
        /// </summary>
        public ICommand CloseCommand => new RelayCommand<Window>((e) =>
        {
            if (e is Window window)
            {
                if (window != null)
                {
                    HaveNumber = 1;

                    window.Close();
                }
            }
        });

        #endregion


    }
}
