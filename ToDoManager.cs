using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace NaskoShell
{
    class ToDoManager
    {
        private static SQLiteDatabase db;
        public ToDoManager(SQLiteDatabase database)
        {
            db = database;
        }

        public string LoadTodo()
        {
            string s = "";
            try
            {
                DataTable task;
                String query = "select task \"task\"";
                query += "from todo where done='false' order by dueto, priority";//and  dueto=strftime(\"%d.%m.%Y\",'now','localtime');";
                task = db.GetDataTable(query);
                if (task.Rows.Count != 0)
                {
                    s = task.Rows[0]["task"].ToString();
                }
                else s = "All done!";
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                return error;
            }

            return s;
        }

        public bool AddTodo(string task, DateTime dueto, int priority)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("task", task);
            data.Add("dueto", dueto.Date.ToString("dd.MM.yyyy"));
            data.Add("priority", priority.ToString());
            data.Add("done", "false");
            try
            {
                db.Insert("todo", data);
                return true;
            }
            catch (Exception crap)
            {
                return false;
            }
        }

        public bool DoIt(string task)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("done", "true");
            try
            {
                db.Update("todo", data, String.Format("todo.task = '{0}'", task));
                return true;
            }
            catch (Exception crap)
            {
                return false;
            }
            
        }


    }
}
