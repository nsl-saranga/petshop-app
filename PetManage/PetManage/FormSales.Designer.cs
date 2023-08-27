namespace PetManage
{
    partial class FormSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Heading1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heading2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heading3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heading4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heading5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heading6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SalesGoBtn = new System.Windows.Forms.Button();
            this.proIDTextBox = new System.Windows.Forms.TextBox();
            this.ShowRevTxtBox = new System.Windows.Forms.Label();
            this.closeBtn1 = new PetManage.CloseBtn();
            this.sideBar1 = new PetManage.SideBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(223, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sales";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(223)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Heading1,
            this.Heading2,
            this.Heading3,
            this.Heading4,
            this.Heading5,
            this.Heading6});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(227, 145);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(722, 386);
            this.dataGridView1.TabIndex = 21;
            // 
            // Heading1
            // 
            this.Heading1.DataPropertyName = "Sales_ID";
            this.Heading1.FillWeight = 50F;
            this.Heading1.HeaderText = "Sales ID";
            this.Heading1.MinimumWidth = 6;
            this.Heading1.Name = "Heading1";
            this.Heading1.ReadOnly = true;
            // 
            // Heading2
            // 
            this.Heading2.DataPropertyName = "Pro_ID";
            this.Heading2.FillWeight = 50F;
            this.Heading2.HeaderText = "Product ID";
            this.Heading2.MinimumWidth = 6;
            this.Heading2.Name = "Heading2";
            this.Heading2.ReadOnly = true;
            // 
            // Heading3
            // 
            this.Heading3.DataPropertyName = "Sold_Qty";
            this.Heading3.FillWeight = 50F;
            this.Heading3.HeaderText = "Sold_Qty";
            this.Heading3.MinimumWidth = 6;
            this.Heading3.Name = "Heading3";
            this.Heading3.ReadOnly = true;
            // 
            // Heading4
            // 
            this.Heading4.DataPropertyName = "Revenue";
            this.Heading4.FillWeight = 50F;
            this.Heading4.HeaderText = "Revenue";
            this.Heading4.MinimumWidth = 6;
            this.Heading4.Name = "Heading4";
            this.Heading4.ReadOnly = true;
            // 
            // Heading5
            // 
            this.Heading5.DataPropertyName = "Date";
            this.Heading5.FillWeight = 75F;
            this.Heading5.HeaderText = "Date";
            this.Heading5.MinimumWidth = 6;
            this.Heading5.Name = "Heading5";
            this.Heading5.ReadOnly = true;
            // 
            // Heading6
            // 
            this.Heading6.DataPropertyName = "Time";
            this.Heading6.FillWeight = 75F;
            this.Heading6.HeaderText = "Time";
            this.Heading6.Name = "Heading6";
            this.Heading6.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Daily",
            "Monthly"});
            this.comboBox1.Location = new System.Drawing.Point(227, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label7.Location = new System.Drawing.Point(224, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Sort By :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(392, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Pro ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Location = new System.Drawing.Point(582, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(579, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AllowDrop = true;
            this.dateTimePicker2.CustomFormat = "MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(851, 66);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker2.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(848, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Month";
            // 
            // SalesGoBtn
            // 
            this.SalesGoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.SalesGoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SalesGoBtn.FlatAppearance.BorderSize = 0;
            this.SalesGoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesGoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesGoBtn.ForeColor = System.Drawing.Color.White;
            this.SalesGoBtn.Location = new System.Drawing.Point(875, 97);
            this.SalesGoBtn.Name = "SalesGoBtn";
            this.SalesGoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SalesGoBtn.Size = new System.Drawing.Size(74, 27);
            this.SalesGoBtn.TabIndex = 43;
            this.SalesGoBtn.Text = "Go";
            this.SalesGoBtn.UseVisualStyleBackColor = false;
            this.SalesGoBtn.Click += new System.EventHandler(this.SalesGoBtn_Click);
            // 
            // proIDTextBox
            // 
            this.proIDTextBox.Location = new System.Drawing.Point(395, 66);
            this.proIDTextBox.Name = "proIDTextBox";
            this.proIDTextBox.Size = new System.Drawing.Size(142, 20);
            this.proIDTextBox.TabIndex = 44;
            // 
            // ShowRevTxtBox
            // 
            this.ShowRevTxtBox.AutoSize = true;
            this.ShowRevTxtBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRevTxtBox.Location = new System.Drawing.Point(227, 110);
            this.ShowRevTxtBox.Name = "ShowRevTxtBox";
            this.ShowRevTxtBox.Size = new System.Drawing.Size(0, 15);
            this.ShowRevTxtBox.TabIndex = 45;
            // 
            // closeBtn1
            // 
            this.closeBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn1.Location = new System.Drawing.Point(991, 0);
            this.closeBtn1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.closeBtn1.Name = "closeBtn1";
            this.closeBtn1.Size = new System.Drawing.Size(25, 25);
            this.closeBtn1.TabIndex = 46;
            // 
            // sideBar1
            // 
            this.sideBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(201, 568);
            this.sideBar1.TabIndex = 47;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1016, 568);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.closeBtn1);
            this.Controls.Add(this.ShowRevTxtBox);
            this.Controls.Add(this.proIDTextBox);
            this.Controls.Add(this.SalesGoBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\\";
            this.Load += new System.EventHandler(this.FormSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heading1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heading2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heading3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heading4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heading5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heading6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SalesGoBtn;
        private System.Windows.Forms.TextBox proIDTextBox;
        private System.Windows.Forms.Label ShowRevTxtBox;
        private CloseBtn closeBtn1;
        private SideBar sideBar1;
    }
}