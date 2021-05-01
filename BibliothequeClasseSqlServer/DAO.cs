using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLibrary
{
    //Class DAO
    public abstract class DAO : Sql
    {
        public static string[] param_co = new string[2];
        string Table;

        static DAO()
        {
            param_co[0] = "gestionnotes2021V2";
            param_co[1] = @"DESKTOP-CMMGAAS\SQLEXPRESS";
           // param_co[2] = "root";
            //param_co[3] = "";
            
        }

        public DAO(string t) : base(param_co[0], param_co[1])
        {
            Table = t;
        }


        public int update(string conditions, Dictionary<string, object> Data)
        {
            string sql = "update dbo." + Table + " set ";
            int size = 0;
            foreach (var value in Data.Keys)
            {
                string virgul = "";
                if (++size < Data.Keys.Count)
                    virgul = ",";
                sql += value + " = " + (Data[value] is string ? ("'" + Data[value] + "'") : Data[value]) + virgul;
            }
            sql += " where " + conditions + ";";
            return Up(sql);
        }

        public int insert(Dictionary<string, object> Data)
        {
            string sql = "insert into dbo." + Table;
            int size = 0;
            string values = "(";
            string data = "(";
            foreach (var value in Data.Keys)
            {
                string virgul = "";
                if (++size < Data.Keys.Count)
                    virgul = ",";
                else virgul = ")";
                values += value + virgul;
                data += (Data[value] is string ? ("'" + Data[value] + "'") : Data[value]) + virgul;
            }


            sql += values + "values " + data;
            return Up(sql);
        }
        public int delete(string conditions)
        {
            string sql = "delete from dbo." + Table;
            if (conditions != "") sql += " where " + conditions;
            return Up(sql);
        }


        public List<Dictionary<string, string>> select(string Conditions = "")
        {
            string sql = "select * from dbo." + Table + " ";
            if (Conditions != "") sql += " Where " + Conditions;
            return base.Get(sql);
        }



        // select les niveau d'une Filier
        public List<Dictionary<string, string>> selectNivF(string codFiliere)
        {
            string sql = "select niveaux from dbo.filiere where designation = " + "'" + codFiliere + "'";
            return base.Get(sql);
        }












    }
}
