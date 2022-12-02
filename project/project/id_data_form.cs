using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace project
{
    public partial class id_data_form : Form
    {
        //CREATING GLOBAL FUNCTIONS
        public static string Global_s_National_ID = "";
        public static string Global_s_First_name = "";
        public static string Global_s_Father_name = "";
        public static string Global_s_Gender = "";
        public static string Global_s_Religion = "";
        public static string Global_s_address = "";
        public static string Global_s_job = "";
        public static string Global_s_social_statuts = "";

        public id_data_form()
        {
            InitializeComponent();
        }
        //CBACK GROUND COLOR
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

        //******************
        //SEARCH BUTTON CODE
        //******************
        private void Search_ID_button_Click(object sender, EventArgs e)
        {
            //***************************
            //READING DATA FROM THE TABLE
            //***************************
            SqlCeConnection conn = new SqlCeConnection("Data Source=C:\\Users\\Bodi\\Desktop\\project\\project\\bodi.sdf");
            //OPPENING DATA BASE
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            //***************************************
            //CHOOSING WHICH COLUMNS YOU WANT TO READ 
            //***************************************
            cmd.CommandText = "select National_ID, First_name, "
            + "Father_name, Gender, Religion"
            + " from customer where National_ID = '" //TELLING THE COMPILER WHICH TABLE TO GET DATA FROM IT(customer)
            + id_textBox.Text        //ID IS THE KEY OF EACH ROW WHICH WE SEARCH WITH
            + "'";
            //
            SqlCeDataReader sReader = cmd.ExecuteReader();
            while (sReader.Read())//WHILE HE IS READING FROM TABLE
            {
                //**************************************
                //ASSIGNING VALUES INTO GLOBAL VARIABLES 
                //**************************************
                Global_s_National_ID = sReader["National_ID"].ToString();
                Global_s_First_name = sReader["First_name"].ToString();
                Global_s_Father_name = sReader["Father_name"].ToString();
                Global_s_Gender = sReader["Gender"].ToString();
                Global_s_Religion = sReader["Religion"].ToString();

            }
            
                first_name_label.Text = Global_s_First_name;
                father_name_label.Text = Global_s_Father_name;
                gender_label.Text = Global_s_Gender;
                Religion_label.Text = Global_s_Religion;
            //closing the connection with data base
            conn.Close();
        }

        //****************
        //SAVE DATA BUTTON
        //****************
        private void save_data_button_Click(object sender, EventArgs e)
        {
            try//(exception handling)
            {
                //customer myuser = new customer();

                if (String.IsNullOrEmpty(address_textBox.Text) || String.IsNullOrEmpty(job_textBox.Text) || (String.IsNullOrEmpty(social_statuts_textBox.Text)) || string.IsNullOrEmpty(id_textBox.Text))
                {
                    MessageBox.Show("(INPUT ERROR) Please Fill all Sells.");
                }

                else
                {

                    //***************************
                    //INSERTING DATA IN THE TABLE
                    //***************************
                    SqlCeConnection con = new SqlCeConnection("Data Source=C:\\Users\\Bodi\\Desktop\\project\\project\\bodi.sdf");
                    con.Open();
                    SqlCeCommand cmmd = con.CreateCommand();
                    //CHOOSING WHICH TABLE TO INSERT IN IT THESE COLUMN TITLES
                    cmmd.CommandText = "insert into ID_Card_table ([National_ID], [First_name], "
                        + "[Father_name],[Address],[Job],[Gender], [Religion],[Social_status])"
                        //VALUES WHICH WE WILL STORE IN DATA BASE FROM THE FORM
                        + " values ( '" +
                        Global_s_National_ID
                        + "','"
                        + Global_s_First_name
                        + "','"
                        + Global_s_Father_name
                        + "','"
                        + address_textBox.Text
                        + "','"
                        + job_textBox.Text
                        + "', '"
                        + Global_s_Gender
                        + "', '"
                        + Global_s_Religion
                        + "', '"
                        + social_statuts_textBox.Text
                        + "')";
                    //****************************************
                    //
                    //****************************************
                    var o = cmmd.ExecuteNonQuery();

                    Global_s_address = address_textBox.Text;
                    Global_s_job = job_textBox.Text;
                    Global_s_social_statuts = social_statuts_textBox.Text;

                    con.Close();//CLOSING THE TABLE

                    //MESSAGE TO MAKE SURE THA DATA IS SAVED
                    MessageBox.Show("Saved");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        //PREVIEW BUTTON CODE
        private void preview_button_Click(object sender, EventArgs e)
        {
            //***********************************************
            //CALLING THE FORM WHICH WILL DISPLAY THE ID CARD
            //***********************************************
            id_cardForm ob = new id_cardForm();
            ob.Show();
        }

        private void id_data_form_Load(object sender, EventArgs e)
        {

        }

        private void return_menu_button_Click(object sender, EventArgs e)
        {
            this.Close();
            menu_form obj = new menu_form();
            obj.Show();
        }

    }
}
