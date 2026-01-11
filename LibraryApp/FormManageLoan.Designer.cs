namespace LibraryApp
{
    partial class FormManage
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
            this.dgv_member = new System.Windows.Forms.DataGridView();
            this.dgv_book = new System.Windows.Forms.DataGridView();
            this.lblc1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_title = new System.Windows.Forms.TextBox();
            this.btn_loan = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_history = new System.Windows.Forms.DataGridView();
            this.btn_clear_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_member)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_member
            // 
            this.dgv_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_member.Location = new System.Drawing.Point(39, 123);
            this.dgv_member.Name = "dgv_member";
            this.dgv_member.ReadOnly = true;
            this.dgv_member.RowTemplate.Height = 21;
            this.dgv_member.Size = new System.Drawing.Size(260, 316);
            this.dgv_member.TabIndex = 0;
            this.dgv_member.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_member_CellMouseClick);
            // 
            // dgv_book
            // 
            this.dgv_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_book.Location = new System.Drawing.Point(325, 123);
            this.dgv_book.Name = "dgv_book";
            this.dgv_book.ReadOnly = true;
            this.dgv_book.RowTemplate.Height = 21;
            this.dgv_book.Size = new System.Drawing.Size(335, 130);
            this.dgv_book.TabIndex = 1;
            this.dgv_book.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_book_CellMouseClick);
            // 
            // lblc1
            // 
            this.lblc1.AutoSize = true;
            this.lblc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc1.Location = new System.Drawing.Point(12, 9);
            this.lblc1.Name = "lblc1";
            this.lblc1.Size = new System.Drawing.Size(271, 37);
            this.lblc1.TabIndex = 3;
            this.lblc1.Text = "Loan and Return";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search Member";
            // 
            // tbox_name
            // 
            this.tbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_name.Location = new System.Drawing.Point(39, 91);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(260, 26);
            this.tbox_name.TabIndex = 14;
            this.tbox_name.TextChanged += new System.EventHandler(this.tbox_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search Book";
            // 
            // tbox_title
            // 
            this.tbox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_title.Location = new System.Drawing.Point(325, 91);
            this.tbox_title.Name = "tbox_title";
            this.tbox_title.Size = new System.Drawing.Size(335, 26);
            this.tbox_title.TabIndex = 18;
            this.tbox_title.TextChanged += new System.EventHandler(this.tbox_title_TextChanged);
            // 
            // btn_loan
            // 
            this.btn_loan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loan.Location = new System.Drawing.Point(676, 112);
            this.btn_loan.Name = "btn_loan";
            this.btn_loan.Size = new System.Drawing.Size(161, 28);
            this.btn_loan.TabIndex = 29;
            this.btn_loan.Text = "Loan Book";
            this.btn_loan.UseVisualStyleBackColor = true;
            this.btn_loan.Click += new System.EventHandler(this.btn_loan_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(787, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 34);
            this.btn_back.TabIndex = 32;
            this.btn_back.Text = "Return";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(676, 311);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(161, 28);
            this.btn_return.TabIndex = 33;
            this.btn_return.Text = "Return Book";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Lend Books";
            // 
            // dgv_history
            // 
            this.dgv_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_history.Location = new System.Drawing.Point(325, 279);
            this.dgv_history.Name = "dgv_history";
            this.dgv_history.ReadOnly = true;
            this.dgv_history.RowTemplate.Height = 21;
            this.dgv_history.Size = new System.Drawing.Size(335, 160);
            this.dgv_history.TabIndex = 35;
            this.dgv_history.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_history_CellMouseClick);
            // 
            // btn_clear_all
            // 
            this.btn_clear_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_all.Location = new System.Drawing.Point(220, 57);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(79, 28);
            this.btn_clear_all.TabIndex = 55;
            this.btn_clear_all.Text = "Clear";
            this.btn_clear_all.UseVisualStyleBackColor = true;
            this.btn_clear_all.Click += new System.EventHandler(this.btn_clear_all_Click);
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 463);
            this.Controls.Add(this.btn_clear_all);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_history);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_loan);
            this.Controls.Add(this.tbox_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.lblc1);
            this.Controls.Add(this.dgv_book);
            this.Controls.Add(this.dgv_member);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManage";
            this.Text = "FormManage";
            this.Load += new System.EventHandler(this.FormManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_member)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_member;
        private System.Windows.Forms.DataGridView dgv_book;
        private System.Windows.Forms.Label lblc1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_title;
        private System.Windows.Forms.Button btn_loan;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_history;
        private System.Windows.Forms.Button btn_clear_all;
    }
}