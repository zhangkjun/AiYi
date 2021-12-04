using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class NumKeyboardViewModel: ViewModelBase
    {
        public NumKeyboardViewModel()
        {
            NumCode = "";
        }

        #region 属性
        private string _numCode;
        /// <summary>
        /// 牌号
        /// </summary>
        public string NumCode
        {
            get { return _numCode; }
            set { Set(ref _numCode, value); }
        }
        #endregion


        #region 命令
        public ICommand NumCodeCommand => new RelayCommand<string>((obj) =>
        {
            if (obj is string str)
            {
                if (str == "qk")
                {
                    NumCode = "";
                }
                else if (str == "sc")
                {
                    if (!string.IsNullOrEmpty(NumCode))
                    {
                        NumCode = NumCode.Substring(0, NumCode.Length - 1);
                    }
                }
                else
                {
                    NumCode += str;
                }
            }
        });
        #endregion

    }
}
