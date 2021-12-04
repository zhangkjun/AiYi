using AiYi.View;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System.Windows.Controls;
using System.Windows.Input;
using System.Threading.Tasks;
namespace AiYi.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {
        }
        #region 属性
        private bool _isLoad=false;

        /// <summary>
        /// 是否加载
        /// </summary>
        public bool IsLoad
        {
            get { return _isLoad; }
            set
            {
                Set(ref _isLoad, value);
            }
        }

        private string _userName = "";
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set
            {
                Set(ref _userName, value);
            }
        }

        private string _userPwd = "";
        /// <summary>
        /// 密码
        /// </summary>
        public string UserPwd
        {
            get { return _userPwd; }
            set
            {
                Set(ref _userPwd, value);
            }
        }


        private string _msg="";
        /// <summary>
        /// 提示消息
        /// </summary>
        public string Msg
        {
            get { return _msg; }
            set { Set(ref _msg, value); }
        }


        private string _zhUserName="";
        /// <summary>
        /// 找回密码的账号
        /// </summary>
        public string ZHUserName
        {
            get { return _zhUserName; }
            set
            {
                Set(ref _zhUserName, value);
            }
        }

        private string _verCode="";
        /// <summary>
        /// 找回密码的验证码
        /// </summary>
        public string VerCode
        {
            get { return _verCode; }
            set
            {
                Set(ref _verCode, value);
            }
        }

        private string _phoneVerCode="";
        /// <summary>
        /// 手机验证码
        /// </summary>
        public string PhoneVerCode
        {
            get { return _phoneVerCode; }
            set
            {
                Set(ref _phoneVerCode, value);
            }
        }



        #endregion

        #region 验证输入
        public bool CheckInput()
        {
            bool status = false;
            if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(UserPwd))
            {
                //if (UserName.ToLower() == "admin" && UserPwd.ToLower() == "123")
                //{
                status = true;
                //}
                //else
                //{
                //    Msg = "员工工号或密码不正确";
                //}
            }
            else
            {
                Msg = "请输入员工工号或密码";
            }
            return status;
        }
        #endregion

        #region 命令
        /// <summary>
        /// 登录
        /// </summary>
        public ICommand LoginCommand => new RelayCommand(() =>
        {
            //SimpleIoc.Default.GetInstance<INavigationService>().NavigateTo("main");
            //return;
            if (CheckInput())
            {
                IsLoad = true;
                TaskScheduler uiContext = TaskScheduler.FromCurrentSynchronizationContext();
                Task t = Task.Factory.StartNew( () =>
                {
                  System.Threading.Thread.Sleep(1000);
                    return UserName;
                }).ContinueWith(m =>
                {
                    IsLoad = false;
                    SimpleIoc.Default.GetInstance<INavigationService>().NavigateTo("main");
                }, uiContext);
                //
                //Task.Run(() =>
                //{
                //    if (Core.Utils.IsConnected())
                //    {

                //        IsLoad = false;

                //        //var dt = Core.Web.login(UserName, UserPwd);
                //        //if (dt.GetValue("status").ToString() == "1")
                //        //{
                //        //    Model.Customer model = new Model.Customer
                //        //    {
                //        //        Id = Core.Utils.ToInt(dt.GetValue("userId").ToString()),
                //        //        MerchantId = Core.Utils.ToInt(dt.GetValue("busid").ToString()),
                //        //        Password = UserPwd,
                //        //        PrivateKey = dt.GetValue("privateKey").ToString(),
                //        //        Token = dt.GetValue("token").ToString(),
                //        //        UserName = dt.GetValue("account").ToString()
                //        //    };

                //        //    //DispatcherHelper.CheckBeginInvokeOnUI();

                //        //    if (Services.Customer.Update(model))
                //        //    {
                //        //        IsLoad = false;
                //        //        SimpleIoc.Default.GetInstance<INavigationService>().NavigateTo("main");
                //        //    }
                //        //    else
                //        //    {
                //        //        Msg = "本地数据库损坏";
                //        //    }
                //        //}
                //        //else
                //        //{
                //        //    Msg = dt.GetValue("msg").ToString();
                //        //}
                //    }
                //    else
                //    {
                //        SimpleIoc.Default.GetInstance<INavigationService>().NavigateTo("main");
                //    }
                //});
            }
        });


        StackPanel stackPanel = new StackPanel();

        /// <summary>
        /// 找回密码
        /// </summary>
        public ICommand JumpGetPwdCommand => new RelayCommand<StackPanel>((e) =>
        {
            if (e is StackPanel getStackPanel)
            {
                Msg = "";
                getStackPanel.Visibility = Visibility.Visible;
                stackPanel = getStackPanel;

                ZHUserName = "";
                VerCode = "";
            }
        });


        /// <summary>
        /// 发送验证码
        /// </summary>
        public ICommand SendVerCodeCommand => new RelayCommand<StackPanel>((e) =>
        {
            if (!string.IsNullOrWhiteSpace(ZHUserName) && !string.IsNullOrWhiteSpace(VerCode))
            {
                if (e is StackPanel getStackPanel)
                {
                    TipView window = new TipView("验证信息已经发送到您的手机，请注意查看！");
                    window.Show();

                    getStackPanel.Visibility = Visibility.Visible;
                    stackPanel.Visibility = Visibility.Collapsed;
                    stackPanel = getStackPanel;

                    PhoneVerCode = "";
                    Msg = "";
                }
            }
            else
            {
                Msg = "请输入账号或验证码";
            }
        });


        /// <summary>
        /// 发送验证码
        /// </summary>
        public ICommand SendPhoneCodeCommand => new RelayCommand(() =>
        {
            if (!string.IsNullOrWhiteSpace(PhoneVerCode))
            {
                TipView window = new TipView("密码已经发送到手机，请注意查看！");
                window.Show();

                stackPanel.Visibility = Visibility.Collapsed;
                Msg = "";
            }
            else
            {
                Msg = "请输入验证码";
            }
        });


        /// <summary>
        /// 返回登录
        /// </summary>
        public ICommand BackLoginCommand => new RelayCommand<StackPanel>((e) =>
        {
            if (e is StackPanel getStackPanel)
            {
                getStackPanel.Visibility = Visibility.Collapsed;
                Msg = "";
            }
        });



        #endregion
    }
}
