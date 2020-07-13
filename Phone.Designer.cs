namespace TelephoneDiary
{
    partial class Phone
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
            this.bttNew = new System.Windows.Forms.Button();
            this.bttInsert = new System.Windows.Forms.Button();
            this.tBoxFirstName = new System.Windows.Forms.TextBox();
            this.tBoxLastName = new System.Windows.Forms.TextBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.tBoxMobile = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comBoxCategory = new System.Windows.Forms.ComboBox();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comBoxSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttNew
            // 
            this.bttNew.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNew.Location = new System.Drawing.Point(445, 27);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(135, 43);
            this.bttNew.TabIndex = 6;
            this.bttNew.Text = "NEW";
            this.bttNew.UseVisualStyleBackColor = true;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // bttInsert
            // 
            this.bttInsert.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttInsert.Location = new System.Drawing.Point(445, 77);
            this.bttInsert.Name = "bttInsert";
            this.bttInsert.Size = new System.Drawing.Size(135, 43);
            this.bttInsert.TabIndex = 7;
            this.bttInsert.Text = "INSERT";
            this.bttInsert.UseVisualStyleBackColor = true;
            this.bttInsert.Click += new System.EventHandler(this.bttInsert_Click);
            // 
            // tBoxFirstName
            // 
            this.tBoxFirstName.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxFirstName.Location = new System.Drawing.Point(163, 27);
            this.tBoxFirstName.Name = "tBoxFirstName";
            this.tBoxFirstName.Size = new System.Drawing.Size(223, 31);
            this.tBoxFirstName.TabIndex = 0;
            // 
            // tBoxLastName
            // 
            this.tBoxLastName.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxLastName.Location = new System.Drawing.Point(163, 68);
            this.tBoxLastName.Name = "tBoxLastName";
            this.tBoxLastName.Size = new System.Drawing.Size(223, 31);
            this.tBoxLastName.TabIndex = 1;
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxEmail.Location = new System.Drawing.Point(163, 109);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(223, 31);
            this.tBoxEmail.TabIndex = 3;
            // 
            // tBoxMobile
            // 
            this.tBoxMobile.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxMobile.Location = new System.Drawing.Point(163, 150);
            this.tBoxMobile.Name = "tBoxMobile";
            this.tBoxMobile.Size = new System.Drawing.Size(223, 31);
            this.tBoxMobile.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFirst,
            this.ColLast,
            this.ColMobile,
            this.ColEmail,
            this.ColCategory});
            this.dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 339);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ColFirst
            // 
            this.ColFirst.HeaderText = "First Name";
            this.ColFirst.Name = "ColFirst";
            this.ColFirst.Width = 130;
            // 
            // ColLast
            // 
            this.ColLast.HeaderText = "Last Name";
            this.ColLast.Name = "ColLast";
            this.ColLast.Width = 130;
            // 
            // ColMobile
            // 
            this.ColMobile.HeaderText = "Mobile";
            this.ColMobile.Name = "ColMobile";
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Width = 220;
            // 
            // ColCategory
            // 
            this.ColCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCategory.HeaderText = "Category";
            this.ColCategory.Name = "ColCategory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 9;
            this.label2.Tag = "";
            this.label2.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mobile :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last Name :";
            // 
            // comBoxCategory
            // 
            this.comBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxCategory.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxCategory.FormattingEnabled = true;
            this.comBoxCategory.Items.AddRange(new object[] {
            "HOME",
            "OFFICE",
            "BUSINESS",
            "FRIENDS",
            "FAMILY"});
            this.comBoxCategory.Location = new System.Drawing.Point(163, 191);
            this.comBoxCategory.Name = "comBoxCategory";
            this.comBoxCategory.Size = new System.Drawing.Size(223, 31);
            this.comBoxCategory.TabIndex = 5;
            // 
            // bttUpdate
            // 
            this.bttUpdate.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttUpdate.Location = new System.Drawing.Point(445, 177);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(135, 43);
            this.bttUpdate.TabIndex = 19;
            this.bttUpdate.Text = "UPDATE";
            this.bttUpdate.UseVisualStyleBackColor = true;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDelete.Location = new System.Drawing.Point(445, 127);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(135, 43);
            this.bttDelete.TabIndex = 18;
            this.bttDelete.Text = "DELETE";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // tBoxSearch
            // 
            this.tBoxSearch.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSearch.Location = new System.Drawing.Point(445, 583);
            this.tBoxSearch.Name = "tBoxSearch";
            this.tBoxSearch.Size = new System.Drawing.Size(314, 31);
            this.tBoxSearch.TabIndex = 20;
            this.tBoxSearch.TextChanged += new System.EventHandler(this.tBoxSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 21;
            this.label6.Tag = "";
            this.label6.Text = "Search by :";
            // 
            // comBoxSearch
            // 
            this.comBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSearch.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxSearch.FormattingEnabled = true;
            this.comBoxSearch.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Mobile",
            "Category"});
            this.comBoxSearch.Location = new System.Drawing.Point(261, 583);
            this.comBoxSearch.Name = "comBoxSearch";
            this.comBoxSearch.Size = new System.Drawing.Size(178, 31);
            this.comBoxSearch.TabIndex = 22;
            // 
            // Phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 619);
            this.Controls.Add(this.comBoxSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBoxSearch);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.comBoxCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tBoxMobile);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.tBoxLastName);
            this.Controls.Add(this.tBoxFirstName);
            this.Controls.Add(this.bttInsert);
            this.Controls.Add(this.bttNew);
            this.Name = "Phone";
            this.Text = "My Contacts";
            this.Load += new System.EventHandler(this.Phone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Button bttInsert;
        private System.Windows.Forms.TextBox tBoxFirstName;
        private System.Windows.Forms.TextBox tBoxLastName;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.TextBox tBoxMobile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comBoxCategory;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategory;
        private System.Windows.Forms.TextBox tBoxSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comBoxSearch;
    }
}