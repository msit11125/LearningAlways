using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSample.Wrong
{
    public abstract class DBProcessor
    {

        public virtual void Query()
        {
            // 取得資料
        }

        public virtual void Insert()
        {
            // Insert 資料
        }

        public virtual void Delete()
        {
            // Delete 資料
        }

        public virtual void Update()
        {
            // Update 資料
        }
    }

    public class StudentSqlClient : DBProcessor
    {
        public String StudentID
        { get; set; }
        public String Name
        { get; set; }
        //.....更多屬性

        public override void Query()
        {
            // ..實做 使用  System.Data.SqlClient 的程式碼讀取 SQL Server
        }

        public override void Insert()
        {
            // ..實做 使用  System.Data.SqlClient 的程式碼 Insert 資料 to SQL Server
        }

        public override void Delete()
        {
            // ..實做 使用  System.Data.SqlClient 的程式碼 Delete 資料 form SQL Server
        }

        public override void Update()
        {
            // ..實做 使用  System.Data.SqlClient 的程式碼 Update 資料 in SQL Server
        }
    }


    // 為了減少屬性的程式碼, 違反里氏替換原則
    // 因為複蓋掉了父類別原本應有的原則
    public class StudentOleDB : StudentSqlClient
    {
        public override void Query()
        {
            // ..實做 使用  System.Data.OleDB 的程式碼讀取 Access
        }

        public override void Insert()
        {
            // ..實做 使用 System.Data.OleDB 的程式碼 Insert 資料 to Access
        }

        public override void Delete()
        {
            // ..實做 使用  System.Data.OleDB 的程式碼 Delete 資料 from Access
        }

        public override void Update()
        {
            // ..實做 使用  System.Data.OleDB 的程式碼 Update 資料 in Access
        }
    }
}
