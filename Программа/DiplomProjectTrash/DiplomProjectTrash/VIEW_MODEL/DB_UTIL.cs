﻿using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace DiplomProjectTrash.VIEW_MODEL
{
    public class DB_UTIL
    {
        public string db_name { get; set; }
        public string db_login { get; set; }
        public string db_password { get; set; }

        OleDbConnection myConnection;


        public DB_UTIL(string name, string login, string password)
        {
            this.db_name  = name;
            this.db_login = login;
            this.db_password = password;
        }

        public DB_UTIL()
        {
            this.db_name = string.Empty;
            this.db_login = string.Empty;
            this.db_password = string.Empty;
        }

        /// <summary>
        /// Метод возвращает строку Driver connect.
        /// </summary>
        /// <returns>true: ConnectString</returns>
        private string DB_CONNECT_STRING()
        {
            return String.Concat(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.db_name, ".mdb");
        }

        private string DB_CONNECT_CHEK()
        {
            //if (String.IsNullOrEmpty(db_login))
            //    return "Логин";
            //else if (String.IsNullOrEmpty(db_password))
            //    return "Пароль";
            //else 
            if (String.IsNullOrEmpty(db_name))
                return "Имя БД";
            else
                return string.Empty;
        }

        /// <summary>
        /// Метод соединения с БД MS Accesse
        /// </summary>
        public void DB_CONNECT()
        {
            var result = DB_CONNECT_CHEK();

            if (!String.IsNullOrEmpty(result))
            {
                LIB_UTIL.MassageError(String.Concat("Проверьте поле ", result));
                return;
            }
            myConnection = new OleDbConnection(DB_CONNECT_STRING());
            DB_OPEN();
        }

        public void DB_OPEN()
        {
            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                LIB_UTIL.MassageError(ex);
            }
        }

        public void DB_CLOSE()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception ex)
            {
                LIB_UTIL.MassageError(ex);
            }
        }
    }
}
