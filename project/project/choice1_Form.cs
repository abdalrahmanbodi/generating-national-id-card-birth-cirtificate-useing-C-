using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//FOR DATA BASE
using System.Data.SqlClient;
using System.Data.SqlServerCe;
//FOR BACKGROUND COLOR
using System.Drawing.Drawing2D;


namespace project
{

    public partial class choice1_Form : Form
        //***************************************************************
    {   //GLOBAL VARIABLE TO ALLOW TO USE THESE VARIABLES IN OTHER FORMS
        //***************************************************************
        public static string Global_National_ID = "";
        public static string Global_First_name = "";
        public static string Global_Father_name = ""; 
        public static string Global_Father_ID = ""; 
        public static string Global_Mother_name = ""; 
        public static string Global_Mother_ID = ""; 
        public static string Global_Nationality = ""; 
        public static string Global_Gender = ""; 
        public static string Global_Religion = ""; 
        public static string Global_day_of_birth = ""; 
        public static string Global_month_of_birth = ""; 
        public static string Global_year_of_birth = "";
        public static string Global_Place_of_birth = "";
        public static string ID = "";

        public choice1_Form()
        {
            InitializeComponent();
        }

        //FUNCTION FOR BACKGROUND COLOR
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush
                       (DisplayRectangle, Color.Black, Color.DarkGray, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, DisplayRectangle);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate(); // Force repainting on resize
        }

        //************************************************
        //FUNCTION FOR THE GOVERNMENT CODE IN NATIONAL ID
        //************************************************
        public string Government()
        {
            string x = "";
            if (place_of_birth_comboBox.Text == "cairo")
            {

                x = "01";
            }
            else if (place_of_birth_comboBox.Text == "alexandria")
            {

                x = "02";
            }
            else if (place_of_birth_comboBox.Text == "portsaid")
            {

                x = "03";
            }
            else if (place_of_birth_comboBox.Text == "suez")
            {

                x = "04";
            }
            else if (place_of_birth_comboBox.Text == "damietta")
            {

                x = "11";
            }
            else if (place_of_birth_comboBox.Text == "dakahlia")
            {

                x = "12";
            }
            else if (place_of_birth_comboBox.Text == "eastern")
            {

                x = "13";
            }
            else if (place_of_birth_comboBox.Text == "qalyubia")
            {

                x = "14";
            }
            else if (place_of_birth_comboBox.Text == "kafrelsheikh")
            {

                x = "15";
            }
            else if (place_of_birth_comboBox.Text == "western")
            {

                x = "16";
            }
            else if (place_of_birth_comboBox.Text == "menoufia")
            {

                x = "17";
            }
            else if (place_of_birth_comboBox.Text == "bahera")
            {

                x = "18";
            }
            else if (place_of_birth_comboBox.Text == "ismailia")
            {

                x = "19";
            }
            else if (place_of_birth_comboBox.Text == "giza")
            {

                x = "21";
            }
            else if (place_of_birth_comboBox.Text == "banisweif")
            {

                x = "22";
            }
            else if (place_of_birth_comboBox.Text == "fayoum")
            {

                x = "23";
            }
            else if (place_of_birth_comboBox.Text == "minya")
            {

                x = "24";
            }
            else if (place_of_birth_comboBox.Text == "asyut")
            {

                x = "25";
            }
            else if (place_of_birth_comboBox.Text == "sohag")
            {

                x = "26";
            }
            else if (place_of_birth_comboBox.Text == "qena")
            {

                x = "27";
            }
            else if (place_of_birth_comboBox.Text == "aswan")
            {

                x = "28";
            }
            else if (place_of_birth_comboBox.Text == "luxor")
            {

                x = "29";
            }
            else if (place_of_birth_comboBox.Text == "redsea")
            {

                x = "31";
            }
            else if (place_of_birth_comboBox.Text == "newvalley")
            {

                x = "32";
            }
            else if (place_of_birth_comboBox.Text == "matrouh")
            {

                x = "33";
            }
            else if (place_of_birth_comboBox.Text == "northsinai")
            {

                x = "34";
            }
            else if (place_of_birth_comboBox.Text == "southsinaa")
            {

                x = "35";
            }
            else x = "88";

            return x;

        }
        //*******************************************
        //FUNCTION FOR GENDER DEGITS IN NATIONAL ID
        //*******************************************
        public string gender()
        {
            string z = " ";
            if (gender_comboBox.Text == "Male")
            {
                z = "00411";
            }
            else
            {
                z = "00321";
            }
            return z;
        }
        //******************************************
        //FUNCTION FOR YEAR DEGITS IN NATIONAL ID
        //******************************************
        public string Year_birth()
        {
            string year = year_of_birth_textBox.Text;
            string c = " ";
            if (year[0] == '1')
            {
                c = "2";
            }
            else c = "3";
            return c;
        }
        //*****************************************************************
        //FUNCTION TO CUT THE LAST TWO NUMBERS OF THE YEAR FOR NATIONAL ID
        //*****************************************************************
        public string Year_Last()
        {
            string year = year_of_birth_textBox.Text;
            string y = "";
            for (int i = 2; i <= 3; i++)//0 1 2 3
            {
                y += year[i];
            }
            return y;
        }
        //******************************************
        //FUNCTIONS FOR MONTH AND DAY IN NATINAL ID
        //******************************************
        public string Month()
        {
            string m = month_of_birth_comboBox.Text;
            return m;
        }
        public string Day()
        {
            string d = day_of_birth_comboBox.Text;
            return d;
        }
    
