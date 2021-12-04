using AiYi.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class MemberMainViewModel : ViewModelBase
    {
        ObservableCollection<StoreCardUser> AllUserList;

        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            AllUserList = new ObservableCollection<StoreCardUser>();
            for (int i = 0; i < 10; i++)
            {
                AllUserList.Add(new StoreCardUser { Name = "宇宙人" + (i + 1), CardNO = "007", PhoneNum = "12345678912" });
                AllUserList.Add(new StoreCardUser { Name = "张三丰" + (i + 1), CardNO = "010", PhoneNum = "12545678912" });
            }
            StoreCardUserList = AllUserList;
        }

        #region 属性
        private ObservableCollection<StoreCardUser> _storeCardUserList;
        /// <summary>
        /// 列表
        /// </summary>
        public ObservableCollection<StoreCardUser> StoreCardUserList
        {
            get { return _storeCardUserList; }
            set { Set(ref _storeCardUserList, value); }
        }

        private string _searchName;
        /// <summary>
        /// 搜索关键字
        /// </summary>
        public string SearchName
        {
            get { return _searchName; }
            set
            {
                Set(ref _searchName, value);
            }
        }

        private string _birthday;
        /// <summary>
        /// 生日
        /// </summary>
        public string Birthday
        {
            get { return _birthday; }
            set
            {
                Set(ref _birthday, value);
            }
        }


        private DateTime _selectedBirthday;
        /// <summary>
        /// 选择的日期
        /// </summary>
        public DateTime SelectedBirthday
        {
            get { return _selectedBirthday; }
            set
            {
                Set(ref _selectedBirthday, value);

                Birthday = SelectedBirthday.ToString("yyyy-MM-dd");
            }
        }
        #endregion


        #region 命令
        /// <summary>
        /// 搜索
        /// </summary>
        public ICommand SearchCommand => new RelayCommand(() =>
        {
            if (!string.IsNullOrEmpty(SearchName))
            {
                var userList = AllUserList.Where(c => c.Name.Contains(SearchName));
                StoreCardUserList = new ObservableCollection<StoreCardUser>(userList);
            }
            else
            {
                StoreCardUserList = AllUserList;
            }
        });

        /// <summary>
        /// 会员详情
        /// </summary>
        public ICommand StoreCardDetailCommand => new RelayCommand<StoreCardUser>((e) =>
        {
            if (e is StoreCardUser user)
            {
                MemberInfoView window = new MemberInfoView();
                window.Show();
            }
        });


        /// <summary>
        /// 确定新增
        /// </summary>
        public ICommand MemberAddCommand => new RelayCommand(() =>
        {
            TipView window = new TipView("新增成功！");
            window.Show();
        });
        #endregion



    }
}
