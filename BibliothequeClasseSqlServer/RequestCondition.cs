using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLibrary
{
    public class RequestCondition
    {

        string Param;

        public RequestCondition(string param)
        {
            Param = param;
        }

        public string Equal(object value)
        {
            string res;
            res = " " + Param + "=" + (value is string ? ("'" + value + "'") : value);
            return res;
        }

        private string ForINnotIN(object[] values)
        {
            string val = " (";
            bool firstFlag = true;
            foreach (object i in values)
            {
                if (firstFlag == false)
                {
                    val += ", ";
                }
                else
                    firstFlag = false;
                val += (i is string ? ("'" + i + "'") : i);
            }
            val += ") ";
            return val;

        }

        public string GreaterThan(object value)
        {
            string res;
            res = " " + Param + ">" + (value is string ? ("'" + value + "'") : value);
            return res;
        }

        public string GreaterThanOrEqual(object value)
        {
            string res;
            res = " " + Param + ">=" + (value is string ? ("'" + value + "'") : value);
            return res;
        }

        public string IN(ArrayList arrayList)
        {
            string res;
            res = " " + Param + " IN " + ForINnotIN(arrayList);

            return res;
        }

        private string ForINnotIN(ArrayList arrayList)
        {
            string val = " (";
            bool firstFlag = true;
            foreach (object i in arrayList)
            {
                if (firstFlag == false)
                {
                    val += ", ";
                }
                else
                    firstFlag = false;
                val += (i is string ? ("'" + i + "'") : i);
            }
            val += ") ";
            return val;
        }

        public string IN(object[] values)
        {
            string res;
            res = " " + Param + " IN " + ForINnotIN(values);

            return res;
        }

        public string LessThan(object value)
        {
            string res;
            res = " " + Param + "<" + (value is string ? ("'" + value + "'") : value);
            return res;
        }

        public string LessThanOrEqual(object value)
        {
            string res;
            res = " " + Param + "<=" + (value is string ? ("'" + value + "'") : value);
            return res;
        }

        public string LikeCenter(object value)
        {
            string res;
            res = " " + Param + " LIKE " + "'%" + value.ToString() + "%'";
            return res;
        }

        public string LikeFirst(object value)
        {
            string res;
            res = " " + Param + " LIKE " + "'" + value.ToString() + "%'";
            return res;
        }

        public string LikeLast(object value)
        {
            string res;
            res = " " + Param + " LIKE " + "'%" + value.ToString() + "'";
            return res;
        }

        public string NotEqual(object value)
        {
            string res;
            res = " " + Param + "<>" + (value is string ? ("'" + value + "'") : value);
            return res;
        }

        public string NotIN(object[] values)
        {
            string res;
            res = " " + Param + " NOT IN (";
            foreach (object value in values)
            {
                res += values.ToString() + ",";//value
            }
            return res;
        }

    }
}


