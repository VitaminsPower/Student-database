using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

public  class CheckFormat
    {
        public static bool ChFormat(string str)



    {
            bool bl;
        

        Regex r = new Regex(@"[\d!#%^&*()$]");
        Match m = r.Match(str);

        if (m.Success)
        {
            bl = false;
        }

        else
        {
            bl = true;
        }
        
        return bl;



     }




    }

