namespace Cars_rental_system
{
    partial class Reservation_List
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
            this.cars_datagrid = new System.Windows.Forms.DataGridView();
            this.btn_remove_res = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.cars_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(764, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservation List";
            // 
            // cars_datagrid
            // 
            this.cars_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cars_datagrid.Location = new System.Drawing.Point(37, 50);
            this.cars_datagrid.Name = "cars_datagrid";
            this.cars_datagrid.ReadOnly = true;
            this.cars_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cars_datagrid.Size = new System.Drawing.Size(835, 466);
            this.cars_datagrid.TabIndex = 53;
            // 
            // btn_remove_res
            // 
            this.btn_remove_res.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove_res.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btn_remove_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_res.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_res.ForeColor = System.Drawing.Color.White;
            this.btn_remove_res.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_remove_res.IconColor = System.Drawing.Color.White;
            this.btn_remove_res.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_remove_res.IconSize = 35;
            this.btn_remove_res.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove_res.Location = new System.Drawing.Point(37, 543);
            this.btn_remove_res.Name = "btn_remove_res";
            this.btn_remove_res.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_remove_res.Size = new System.Drawing.Size(224, 50);
            this.btn_remove_res.TabIndex = 54;
            this.btn_remove_res.Tag = "Dashboard";
            this.btn_remove_res.Text = "     Remove Reservation";
            this.btn_remove_res.UseVisualStyleBackColor = true;
            this.btn_remove_res.Click += new System.EventHandler(this.btn_remove_res_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(297, 543);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(209, 50);
            this.iconButton1.TabIndex = 55;
            this.iconButton1.Tag = "Dashboard";
            this.iconButton1.Text = "     Print Reservation Bill";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Reservation_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(915, 625);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btn_remove_res);
            this.Controls.Add(this.cars_datagrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservation_List";
            this.Text = "Reservation_List";
            this.Load += new System.EventHandler(this.Reservation_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cars_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView cars_datagrid;
        private FontAwesome.Sharp.IconButton btn_remove_res;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}