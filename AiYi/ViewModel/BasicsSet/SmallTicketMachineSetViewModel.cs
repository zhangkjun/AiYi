using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace AiYi.ViewModel
{
    public class SmallTicketMachineSetViewModel : ViewModelBase
    {
        public SmallTicketMachineSetViewModel()
        {
            PrinterIP = "192.168.10.11";
            PrinterCount = 4;

            IsOpenBluetooth = false;
            BluetoothVisbie = Visibility.Collapsed;
            BluetoothList = new ObservableCollection<Bluetooth>();
            BluetoothList.Add(new Bluetooth() { Name = "设备anzuo-1", Status = "直接打印" });
            BluetoothList.Add(new Bluetooth() { Name = "设备anzuo-2", Status = "配对" });
            BluetoothList.Add(new Bluetooth() { Name = "设备anzuo-3", Status = "配对" });
        }

        #region 属性
        private string _printerIP;
        /// <summary>
        /// 小票打印机IP
        /// </summary>
        public string PrinterIP
        {
            get { return _printerIP; }
            set { Set(ref _printerIP, value); }
        }

        private int _printerCount;
        /// <summary>
        /// 小票打印机张数
        /// </summary>
        public int PrinterCount
        {
            get { return _printerCount; }
            set { Set(ref _printerCount, value); }
        }

        private string _syxpz;
        /// <summary>
        /// 收银小票纸
        /// </summary>
        public string SYXPZ
        {
            get { return _syxpz; }
            set { Set(ref _syxpz, value); }
        }

        private bool _isOpenBluetooth;
        /// <summary>
        /// 是否开启蓝牙小票机
        /// </summary>
        public bool IsOpenBluetooth
        {
            get { return _isOpenBluetooth; }
            set
            {
                Set(ref _isOpenBluetooth, value);

                BluetoothVisbie = Visibility.Collapsed;
                if (value)
                {
                    BluetoothVisbie = Visibility.Visible;
                }
            }
        }

        private ObservableCollection<Bluetooth> _bluetoothList;
        /// <summary>
        /// 蓝牙列表
        /// </summary>
        public ObservableCollection<Bluetooth> BluetoothList
        {
            get { return _bluetoothList; }
            set { Set(ref _bluetoothList, value); }
        }

        private Visibility _bluetoothVisbie;
        /// <summary>
        /// 蓝牙列表隐藏显示
        /// </summary>
        public Visibility BluetoothVisbie
        {
            get { return _bluetoothVisbie; }
            set { Set(ref _bluetoothVisbie, value); }
        }
        #endregion


        #region 命令
        /// <summary>
        /// 收银小票纸设置
        /// </summary>
        public ICommand SetSYXPZCommand => new RelayCommand<string>((e) =>
        {
            if (e is string syxpz)
            {
                SYXPZ = syxpz;
            }
        });

        /// <summary>
        /// 选择蓝牙设备
        /// </summary>
        public ICommand SetBluetoothCommand => new RelayCommand<Bluetooth>((e) =>
        {
            if (e is Bluetooth bluetooth)
            {

            }
        });
        #endregion

    }

    public class Bluetooth
    {
        public string Name { get; set; }

        public string Status { get; set; }
    }



}
