namespace project
{
    partial class menu_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title_label = new System.Windows.Forms.Label();
            this.choice1_label = new System.Windows.Forms.Label();
            this.choice2_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.DarkGray;
            this.title_label.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(294, 92);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(430, 36);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Choose Service";
            this.title_label.Click += new System.EventHandler(this.title_label_Click);
            // 
            // choice1_label
            // 
            this.choice1_label.BackColor = System.Drawing.Color.Silver;
            this.choice1_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice1_label.Location = new System.Drawing.Point(339, 148);
            this.choice1_label.Name = "choice1_label";
            this.choice1_label.Size = new System.Drawing.Size(341, 44);
            this.choice1_label.TabIndex = 1;
            this.choice1_label.Text = "1-Birth Certificate";
            this.choice1_label.Click += new System.EventHandler(this.choice1_label_Click);
            // 
            // choice2_label
            // 
            this.choice2_label.BackColor = System.Drawing.Color.LightGray;
            this.choice2_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice2_label.Location = new System.Drawing.Point(340, 212);
            this.choice2_label.Name = "choice2_label";
            this.choice2_label.Size = new System.Drawing.Size(339, 44);
            this.choice2_label.TabIndex = 2;
            this.choice2_label.Text = "2-ID Card";
            this.choice2_label.Click += new System.EventHandler(this.choice2_label_Click);
            // 
            // menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 639);
            this.Controls.Add(this.choice2_label);
            this.Controls.Add(this.choice1_label);
            this.Controls.Add(this.title_label);
            this.Name = "menu_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu_formcs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label choice1_label;
        private System.Windows.Forms.Label choice2_label;
    }
}