﻿using DiplomProjectTrash.MODEL;
using System;
using System.Collections.Generic;
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
        LOCATION myLocation;

        private string SQL_GET_LOCATION = "select * from location";
        private string SQL_GET_ARCHIVE_ALL = "select a.photo, a.coordinatae, ip.ip, l.description, a.accauting_date" +
                                             "  from archive a, ip_cam ip, location l" +
                                             " where a.ip_cam_num_id = ip.ip_cam_num_id" +
                                             "   and ip.location_num_id = l.location_num_id;";

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
            myConnection.Open();
        }

        public void DB_CLOSE()
        {
            myConnection.Close();
        }

        public List<ARCHIVE> GET_ARCHIVE()
        {
            OleDbDataReader reader = new OleDbCommand(SQL_GET_ARCHIVE_ALL, myConnection).ExecuteReader();
            List<ARCHIVE> listArchive = new List<ARCHIVE>();

            while (reader.Read())
            {
                listArchive.Add(new ARCHIVE(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()));
            }

            reader.Close();

            return listArchive;
        }

        public void SET_IP_CAM()
        { }

        public List<LOCATION> GET_LOCATION()
        {
            OleDbDataReader reader = new OleDbCommand(SQL_GET_LOCATION, myConnection).ExecuteReader();
            List<LOCATION> listLocation = new List<LOCATION>();

            while (reader.Read())
            {
                listLocation.Add(new LOCATION(Convert.ToInt32(reader[0]), reader[1].ToString()));
            }

            reader.Close();

            return listLocation;
        }

        public void GET_IP_CAM(string ip, string descr, int location_num_id)
        {
           
        }
    }
}
