namespace LibraryApp
{
    partial class FormCatalog
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
            this.dgv_mainview = new System.Windows.Forms.DataGridView();
            this.lblc1 = new System.Windows.Forms.Label();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.lblc2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_author = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_year = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbox_unknown = new System.Windows.Forms.CheckBox();
            this.cbox_borrow = new System.Windows.Forms.CheckBox();
            this.cbox_avail = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mainview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_mainview
            // 
            this.dgv_mainview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mainview.Location = new System.Drawing.Point(19, 61);
            this.dgv_mainview.Name = "dgv_mainview";
            this.dgv_mainview.RowTemplate.Height = 21;
            this.dgv_mainview.Size = new System.Drawing.Size(464, 373);
            this.dgv_mainview.TabIndex = 0;
            // 
            // lblc1
            // 
            this.lblc1.AutoSize = true;
            this.lblc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc1.Location = new System.Drawing.Point(12, 9);
            this.lblc1.Name = "lblc1";
            this.lblc1.Size = new System.Drawing.Size(135, 37);
            this.lblc1.TabIndex = 2;
            this.lblc1.Text = "Catalog";
            // 
            // tbox_name
            // 
            this.tbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_name.Location = new System.Drawing.Point(525, 93);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(263, 26);
            this.tbox_name.TabIndex = 3;
            this.tbox_name.TextChanged += new System.EventHandler(this.tbox_name_TextChanged);
            // 
            // lblc2
            // 
            this.lblc2.AutoSize = true;
            this.lblc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc2.Location = new System.Drawing.Point(521, 70);
            this.lblc2.Name = "lblc2";
            this.lblc2.Size = new System.Drawing.Size(147, 20);
            this.lblc2.TabIndex = 4;
            this.lblc2.Text = "Search Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Author";
            // 
            // tbox_author
            // 
            this.tbox_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_author.Location = new System.Drawing.Point(526, 165);
            this.tbox_author.Name = "tbox_author";
            this.tbox_author.Size = new System.Drawing.Size(263, 26);
            this.tbox_author.TabIndex = 5;
            this.tbox_author.TextChanged += new System.EventHandler(this.tbox_author_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search Year";
            // 
            // tbox_year
            // 
            this.tbox_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_year.Location = new System.Drawing.Point(526, 237);
            this.tbox_year.Name = "tbox_year";
            this.tbox_year.Size = new System.Drawing.Size(263, 26);
            this.tbox_year.TabIndex = 7;
            this.tbox_year.TextChanged += new System.EventHandler(this.tbox_year_TextChanged);
            this.tbox_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_year_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(794, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(795, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(795, 237);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbox_unknown);
            this.panel1.Controls.Add(this.cbox_borrow);
            this.panel1.Controls.Add(this.cbox_avail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(525, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 136);
            this.panel1.TabIndex = 14;
            // 
            // cbox_unknown
            // 
            this.cbox_unknown.AutoSize = true;
            this.cbox_unknown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_unknown.Location = new System.Drawing.Point(14, 99);
            this.cbox_unknown.Name = "cbox_unknown";
            this.cbox_unknown.Size = new System.Drawing.Size(95, 24);
            this.cbox_unknown.TabIndex = 18;
            this.cbox_unknown.Text = "Unknown";
            this.cbox_unknown.UseVisualStyleBackColor = true;
            this.cbox_unknown.CheckedChanged += new System.EventHandler(this.cbox_unknown_CheckedChanged);
            // 
            // cbox_borrow
            // 
            this.cbox_borrow.AutoSize = true;
            this.cbox_borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_borrow.Location = new System.Drawing.Point(14, 69);
            this.cbox_borrow.Name = "cbox_borrow";
            this.cbox_borrow.Size = new System.Drawing.Size(96, 24);
            this.cbox_borrow.TabIndex = 17;
            this.cbox_borrow.Text = "Borrowed";
            this.cbox_borrow.UseVisualStyleBackColor = true;
            this.cbox_borrow.CheckedChanged += new System.EventHandler(this.cbox_borrow_CheckedChanged);
            // 
            // cbox_avail
            // 
            this.cbox_avail.AutoSize = true;
            this.cbox_avail.Checked = true;
            this.cbox_avail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbox_avail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_avail.Location = new System.Drawing.Point(14, 39);
            this.cbox_avail.Name = "cbox_avail";
            this.cbox_avail.Size = new System.Drawing.Size(91, 24);
            this.cbox_avail.TabIndex = 16;
            this.cbox_avail.Text = "Available";
            this.cbox_avail.UseVisualStyleBackColor = true;
            this.cbox_avail.CheckStateChanged += new System.EventHandler(this.cbox_avail_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Filter Book Availability";
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(787, 12);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 34);
            this.btn_return.TabIndex = 15;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(874, 463);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_author);
            this.Controls.Add(this.lblc2);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.lblc1);
            this.Controls.Add(this.dgv_mainview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCatalog";
            this.Text = "FormCatalog";
            this.Load += new System.EventHandler(this.FormCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mainview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_mainview;
        private System.Windows.Forms.Label lblc1;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.Label lblc2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_author;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_year;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbox_unknown;
        private System.Windows.Forms.CheckBox cbox_borrow;
        private System.Windows.Forms.CheckBox cbox_avail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_return;
    }
}