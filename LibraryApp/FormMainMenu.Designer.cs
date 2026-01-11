namespace LibraryApp
{
    partial class FormMainMenu
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
            this.lblc2 = new System.Windows.Forms.Label();
            this.lblc1 = new System.Windows.Forms.Label();
            this.pbox_catalog = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbox_manage = new System.Windows.Forms.Label();
            this.pbox_manage_catalog = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbox_member = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbox_loan = new System.Windows.Forms.Label();
            this.pbox_user = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_view = new System.Windows.Forms.Panel();
            this.pnl_lease = new System.Windows.Forms.Panel();
            this.pnl_user = new System.Windows.Forms.Panel();
            this.pnl_catalog = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_catalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_manage_catalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_member)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_user)).BeginInit();
            this.pnl_view.SuspendLayout();
            this.pnl_lease.SuspendLayout();
            this.pnl_user.SuspendLayout();
            this.pnl_catalog.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblc2
            // 
            this.lblc2.AutoSize = true;
            this.lblc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc2.Location = new System.Drawing.Point(93, 32);
            this.lblc2.Name = "lblc2";
            this.lblc2.Size = new System.Drawing.Size(177, 20);
            this.lblc2.TabIndex = 2;
            this.lblc2.Text = "See the library\'s catalog";
            // 
            // lblc1
            // 
            this.lblc1.AutoSize = true;
            this.lblc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc1.Location = new System.Drawing.Point(92, 3);
            this.lblc1.Name = "lblc1";
            this.lblc1.Size = new System.Drawing.Size(167, 29);
            this.lblc1.TabIndex = 1;
            this.lblc1.Text = "View Catalog";
            // 
            // pbox_catalog
            // 
            this.pbox_catalog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox_catalog.Image = global::LibraryApp.Properties.Resources.img_catalog;
            this.pbox_catalog.Location = new System.Drawing.Point(3, 3);
            this.pbox_catalog.Name = "pbox_catalog";
            this.pbox_catalog.Size = new System.Drawing.Size(83, 86);
            this.pbox_catalog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_catalog.TabIndex = 1;
            this.pbox_catalog.TabStop = false;
            this.pbox_catalog.Click += new System.EventHandler(this.pbox_catalog_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add, Remove, or Edit your Catalog";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pbox_manage
            // 
            this.pbox_manage.AutoSize = true;
            this.pbox_manage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbox_manage.Location = new System.Drawing.Point(95, 3);
            this.pbox_manage.Name = "pbox_manage";
            this.pbox_manage.Size = new System.Drawing.Size(203, 29);
            this.pbox_manage.TabIndex = 1;
            this.pbox_manage.Text = "Manage Catalog";
            this.pbox_manage.Click += new System.EventHandler(this.label4_Click);
            // 
            // pbox_manage_catalog
            // 
            this.pbox_manage_catalog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox_manage_catalog.Image = global::LibraryApp.Properties.Resources.img_inventory;
            this.pbox_manage_catalog.Location = new System.Drawing.Point(3, 3);
            this.pbox_manage_catalog.Name = "pbox_manage_catalog";
            this.pbox_manage_catalog.Size = new System.Drawing.Size(83, 86);
            this.pbox_manage_catalog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_manage_catalog.TabIndex = 1;
            this.pbox_manage_catalog.TabStop = false;
            this.pbox_manage_catalog.Click += new System.EventHandler(this.pboxm1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Manage Lease";
            // 
            // pbox_member
            // 
            this.pbox_member.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox_member.Image = global::LibraryApp.Properties.Resources.img_user;
            this.pbox_member.Location = new System.Drawing.Point(3, 3);
            this.pbox_member.Name = "pbox_member";
            this.pbox_member.Size = new System.Drawing.Size(83, 86);
            this.pbox_member.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_member.TabIndex = 1;
            this.pbox_member.TabStop = false;
            this.pbox_member.Click += new System.EventHandler(this.pbox_member_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Add, Edit, or Remove Users";
            // 
            // pbox_loan
            // 
            this.pbox_loan.AutoSize = true;
            this.pbox_loan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbox_loan.Location = new System.Drawing.Point(92, 3);
            this.pbox_loan.Name = "pbox_loan";
            this.pbox_loan.Size = new System.Drawing.Size(168, 29);
            this.pbox_loan.TabIndex = 1;
            this.pbox_loan.Text = "Manage User";
            // 
            // pbox_user
            // 
            this.pbox_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox_user.Image = global::LibraryApp.Properties.Resources.img_loan;
            this.pbox_user.Location = new System.Drawing.Point(3, 3);
            this.pbox_user.Name = "pbox_user";
            this.pbox_user.Size = new System.Drawing.Size(83, 86);
            this.pbox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_user.TabIndex = 1;
            this.pbox_user.TabStop = false;
            this.pbox_user.Click += new System.EventHandler(this.pbox_user_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(749, 374);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(102, 37);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Manage Loaning and Returning Books";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Library App :D";
            // 
            // pnl_view
            // 
            this.pnl_view.Controls.Add(this.pbox_catalog);
            this.pnl_view.Controls.Add(this.lblc1);
            this.pnl_view.Controls.Add(this.lblc2);
            this.pnl_view.Location = new System.Drawing.Point(47, 70);
            this.pnl_view.Name = "pnl_view";
            this.pnl_view.Size = new System.Drawing.Size(399, 116);
            this.pnl_view.TabIndex = 24;
            // 
            // pnl_lease
            // 
            this.pnl_lease.Controls.Add(this.pbox_member);
            this.pnl_lease.Controls.Add(this.label5);
            this.pnl_lease.Controls.Add(this.label6);
            this.pnl_lease.Location = new System.Drawing.Point(47, 192);
            this.pnl_lease.Name = "pnl_lease";
            this.pnl_lease.Size = new System.Drawing.Size(399, 107);
            this.pnl_lease.TabIndex = 25;
            this.pnl_lease.Visible = false;
            // 
            // pnl_user
            // 
            this.pnl_user.Controls.Add(this.pbox_user);
            this.pnl_user.Controls.Add(this.pbox_loan);
            this.pnl_user.Controls.Add(this.label7);
            this.pnl_user.Location = new System.Drawing.Point(452, 70);
            this.pnl_user.Name = "pnl_user";
            this.pnl_user.Size = new System.Drawing.Size(399, 116);
            this.pnl_user.TabIndex = 26;
            this.pnl_user.Visible = false;
            // 
            // pnl_catalog
            // 
            this.pnl_catalog.Controls.Add(this.pbox_manage_catalog);
            this.pnl_catalog.Controls.Add(this.pbox_manage);
            this.pnl_catalog.Controls.Add(this.label3);
            this.pnl_catalog.Location = new System.Drawing.Point(47, 306);
            this.pnl_catalog.Name = "pnl_catalog";
            this.pnl_catalog.Size = new System.Drawing.Size(399, 105);
            this.pnl_catalog.TabIndex = 26;
            this.pnl_catalog.Visible = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(874, 463);
            this.Controls.Add(this.pnl_user);
            this.Controls.Add(this.pnl_catalog);
            this.Controls.Add(this.pnl_lease);
            this.Controls.Add(this.pnl_view);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_catalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_manage_catalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_member)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_user)).EndInit();
            this.pnl_view.ResumeLayout(false);
            this.pnl_view.PerformLayout();
            this.pnl_lease.ResumeLayout(false);
            this.pnl_lease.PerformLayout();
            this.pnl_user.ResumeLayout(false);
            this.pnl_user.PerformLayout();
            this.pnl_catalog.ResumeLayout(false);
            this.pnl_catalog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblc2;
        private System.Windows.Forms.Label lblc1;
        private System.Windows.Forms.PictureBox pbox_catalog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pbox_manage;
        private System.Windows.Forms.PictureBox pbox_manage_catalog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbox_member;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label pbox_loan;
        private System.Windows.Forms.PictureBox pbox_user;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_view;
        private System.Windows.Forms.Panel pnl_lease;
        private System.Windows.Forms.Panel pnl_user;
        private System.Windows.Forms.Panel pnl_catalog;
    }
}