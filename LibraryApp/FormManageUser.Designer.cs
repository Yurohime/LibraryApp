namespace LibraryApp
{
    partial class FormManageUser
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
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.lblc1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_phone = new System.Windows.Forms.TextBox();
            this.rbtn_staff = new System.Windows.Forms.RadioButton();
            this.rbtn_member = new System.Windows.Forms.RadioButton();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_user
            // 
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(24, 106);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.RowTemplate.Height = 21;
            this.dgv_user.Size = new System.Drawing.Size(397, 336);
            this.dgv_user.TabIndex = 35;
            this.dgv_user.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_user_CellMouseClick);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(787, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 34);
            this.btn_back.TabIndex = 36;
            this.btn_back.Text = "Return";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lblc1
            // 
            this.lblc1.AutoSize = true;
            this.lblc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc1.Location = new System.Drawing.Point(17, 6);
            this.lblc1.Name = "lblc1";
            this.lblc1.Size = new System.Drawing.Size(219, 37);
            this.lblc1.TabIndex = 37;
            this.lblc1.Text = "Manage User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Search Member";
            // 
            // tbox_search
            // 
            this.tbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.Location = new System.Drawing.Point(24, 74);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(228, 26);
            this.tbox_search.TabIndex = 38;
            this.tbox_search.TextChanged += new System.EventHandler(this.tbox_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Username";
            // 
            // tbox_name
            // 
            this.tbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_name.Location = new System.Drawing.Point(453, 122);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(347, 26);
            this.tbox_name.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Password";
            // 
            // tbox_password
            // 
            this.tbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_password.Location = new System.Drawing.Point(453, 187);
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.Size = new System.Drawing.Size(347, 26);
            this.tbox_password.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Phone";
            // 
            // tbox_phone
            // 
            this.tbox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_phone.Location = new System.Drawing.Point(453, 251);
            this.tbox_phone.Name = "tbox_phone";
            this.tbox_phone.Size = new System.Drawing.Size(347, 26);
            this.tbox_phone.TabIndex = 44;
            // 
            // rbtn_staff
            // 
            this.rbtn_staff.AutoSize = true;
            this.rbtn_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_staff.Location = new System.Drawing.Point(453, 302);
            this.rbtn_staff.Name = "rbtn_staff";
            this.rbtn_staff.Size = new System.Drawing.Size(62, 24);
            this.rbtn_staff.TabIndex = 48;
            this.rbtn_staff.TabStop = true;
            this.rbtn_staff.Text = "Staff";
            this.rbtn_staff.UseVisualStyleBackColor = true;
            // 
            // rbtn_member
            // 
            this.rbtn_member.AutoSize = true;
            this.rbtn_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_member.Location = new System.Drawing.Point(453, 332);
            this.rbtn_member.Name = "rbtn_member";
            this.rbtn_member.Size = new System.Drawing.Size(85, 24);
            this.rbtn_member.TabIndex = 49;
            this.rbtn_member.TabStop = true;
            this.rbtn_member.Text = "Member";
            this.rbtn_member.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(453, 382);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 27);
            this.btn_add.TabIndex = 50;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(534, 382);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 27);
            this.btn_edit.TabIndex = 51;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(453, 415);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(94, 27);
            this.btn_remove.TabIndex = 52;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(258, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 53;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 463);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.rbtn_member);
            this.Controls.Add(this.rbtn_staff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbox_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_search);
            this.Controls.Add(this.lblc1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManageUser";
            this.Text = "FormManageUser";
            this.Load += new System.EventHandler(this.FormManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lblc1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_phone;
        private System.Windows.Forms.RadioButton rbtn_staff;
        private System.Windows.Forms.RadioButton rbtn_member;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button button4;
    }
}