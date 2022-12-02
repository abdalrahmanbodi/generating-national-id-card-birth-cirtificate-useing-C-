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
    public partial class id_cardForm : Form
    {
        public id_cardForm()
        {
            InitializeComponent();

            //GETTING VALUES FROM THE GLOBAL VARIABLES
            national_id_label.Text = id_data_form.Global_s_National_ID;
            national_id_label2.Text = id_data_form.Global_s_National_ID;
            first_name_label.Text = id_data_form.Global_s_First_name;
            last_name_label.Text = id_data_form.Global_s_Father_name;
            gender_label.Text = id_data_form.Global_s_Gender;
            religion_label.Text = id_data_form.Global_s_Religion;
            address_label.Text = id_data_form.Global_s_address;
            job_label.Text = id_data_form.Global_s_job;
            social_status_label.Text = id_data_form.Global_s_social_statuts;

        }

        private void id_cardForm_Load (object sender, EventArgs e)
        {

        }

        private void national_id_label2_Click(object sender, EventArgs e)
        {

        }
    }
}
