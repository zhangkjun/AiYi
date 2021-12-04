using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiYi.Core
{
    public class Base
    {
		IFreeSql fsql = new FreeSql.FreeSqlBuilder()
	.UseConnectionString(FreeSql.DataType.Sqlite, DbFile)
	.UseAutoSyncStructure(true) //自动同步实体结构到数据库，FreeSql不会扫描程序集，只有CRUD时才会生成表。
	.Build(); //请务必定义成 Singleton 单例模式

		public static string DbFile
		{
			get
			{
				return string.Format("Data Source={0};Version=3;Pooling=true;FailIfMissing=false;", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user"));
				
			}
		}
		public static SQLiteConnection SimpleDbConnection()
		{
			return new SQLiteConnection(DbFile);
		}
	}
}
