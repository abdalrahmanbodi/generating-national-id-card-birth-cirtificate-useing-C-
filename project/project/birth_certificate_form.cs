using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace project
{
    public partial class birth_certificate_form : Form 
    {
        public birth_certificate_form()
        {
            InitializeComponent();
        }

        private void birth_certificate_form_Load(object sender, EventArgs e)
        {
            //GETTING VALUES FROM THE GLOBAL VARIABLES
            id_label.Text = choice1_Form.Global_National_ID;
            first_name_label.Text = choice1_Form.Global_First_name;
            father_name_label.Text = choice1_Form.Global_Father_name;
            father_id_label.Text = choice1_Form.Global_Father_ID;
            mother_name_label.Text = choice1_Form.Global_Mother_name;
            mother_id_label.Text = choice1_Form.Global_Mother_ID;
            nationality_label.Text = choice1_Form.Global_Nationality;
            gender_label.Text = choice1_Form.Global_Gender;
            religion_label.Text = choice1_Form.Global_Religion;
            day_of_birth_label.Text = choice1_Form.Global_day_of_birth;
            month_of_birth_label.Text = choice1_Form.Global_month_of_birth;
            year_of_birth_label.Text = choice1_Form.Global_year_of_birth;
            place_of_birth_label.Text = choice1_Form.Global_Place_of_birth;
        }  
    }
}

