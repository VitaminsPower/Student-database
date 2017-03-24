using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace UniversityPart1
{
 public   class ExecuteSpecialisationList
    {

          static public string[] ExSpList(string[] str)

        {
            string conStr = @"Data Source=./SQLEXPRESS; Initial Catalog=University; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                SqlCommand Rdr = new SqlCommand("select * from SpecialisationList", connection);

                SqlDataReader rdr1 = Rdr.ExecuteReader();

                int i = 0;

                while (rdr1.Read())
                {
                    str[i] = rdr1.GetFieldValue<string>(1);
                    i++;

                }
            }

            return str;

        }




    }
}
