using AiYi.Model;
using AiYi.Service;
using AiYi.View;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class DeskViewModel : ViewModelBase
    {
        public DeskViewModel()
        {
            //区域数据
            DeskCategoryList = new ObservableCollection<DeskCategory>();
            for (int i = 0; i < 50; i++)
            {
                DeskCategoryList.Add(new DeskCategory() { Id = i + 1, Name = (i + 1).ToString("000"), Status = 1 });
                //空闲
              //  DeskList.Add(new Desk() { Id = i + 1, Name = (i + 1).ToString("000"), Status = 1 });
            }
            //foreach (var dt in Services.DeskCategory.GetModelList())
            //{
            //    DeskCategoryList.Add(new DeskCategory() { Id = dt.Id, Name = dt.Name, Status = 1 });
            //}
            //数据
            DeskList = new ObservableCollection<Desk>();
            for (int i = 0; i < 5; i++)
            {
                //空闲
                DeskList.Add(new Desk() { Id = i + 1, Name = (i + 1).ToString("000"), Status = 1 });
            }
            for (int i = 0; i < 5; i++)
            {
                //有人
                DeskList.Add(new Desk() { Id = i + 1, Name = (i + 1).ToString("000"), Status = 2 });
            }
            for (int i = 0; i < 6; i++)
            {
                //预定
                DeskList.Add(new Desk() { Id = i + 1, Name = (i + 1).ToString("000"), Status = 3 });
            }
        }

        #region 属性
        private ObservableCollection<Desk> _deskList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<Desk> DeskList
        {
            get { return _deskList; }
            set { Set(ref _deskList, value); }
        }

        private ObservableCollection<DeskCategory> _deskCategoryList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<DeskCategory> DeskCategoryList
        {
            get { return _deskCategoryList; }
            set { Set(ref _deskCategoryList, value); }
        }

        private DeskCategory _selectedDeskCategory;
        /// <summary>
        /// 选中的区域
        /// </summary>
        public DeskCategory SelectedDeskCategory
        {
            get { return _selectedDeskCategory; }
            set
            {
                Set(ref _selectedDeskCategory, value);

                TipView window = new TipView(SelectedDeskCategory.Name);
                window.Show();
            }
        }
        #endregion


        #region 命令  
        /// <summary>
        /// 选择用餐人数
        /// </summary>
        public ICommand HaveMealsNumCommand => new RelayCommand(() =>
        {
            HaveMealsNumView window = new HaveMealsNumView();
            window.Show();
        });

        /// <summary>
        /// 查询修改
        /// </summary>
        public ICommand ChangProductCommand => new RelayCommand(() =>
        {
            SimpleIoc.Default.GetInstance<FrameNavigationService>().NavigateTo("changProduct");
        });


        /// <summary>
        /// 操作显示
        /// </summary>
        /// </summary>
        public ICommand ButtonVisibilityCommand => new RelayCommand<Border>((e) =>
        {
            if (e is Border border)
            {
                if (border != null)
                {
                    border.Visibility = Visibility.Visible;
                }
            }
        });


        /// <summary>
        /// 操作隐藏
        /// </summary>
        /// </summary>
        public ICommand ButtonCollapsedCommand => new RelayCommand<Border>((e) =>
        {
            if (e is Border border)
            {
                if (border != null)
                {
                    border.Visibility = Visibility.Collapsed;
                }
            }
        });


        /// <summary>
        /// 并台
        /// </summary>
        public ICommand CombineDeskCommand => new RelayCommand(() =>
        {
            CombineDeskView window = new CombineDeskView();
            window.Show();
        });

        /// <summary>
        /// 预定点菜
        /// </summary>
        public ICommand YDDCCommand => new RelayCommand(() =>
        {
            TipView window = new TipView("亲，您还没有选择桌台哦！");
            window.Show();
        });

        /// <summary>
        /// 追加连台
        /// </summary>
        public ICommand AddToDeskCommand => new RelayCommand(() =>
        {
            AddToDeskView window = new AddToDeskView();
            window.Show();
        });

        /// <summary>
        /// 取消连台
        /// </summary>
        public ICommand CancelCombineDeskCommand => new RelayCommand(() =>
        {
            CancelCombineDeskView window = new CancelCombineDeskView();
            window.Show();
        });


        #endregion


    }
}
