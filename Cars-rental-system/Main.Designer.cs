namespace Cars_rental_system
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mother_Panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_take_res = new FontAwesome.Sharp.IconButton();
            this.btn_reservation = new FontAwesome.Sharp.IconButton();
            this.btn_client = new FontAwesome.Sharp.IconButton();
            this.btn_cars_management = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Mother_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.btn_cars_management);
            this.panel1.Controls.Add(this.btn_client);
            this.panel1.Controls.Add(this.btn_reservation);
            this.panel1.Controls.Add(this.btn_take_res);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 625);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 185);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Cars_rental_system.Properties.Resources.hatchback;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(62, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Mother_Panel
            // 
            this.Mother_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.Mother_Panel.Controls.Add(this.pictureBox2);
            this.Mother_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Mother_Panel.Location = new System.Drawing.Point(258, 0);
            this.Mother_Panel.Name = "Mother_Panel";
            this.Mother_Panel.Size = new System.Drawing.Size(915, 625);
            this.Mother_Panel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Cars_rental_system.Properties.Resources.hatchback;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(255, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 245);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_take_res
            // 
            this.btn_take_res.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_take_res.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_take_res.FlatAppearance.BorderSize = 0;
            this.btn_take_res.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btn_take_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_take_res.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_take_res.ForeColor = System.Drawing.Color.White;
            this.btn_take_res.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.btn_take_res.IconColor = System.Drawing.Color.White;
            this.btn_take_res.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_take_res.IconSize = 35;
            this.btn_take_res.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_take_res.Location = new System.Drawing.Point(0, 185);
            this.btn_take_res.Name = "btn_take_res";
            this.btn_take_res.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_take_res.Size = new System.Drawing.Size(260, 41);
            this.btn_take_res.TabIndex = 5;
            this.btn_take_res.Tag = "Dashboard";
            this.btn_take_res.Text = "     Take Reservation";
            this.btn_take_res.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_take_res.UseVisualStyleBackColor = true;
            this.btn_take_res.Click += new System.EventHandler(this.btn_take_res_Click);
            // 
            // btn_reservation
            // 
            this.btn_reservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reservation.FlatAppearance.BorderSize = 0;
            this.btn_reservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btn_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservation.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservation.ForeColor = System.Drawing.Color.White;
            this.btn_reservation.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btn_reservation.IconColor = System.Drawing.Color.White;
            this.btn_reservation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_reservation.IconSize = 35;
            this.btn_reservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reservation.Location = new System.Drawing.Point(0, 226);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_reservation.Size = new System.Drawing.Size(260, 41);
            this.btn_reservation.TabIndex = 6;
            this.btn_reservation.Tag = "Dashboard";
            this.btn_reservation.Text = "     Reservation List";
            this.btn_reservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reservation.UseVisualStyleBackColor = true;
            this.btn_reservation.Click += new System.EventHandler(this.btn_reservation_Click_1);
            // 
            // btn_client
            // 
            this.btn_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_client.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_client.FlatAppearance.BorderSize = 0;
            this.btn_client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client.ForeColor = System.Drawing.Color.White;
            this.btn_client.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_client.IconColor = System.Drawing.Color.White;
            this.btn_client.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_client.IconSize = 35;
            this.btn_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_client.Location = new System.Drawing.Point(0, 267);
            this.btn_client.Name = "btn_client";
            this.btn_client.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_client.Size = new System.Drawing.Size(260, 41);
            this.btn_client.TabIndex = 7;
            this.btn_client.Tag = "Dashboard";
            this.btn_client.Text = "     Clients Management";
            this.btn_client.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // btn_cars_management
            // 
            this.btn_cars_management.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cars_management.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cars_management.FlatAppearance.BorderSize = 0;
            this.btn_cars_management.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btn_cars_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cars_management.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cars_management.ForeColor = System.Drawing.Color.White;
            this.btn_cars_management.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.btn_cars_management.IconColor = System.Drawing.Color.White;
            this.btn_cars_management.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cars_management.IconSize = 35;
            this.btn_cars_management.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cars_management.Location = new System.Drawing.Point(0, 308);
            this.btn_cars_management.Name = "btn_cars_management";
            this.btn_cars_management.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_cars_management.Size = new System.Drawing.Size(260, 41);
            this.btn_cars_management.TabIndex = 8;
            this.btn_cars_management.Tag = "Dashboard";
            this.btn_cars_management.Text = "     Cars Managment";
            this.btn_cars_management.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cars_management.UseVisualStyleBackColor = true;
            this.btn_cars_management.Click += new System.EventHandler(this.btn_cars_management_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 625);
            this.Controls.Add(this.Mother_Panel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Cars rental system";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Mother_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Mother_Panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btn_cars_management;
        private FontAwesome.Sharp.IconButton btn_client;
        private FontAwesome.Sharp.IconButton btn_reservation;
        private FontAwesome.Sharp.IconButton btn_take_res;
    }
}

