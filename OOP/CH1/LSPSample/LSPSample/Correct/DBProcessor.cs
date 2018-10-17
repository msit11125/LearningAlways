using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSample.Correct
{
    //抽象
    internal abstract class DBProcessor<T>
    {
        // 取得資料
        internal abstract T Query();
        // Insert 資料
        internal abstract void Insert(T data);
        // Delete 資料
        internal abstract void Delete(T data);
        // Update 資料
        internal abstract void Update(T data);
    }

    public class Student
    {
        public String StudentID
        { get; set; }
        public String Name
        { get; set; }
        //.....更多屬性

    }

    internal class StudentSqlProcessor : DBProcessor<Student>
    {

        internal override Student Query()
        {
            // 查詢 SQL Server 中的資料並回傳
            return new Student();
        }

        internal override void Insert(Student data)
        {
            // 將傳入的 data Insert to SQL Server
        }

        internal override void Delete(Student data)
        {
            //將傳入的 data 從 SQL Server 中刪除
        }

        internal override void Update(Student data)
        {
            //將傳入的 data 更新在 SQL Sever 中同一條件的資料
        }
    }

    internal class StudentAcessProcessor : DBProcessor<Student>
    {
        internal override Student Query()
        {
            // 查詢 Access 中的資料並回傳
            return new Student();
        }

        internal override void Insert(Student data)
        {
            // 將傳入的 data Insert to Access
        }

        internal override void Delete(Student data)
        {
            //將傳入的 data 從 Access 中刪除
        }

        internal override void Update(Student data)
        {
            //將傳入的 data 更新在 Access 中同一條件的資料
        }
    }


    public interface IDBOperator
    {
        void Query();
        void Insert();
        void Update();
        void Delete();
    }

    //分離資料與程序
    public class StudentDB : IDBOperator
    {
        public Student StudentData
        { get; set; }

        //使用 SQL 的 DBProcessor 
        private DBProcessor<Student> _processor = new StudentSqlProcessor();
        //改變為 Access 的 DBProcessor
        //private DBProcessor<Student> _processor = new StudentAcessProcessor();
        //註: 這邊取得DBPeocessor 方式如果用 Factory 就更靈活

        public void Query()
        {
            // 呼叫 _processor.Query, 並將結果傳給 StudentData;
            StudentData = _processor.Query();
        }

        public void Insert()
        {
            // 呼叫 _processor.Insert()
            _processor.Insert(StudentData);
        }

        public void Update()
        {
            // 呼叫 _processor.Update 
            _processor.Update(StudentData);
        }

        public void Delete()
        {
            // 呼叫 _processor.Delete
            _processor.Update(StudentData);
        }
    }
}
