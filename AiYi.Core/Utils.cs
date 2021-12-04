using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;

namespace AiYi.Core
{
    public class Utils
    {
        /// <summary>
        /// 将字符串类型数据转换成int类型数据
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>返回0表示字符串非int类型</returns>
        public static int ToInt(object str)
        {
            int i = 0;
            try
            {
                if (str != null)
                {
                    int.TryParse(str.ToString(), out i);
                }
            }
            catch
            {
            }
            finally { }
            return i;
        }
        public static float ToFloat(object str)
        {
            float i = 0;
            float.TryParse(str.ToString(), out i);
            return i;
        }
        public static double ToDouble(object str)
        {
            double i = 0;
            double.TryParse(str.ToString(), out i);
            return i;
        }
        /// <summary>
        /// 将字符转换成日期类型的数据
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>返回1900-1-1表示字符串非时间类型</returns>
        public static DateTime ToDateTime(string str)
        {
            DateTime i = DateTime.Parse(string.Format("{0:yyyy-MM-dd}", DateTime.Now));
            if (string.IsNullOrEmpty(str))
            {
                return i;
            }
            else
            {
                DateTime.TryParse(str, out i);
                return i;
            }

        }
        /// <summary>
        /// 转换为64位
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static long ToInt64(object str)
        {
            try
            {
                long i = 0;
                long.TryParse(str.ToString(), out i);
                return i;
            }
            catch
            {
                return 0;
            }
        }
        /// <summary>
        /// 判断是否已经联网
        /// </summary>
        /// <returns></returns>
        public static bool IsConnected()
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send("www.baidu.com");//百度IP
            if (reply.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// SHA256 加密
        /// </summary>
        /// <param name="input"> 要加密的字符串 </param>
        /// <returns></returns>
        public static string SHA256Encrypt(string input)
        {
            return HashEncrypt(SHA256.Create(), input, Encoding.UTF8);
        }
        /// <summary>
        /// 哈希加密算法
        /// </summary>
        /// <param name="hashAlgorithm"> 所有加密哈希算法实现均必须从中派生的基类 </param>
        /// <param name="input"> 待加密的字符串 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        private static string HashEncrypt(HashAlgorithm hashAlgorithm, string input, Encoding encoding)
        {
            var data = hashAlgorithm.ComputeHash(encoding.GetBytes(input));

            return BitConverter.ToString(data).Replace("-", "");
        }
        /// <summary>
        /// 获取guid
        /// </summary>
        /// <returns></returns>
        public static string Guid()
        {
            return System.Guid.NewGuid().ToString("N");
        }
    }
}
