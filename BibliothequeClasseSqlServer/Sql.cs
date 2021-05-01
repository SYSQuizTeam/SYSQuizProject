using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLibrary
{
    public abstract class Sql
    {
        string BD;
        IDbConnection con = null;
        //string pass;
        SqlDataReader re;
        IDbCommand st = null;
        //string user;
        string serv;


        public Sql(string bD, string serveur)
        {
            BD = bD;
           // this.pass = pass;
            //this.user = user;
            this.serv = serveur;

            // la cnx est sous forme une authentification Windows
            con = new SqlConnection("Initial Catalog=" + BD + "; Data Source= " + serv + "; Integrated Security = True");
            con.Open();
            st = new SqlCommand();
        }

        public IDbConnection Con { get => con; set => con = value; }
        public object MessageBox { get; private set; }


        public List<Dictionary<string, string>> Get(string sql)
        {
            //slect 
            Console.WriteLine("###########> " + sql);
            List<Dictionary<string, string>> Liste = new List<Dictionary<string, string>>();

            //try
            //{
                //st.Connection = con;
                //st.CommandText = sql;
                st = new SqlCommand(sql, (SqlConnection)con) ;
                re = (SqlDataReader)st.ExecuteReader();
                while (re.Read())
                {
                    Dictionary<string, string> Row = new Dictionary<string, string>();

                    for (int i = 0; i < re.FieldCount; i++)
                    {
                    Row.Add(re.GetName(i), re.GetSqlValue(i).ToString());
                   // re.Get
                    }
                    Liste.Add(Row);
                }

            //}
            //catch (SqlException ex)
            //{
              //  Console.WriteLine("Error: {0}", ex.ToString());

//            }
          
                re.Close();
                return Liste;
           
        }

        public int Up(string sql)
        {
            {
                st.Connection = con;
                st.CommandText = sql;
                return st.ExecuteNonQuery();

            }

        }

    }
}
