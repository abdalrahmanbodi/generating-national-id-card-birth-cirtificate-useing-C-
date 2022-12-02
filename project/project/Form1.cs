using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Intriductin_form : Form
    {
        public Intriductin_form()
        {
            InitializeComponent();
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            
            //calling menu form
            menu_form obj = new menu_form();
            obj.Show();
        }
        //closing the form
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        
    }
}
