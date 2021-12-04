namespace AiYi.Model
{
    /// <summary>
    /// 登录商户零时数据保存
    /// </summary>
    public class LoginUser
    {
        private static int userId;
        public static int UserId { get => userId; set => userId = value; }
        public static string Account { get => account; set => account = value; }
        public static string AccountName { get => accountName; set => accountName = value; }
        public static string AccountAuth { get => accountAuth; set => accountAuth = value; }
        public static string AccountRole { get => accountRole; set => accountRole = value; }
        public static int Busid { get => busid; set => busid = value; }
        public static string Busname { get => busname; set => busname = value; }
        public static string Token { get => token; set => token = value; }

        private static string account;
        private static string accountName;
        private static string accountAuth;
        private static string accountRole;
        private static int busid;
        private static string busname;
        private static string token;
    }
}
