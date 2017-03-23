using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UniversityPart1
{
    public partial class RecrutmentForm : Form
    {

        //-------------------------------------------
        public string conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=University; Integrated Security=True;";
        //

        public string StFname, StLname, StLang, StSpec;  //
        //local variables for sql command
        public string StAdress, StPhoneNumber;           //


        public string[] SpecStr = new string[20];   //
        //combo-box's data source
        public string[] LangStr = { "PL", "ENG" };  //

  

       




        //-------------------------------------------
        public RecrutmentForm()
        {
            InitializeComponent();

            SpecialisationCOmboBox1.DataSource = ExecuteSpecialisationList.ExSpList(SpecStr);
            LangComboBox1.DataSource = LangStr;

    }

   
      

        private void AddStudentButton_Click(object sender, EventArgs e)
        {

            //-------------------------------------

            errorLFN.Visible = false;
            errorLSP.Visible = false;
                                                    //hiding error-labels
            errorLL.Visible  = false;
            errorLLN.Visible = false;

            //-------------------------------------

           



            //-------------------------------------

            if (FirstNameTB.Text == "" )
            {
                errorLFN.Text = "Empty";
                errorLFN.Visible = true;   
            }
                                                                            //check data for empty fields or incorrect symbols
            else if (!CheckFormat.ChFormat(FirstNameTB.Text))
            {
                errorLFN.Text = "Incorrect";
                errorLFN.Visible = true;
            }

            else if (CheckFormat.ChFormat(FirstNameTB.Text))
            {
                StFname = FirstNameTB.Text;
            }

            //-------------------------------------

            if (LastNameTB.Text == "")
            {
                errorLLN.Text = "Empty";
                errorLLN.Visible = true;
            }

            else if (!CheckFormat.ChFormat(LastNameTB.Text))
            {
                errorLLN.Text = "Incorrect";
                errorLLN.Visible = true;
            }
                                                                   //check data for empty fields or incorrect symbols

            else if (CheckFormat.ChFormat(LastNameTB.Text))
            {
                StLname = LastNameTB.Text;
            }

            //-------------------------------------

            if (AdressTextBox.Text != "")
            {
                 
                 StAdress =  AdressTextBox.Text;
            }
                                                        //sets default data for adress column if field is empty
            else
            {
                StAdress = "unknown";
            }
           

            //-------------------------------------

            if (PhoneTextBox.Text != "")
            {
                
                StPhoneNumber =  PhoneTextBox.Text.ToString();
            }
                                                            //sets default data for phone number column if field is empty
            else
            {
                StPhoneNumber = "Unknown";
            }
           
            //-------------------------------------

            if (LangComboBox1.Text == "")
            {
                errorLL.Visible = true;
            }

            else
            {
                StLang = LangComboBox1.Text;
            }

            //-------------------------------------

            if (SpecialisationCOmboBox1.Text == "")
            {
                errorLSP.Visible = true;
            }

            else
            {
                StSpec = SpecialisationCOmboBox1.Text;
            }

            //--------------------------------------------------------------------------


            if (

                FirstNameTB.Text == "" 
                || LastNameTB.Text == ""  
                || SpecialisationCOmboBox1.Text == "" 
                || LangComboBox1.Text == "" 
                || !CheckFormat.ChFormat(LastNameTB.Text) 
                || !CheckFormat.ChFormat(FirstNameTB.Text)

                )
            {

                MessageBox.Show("error");

            }

            //--------------------------------------------------------------------------

            else

            {
                try
                //--------------------------------------------------------------------------
                {
                    using (SqlConnection connection = new SqlConnection(conStr))

                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand(

                            "INSERT INTO Students" +
                            "(FirstName, LastName, SpecialisationName, Language, Adress, PhoneNumber)" +
                            "values ('" + StFname + "', '" + StLname + "', '" + StSpec + "', '" + StLang + "', '" + StAdress + "', '" + StPhoneNumber + "')", connection);

                        cmd.ExecuteNonQuery();

                    }
                    //--------------------------------------------------------------------------
                    MessageBox.Show("done");

                }
                //--------------------------------------------------------------------------
                catch (Exception)

                {

                    MessageBox.Show("Error");

                }
             
               
            }

            //--------------------------------------------------------------------------

        }

        //--------------------------------------------------------------------------

     



    }
}
