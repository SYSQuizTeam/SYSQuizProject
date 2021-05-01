using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLibrary
{
    public interface IDAO<T>
    {
        int Delete(string req);
        int insert(T M);
        ArrayList select(string req);
        int update(T M, string req);
    }
}
