namespace Cars_rental_system
{
    partial class Take_Reservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Last_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.DateTimePicker();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.Permis = new System.Windows.Forms.ComboBox();
            this.Cars = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.Couleur = new System.Windows.Forms.Label();
            this.Matricule = new System.Windows.Forms.Label();
            this.Prix = new System.Windows.Forms.Label();
            this.btn_confirme = new FontAwesome.Sharp.IconButton();
            this.btn_clear = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(755, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Take Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(280, 67);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(190, 20);
            this.Name.TabIndex = 2;
            this.Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Last_Name
            // 
            this.Last_Name.Location = new System.Drawing.Point(280, 117);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(190, 20);
            this.Last_Name.TabIndex = 4;
            this.Last_Name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name :";
            // 
            // CIN
            // 
            this.CIN.Location = new System.Drawing.Point(280, 175);
            this.CIN.Name = "CIN";
            this.CIN.Size = new System.Drawing.Size(190, 20);
            this.CIN.TabIndex = 6;
            this.CIN.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "CIN :";
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(280, 233);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(190, 20);
            this.Tel.TabIndex = 8;
            this.Tel.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tel :";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(280, 293);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(190, 20);
            this.Email.TabIndex = 10;
            this.Email.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(72, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Permis-conduire :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(72, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "From :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(72, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "To :";
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(280, 412);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(190, 20);
            this.From.TabIndex = 17;
            this.From.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(280, 469);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(190, 20);
            this.To.TabIndex = 18;
            this.To.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // Permis
            // 
            this.Permis.FormattingEnabled = true;
            this.Permis.Items.AddRange(new object[] {
            "AM",
            "B",
            "A",
            "C-D",
            "E"});
            this.Permis.Location = new System.Drawing.Point(280, 351);
            this.Permis.Name = "Permis";
            this.Permis.Size = new System.Drawing.Size(190, 21);
            this.Permis.TabIndex = 21;
            this.Permis.Text = "B";
            // 
            // Cars
            // 
            this.Cars.FormattingEnabled = true;
            this.Cars.Location = new System.Drawing.Point(280, 532);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(190, 21);
            this.Cars.TabIndex = 23;
            this.Cars.SelectedIndexChanged += new System.EventHandler(this.Cars_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(72, 529);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Car :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(594, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 22);
            this.label11.TabIndex = 24;
            this.label11.Text = "Type :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(594, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 22);
            this.label12.TabIndex = 24;
            this.label12.Text = "Model :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(594, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 22);
            this.label13.TabIndex = 24;
            this.label13.Text = "Couleur :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(594, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 22);
            this.label14.TabIndex = 25;
            this.label14.Text = "Matricule :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(594, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 22);
            this.label15.TabIndex = 26;
            this.label15.Text = "Prix :";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Type.ForeColor = System.Drawing.Color.LimeGreen;
            this.Type.Location = new System.Drawing.Point(698, 64);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(17, 22);
            this.Type.TabIndex = 27;
            this.Type.Text = "-";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Model.ForeColor = System.Drawing.Color.LimeGreen;
            this.Model.Location = new System.Drawing.Point(698, 114);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(17, 22);
            this.Model.TabIndex = 28;
            this.Model.Text = "-";
            // 
            // Couleur
            // 
            this.Couleur.AutoSize = true;
            this.Couleur.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Couleur.ForeColor = System.Drawing.Color.LimeGreen;
            this.Couleur.Location = new System.Drawing.Point(698, 172);
            this.Couleur.Name = "Couleur";
            this.Couleur.Size = new System.Drawing.Size(17, 22);
            this.Couleur.TabIndex = 29;
            this.Couleur.Text = "-";
            // 
            // Matricule
            // 
            this.Matricule.AutoSize = true;
            this.Matricule.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Matricule.ForeColor = System.Drawing.Color.LimeGreen;
            this.Matricule.Location = new System.Drawing.Point(698, 231);
            this.Matricule.Name = "Matricule";
            this.Matricule.Size = new System.Drawing.Size(17, 22);
            this.Matricule.TabIndex = 30;
            this.Matricule.Text = "-";
            // 
            // Prix
            // 
            this.Prix.AutoSize = true;
            this.Prix.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Prix.ForeColor = System.Drawing.Color.LimeGreen;
            this.Prix.Location = new System.Drawing.Point(698, 290);
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(17, 22);
            this.Prix.TabIndex = 31;
            this.Prix.Text = "-";
            // 
            // btn_confirme
            // 
            this.btn_confirme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btn_confirme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirme.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirme.ForeColor = System.Drawing.Color.White;
            this.btn_confirme.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btn_confirme.IconColor = System.Drawing.Color.White;
            this.btn_confirme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_confirme.IconSize = 35;
            this.btn_confirme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirme.Location = new System.Drawing.Point(598, 412);
            this.btn_confirme.Name = "btn_confirme";
            this.btn_confirme.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_confirme.Size = new System.Drawing.Size(227, 50);
            this.btn_confirme.TabIndex = 47;
            this.btn_confirme.Tag = "Dashboard";
            this.btn_confirme.Text = "     Confirme Reservation";
            this.btn_confirme.UseVisualStyleBackColor = true;
            this.btn_confirme.Click += new System.EventHandler(this.btn_confirme_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_clear.IconColor = System.Drawing.Color.White;
            this.btn_clear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_clear.IconSize = 35;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(598, 501);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_clear.Size = new System.Drawing.Size(227, 50);
            this.btn_clear.TabIndex = 48;
            this.btn_clear.Tag = "Dashboard";
            this.btn_clear.Text = "     Clear Informations";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Take_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(915, 625);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_confirme);
            this.Controls.Add(this.Prix);
            this.Controls.Add(this.Matricule);
            this.Controls.Add(this.Couleur);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Cars);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Permis);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "Take_Reservation";
            //this.Text = "Take_Reservation";
            this.Load += new System.EventHandler(this.Take_Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Last_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker From;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.ComboBox Permis;
        private System.Windows.Forms.ComboBox Cars;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Couleur;
        private System.Windows.Forms.Label Matricule;
        private System.Windows.Forms.Label Prix;
        private FontAwesome.Sharp.IconButton btn_confirme;
        private FontAwesome.Sharp.IconButton btn_clear;
    }
}