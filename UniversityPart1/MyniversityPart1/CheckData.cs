using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CheckData
    {


    public bool Check(String str)
    {
        char ch;
        bool bl;
        ch  = Convert.ToChar(str);

        bl = Char.IsDigit(ch);
        return bl;
    }


    }

