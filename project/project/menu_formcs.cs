using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class menu_form : Form
    {
        public menu_form()
        {
            InitializeComponent();
        }
        //******************************
        //FUNCTION FOR BACKGROUND COLOR
        //******************************
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

        private void choice1_label_Click(object sender, EventArgs e)
        {
            this.Close();
            //Calling the choice1_Form
            choice1_Form obj = new choice1_Form();
            obj.Show();
        }

        private void choice2_label_Click(object sender, EventArgs e)
        {
            this.Close();
            //Calling id_data_form
            id_data_form obj3 = new id_data_form();
            obj3.Show();
        }

        private void title_label_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