        //****************
        //NEXT BUTTON CODE
        //****************
        private void next_button_Click(object sender, EventArgs e)
        {
            //CONCATINATION OF NATIONAL ID PARTS
            ID = Year_birth() + Year_Last() + Month() + Day() + Government() + gender();
            
            //DEFINING AN OBJECT AND CALLING THE PARAMTARIZED CONSTRUCTOR
            customer myuser = new customer(ID,first_name_textBox.Text, father_name_textBox.Text, mother_name_textBox.Text, father_id_textBox.Text,
                mother_id_textBox.Text, nationality_textBox.Text, place_of_birth_comboBox.Text, gender_comboBox.Text, year_of_birth_textBox.Text,
                religion_comboBox.Text, day_of_birth_comboBox.Text, month_of_birth_comboBox.Text);
           
           //CHECKING IF THE USER LEAVES ANY EMPTY SELL            
            if (String.IsNullOrEmpty(myuser.First) || String.IsNullOrEmpty(myuser.Second) || (String.IsNullOrEmpty(myuser.Father)) 
                || String.IsNullOrEmpty(myuser.Mmother) || String.IsNullOrEmpty(myuser.Mother) || String.IsNullOrEmpty(myuser.National) 
                || String.IsNullOrEmpty(myuser.Place) || String.IsNullOrEmpty(myuser.Day) || String.IsNullOrEmpty(myuser.Month) 
                || String.IsNullOrEmpty(myuser.Year) || String.IsNullOrEmpty(myuser.Gender) || String.IsNullOrEmpty(myuser.Religion))
            {
                MessageBox.Show("(INPUT ERROR) Please Fill all Sells.");
            }
             //CHECKING IF THE USER ENTERED WRONG DATA INSTEAD OF NUMIRIC DATA
            else if (myuser.check_digit(year_of_birth_textBox.Text) == false)
                {
                    MessageBox.Show("(Invalid Input data for year of birth) Please Enter Numiric Data.");
                    year_of_birth_textBox.Text = string.Empty;
                    year_of_birth_textBox.Focus();                    
                }
            else if (myuser.check_digit(mother_id_textBox.Text) == false)
            {
                MessageBox.Show("(Invalid Input for mother id) Please Enter Numiric Data.");
                mother_id_textBox.Text = string.Empty;
                mother_id_textBox.Focus();
            }
            else if (myuser.check_digit(father_id_textBox.Text) == false)
            {
                MessageBox.Show("(Invalid Input for father id) Please Enter Numiric Data.");
                father_id_textBox.Text = string.Empty;
                father_id_textBox.Focus();                    
            }
            else
            {   //***********************
               //INSERT DATA IN DATA BASE
               //************************
                try//(exception handling)
                {
                    SqlCeConnection conn = new SqlCeConnection("Data Source=C:\\Users\\Bodi\\Desktop\\project\\project\\bodi.sdf");//choosing data base by it's location
                    conn.Open();//openning data base
                    SqlCeCommand cmd = conn.CreateCommand();//
                    //COLUMN TITLES TO INSERT IN
                    cmd.CommandText = "insert into customer ([National_ID], [First_name], "
                        + "[Father_name], [Father_ID], [Mother_name], [Mother_ID], [Nationality], [Gender], [Religion], [day_of_birth],[month_of_birth],[year_of_birth],[Place_of_birth])"
                        //VALUES WHICH WE WILL STORE IN DATA BASE FROM THE FORM
                        + " values ( '" +
                        ID
                        + "','"
                        + first_name_textBox.Text
                        + "','"
                        + father_name_textBox.Text
                        + "','"
                        + father_id_textBox.Text
                        + "','"
                        + mother_name_textBox.Text
                        + "','"
                        + mother_id_textBox.Text
                        + "','"
                        + nationality_textBox.Text
                        + "', '"
                        + gender_comboBox.SelectedItem
                        + "', '"
                        + religion_comboBox.SelectedItem
                        + "', '"
                        + day_of_birth_comboBox.SelectedItem
                        + "', '"
                        + month_of_birth_comboBox.SelectedItem
                        + "', '"
                        + year_of_birth_textBox.Text
                        + "', '"
                        + place_of_birth_comboBox.SelectedItem
                        + "')";
                    //*********************************************
                    var o = cmd.ExecuteNonQuery();//run the query
                    conn.Close();//CLOSING THE CONNECTION WITH DATA BASE

                    MessageBox.Show("Saved");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        //********************
        //PREVIEW BUTTON CODE
        //********************
        private void preview_button_Click(object sender, EventArgs e)
        {
            try//(exception handling)
            {
                
                //*********************************
                //READING DATA FROM DATA BASE TABLE
                //*********************************
                SqlCeConnection conn = new SqlCeConnection("Data Source=C:\\Users\\Bodi\\Desktop\\project\\project\\bodi.sdf");//choosing data base by it's location
                //OPPENING DATA BASE
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();//read query
                //***************************************
                //CHOOSING WHICH COLUMNS YOU WANT TO READ 
                //***************************************
                cmd.CommandText = "select National_ID, First_name, "
                   + "Father_name, Father_ID, Mother_name, Mother_ID, "
                   + " Nationality, Gender, Religion, day_of_birth, month_of_birth,"
                   + " year_of_birth, Place_of_birth "
                   + " from customer where National_ID = '" //TELLING THE COMPILER WHICH TABLE TO GET DATA FROM IT(customer)
                   + ID                                     //ID IS THE KEY OF EACH ROW WHICH WE SEARCH WITH
                   + "'";

                SqlCeDataReader oReader = cmd.ExecuteReader();//excute the query
                while (oReader.Read())
                {
                    //********************************************************************
                    //SETTING VALUES INTO GLOBAL VARIABLES AFTER READING IT FROM THE TABLE
                    //********************************************************************
                    Global_National_ID = oReader["National_ID"].ToString();
                    Global_First_name = oReader["First_name"].ToString();
                    Global_Father_name = oReader["Father_name"].ToString();
                    Global_Father_ID = oReader["Father_ID"].ToString();
                    Global_Mother_name = oReader["Mother_name"].ToString();
                    Global_Mother_ID = oReader["Mother_ID"].ToString();
                    Global_Nationality = oReader["Nationality"].ToString();
                    Global_Gender = oReader["Gender"].ToString();
                    Global_Religion = oReader["Religion"].ToString();
                    Global_day_of_birth = oReader["day_of_birth"].ToString();
                    Global_month_of_birth = oReader["month_of_birth"].ToString();
                    Global_year_of_birth = oReader["year_of_birth"].ToString();
                    Global_Place_of_birth = oReader["Place_of_birth"].ToString();
                }

                //CLOSING DATA BASE
                conn.Close();
           }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            //********************************************************
            //CALLING THE FORM WHICH WILL DISPLAY THE BIRTH CETIFICATE
            //********************************************************
            birth_certificate_form myobj = new birth_certificate_form();
            myobj.Show();
            
        }
        //CANCEL BUTTON TO CLOSE THE FORM
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            menu_form obj = new menu_form();
            obj.Show();
            
        }

        private void choice1_Form_Load(object sender, EventArgs e)
        {

        }

    }
}
