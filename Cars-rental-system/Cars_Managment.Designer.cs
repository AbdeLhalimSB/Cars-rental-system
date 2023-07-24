namespace Cars_rental_system
{
    partial class Cars_Managment
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
            this.cars_datagrid = new System.Windows.Forms.DataGridView();
            this.Matricule = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Couleur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Marque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Prix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add_car = new FontAwesome.Sharp.IconButton();
            this.btn_update_car = new FontAwesome.Sharp.IconButton();
            this.btn_remove_car = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.cars_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cars_datagrid
            // 
            this.cars_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cars_datagrid.Location = new System.Drawing.Point(42, 52);
            this.cars_datagrid.Name = "cars_datagrid";
            this.cars_datagrid.ReadOnly = true;
            this.cars_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cars_datagrid.Size = new System.Drawing.Size(831, 258);
            this.cars_datagrid.TabIndex = 39;
            this.cars_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cars_datagrid_CellClick);
            this.cars_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cars_datagrid_CellContentClick);
            // 
            // Matricule
            // 
            this.Matricule.Location = new System.Drawing.Point(643, 398);
            this.Matricule.Name = "Matricule";
            this.Matricule.Size = new System.Drawing.Size(190, 20);
            this.Matricule.TabIndex = 38;
            this.Matricule.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(478, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nu-Matricule :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Couleur
            // 
            this.Couleur.Location = new System.Drawing.Point(643, 338);
            this.Couleur.Name = "Couleur";
            this.Couleur.Size = new System.Drawing.Size(190, 20);
            this.Couleur.TabIndex = 36;
            this.Couleur.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(478, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "Couleur :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(222, 453);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(190, 20);
            this.Model.TabIndex = 34;
            this.Model.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Modéle";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(222, 395);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(190, 20);
            this.Type.TabIndex = 32;
            this.Type.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Type :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Marque
            // 
            this.Marque.Location = new System.Drawing.Point(222, 345);
            this.Marque.Name = "Marque";
            this.Marque.Size = new System.Drawing.Size(190, 20);
            this.Marque.TabIndex = 30;
            this.Marque.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Marque :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(756, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Cars Managment";
            // 
            // Prix
            // 
            this.Prix.Location = new System.Drawing.Point(643, 453);
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(190, 20);
            this.Prix.TabIndex = 45;
            this.Prix.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(478, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 22);
            this.label7.TabIndex = 44;
            this.label7.Text = "Prix-location";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_add_car
            // 
            this.btn_add_car.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_car.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btn_add_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_car.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_car.ForeColor = System.Drawing.Color.White;
            this.btn_add_car.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btn_add_car.IconColor = System.Drawing.Color.White;
            this.btn_add_car.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add_car.IconSize = 35;
            this.btn_add_car.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_car.Location = new System.Drawing.Point(77, 524);
            this.btn_add_car.Name = "btn_add_car";
            this.btn_add_car.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_add_car.Size = new System.Drawing.Size(209, 50);
            this.btn_add_car.TabIndex = 46;
            this.btn_add_car.Tag = "Dashboard";
            this.btn_add_car.Text = "     Add Car";
            this.btn_add_car.UseVisualStyleBackColor = true;
            this.btn_add_car.Click += new System.EventHandler(this.btn_add_car_Click);
            // 
            // btn_update_car
            // 
            this.btn_update_car.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_car.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btn_update_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_car.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_car.ForeColor = System.Drawing.Color.White;
            this.btn_update_car.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btn_update_car.IconColor = System.Drawing.Color.White;
            this.btn_update_car.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_update_car.IconSize = 35;
            this.btn_update_car.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update_car.Location = new System.Drawing.Point(343, 524);
            this.btn_update_car.Name = "btn_update_car";
            this.btn_update_car.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_update_car.Size = new System.Drawing.Size(209, 50);
            this.btn_update_car.TabIndex = 47;
            this.btn_update_car.Tag = "Dashboard";
            this.btn_update_car.Text = "     Edit Car";
            this.btn_update_car.UseVisualStyleBackColor = true;
            this.btn_update_car.Click += new System.EventHandler(this.btn_update_car_Click);
            // 
            // btn_remove_car
            // 
            this.btn_remove_car.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove_car.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btn_remove_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_car.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_car.ForeColor = System.Drawing.Color.White;
            this.btn_remove_car.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_remove_car.IconColor = System.Drawing.Color.White;
            this.btn_remove_car.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_remove_car.IconSize = 35;
            this.btn_remove_car.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove_car.Location = new System.Drawing.Point(609, 524);
            this.btn_remove_car.Name = "btn_remove_car";
            this.btn_remove_car.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_remove_car.Size = new System.Drawing.Size(209, 50);
            this.btn_remove_car.TabIndex = 48;
            this.btn_remove_car.Tag = "Dashboard";
            this.btn_remove_car.Text = "     Remove Car";
            this.btn_remove_car.UseVisualStyleBackColor = true;
            this.btn_remove_car.Click += new System.EventHandler(this.btn_remove_car_Click);
            // 
            // Cars_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(915, 625);
            this.Controls.Add(this.btn_remove_car);
            this.Controls.Add(this.btn_update_car);
            this.Controls.Add(this.btn_add_car);
            this.Controls.Add(this.Prix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cars_datagrid);
            this.Controls.Add(this.Matricule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Couleur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Marque);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cars_Managment";
            this.Text = "Cars_Managment";
            this.Load += new System.EventHandler(this.Cars_Managment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cars_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView cars_datagrid;
        private System.Windows.Forms.TextBox Matricule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Couleur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Marque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Prix;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btn_add_car;
        private FontAwesome.Sharp.IconButton btn_update_car;
        private FontAwesome.Sharp.IconButton btn_remove_car;
    }
}