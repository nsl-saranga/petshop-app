namespace PetManage
{
    partial class FormProductCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoryAddButton = new System.Windows.Forms.Button();
            this.proCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.proCategoryDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.categoryEditButton = new System.Windows.Forms.Button();
            this.categoryRemoveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Heading1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heading2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heading3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.proCategoryIDTextBox = new System.Windows.Forms.TextBox();
            this.closeBtn2 = new PetManage.CloseBtn();
            this.sideBar2 = new PetManage.SideBar();
            this.sideBar1 = new PetManage.SideBar();
            this.closeBtn1 = new PetManage.CloseBtn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryAddButton
            // 
            this.categoryAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.categoryAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.categoryAddButton.FlatAppearance.BorderSize = 0;
            this.categoryAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryAddButton.ForeColor = System.Drawing.Color.White;
            this.categoryAddButton.Location = new System.Drawing.Point(242, 144);
            this.categoryAddButton.Name = "categoryAddButton";
            this.categoryAddButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryAddButton.Size = new System.Drawing.Size(74, 35);
            this.categoryAddButton.TabIndex = 18;
            this.categoryAddButton.Text = "Add";
            this.categoryAddButton.UseVisualStyleBackColor = false;
            this.categoryAddButton.Click += new System.EventHandler(this.categoryAddButtpn_Click);
            // 
            // proCategoryNameTextBox
            // 
            this.proCategoryNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proCategoryNameTextBox.Location = new System.Drawing.Point(394, 95);
            this.proCategoryNameTextBox.Name = "proCategoryNameTextBox";
            this.proCategoryNameTextBox.Size = new System.Drawing.Size(243, 24);
            this.proCategoryNameTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(237, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product Category ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(391, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label5.Location = new System.Drawing.Point(661, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Description";
            // 
            // proCategoryDescriptionTextBox
            // 
            this.proCategoryDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proCategoryDescriptionTextBox.Location = new System.Drawing.Point(664, 95);
            this.proCategoryDescriptionTextBox.Name = "proCategoryDescriptionTextBox";
            this.proCategoryDescriptionTextBox.Size = new System.Drawing.Size(340, 24);
            this.proCategoryDescriptionTextBox.TabIndex = 23;
            // 
            // categoryEditButton
            // 
            this.categoryEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.categoryEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.categoryEditButton.FlatAppearance.BorderSize = 0;
            this.categoryEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryEditButton.ForeColor = System.Drawing.Color.White;
            this.categoryEditButton.Location = new System.Drawing.Point(420, 144);
            this.categoryEditButton.Name = "categoryEditButton";
            this.categoryEditButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryEditButton.Size = new System.Drawing.Size(75, 35);
            this.categoryEditButton.TabIndex = 24;
            this.categoryEditButton.Text = "Edit";
            this.categoryEditButton.UseVisualStyleBackColor = false;
            this.categoryEditButton.Click += new System.EventHandler(this.categoryEditButton_Clicked);
            // 
            // categoryRemoveButton
            // 
            this.categoryRemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.categoryRemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.categoryRemoveButton.FlatAppearance.BorderSize = 0;
            this.categoryRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryRemoveButton.ForeColor = System.Drawing.Color.White;
            this.categoryRemoveButton.Location = new System.Drawing.Point(594, 144);
            this.categoryRemoveButton.Name = "categoryRemoveButton";
            this.categoryRemoveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryRemoveButton.Size = new System.Drawing.Size(89, 35);
            this.categoryRemoveButton.TabIndex = 25;
            this.categoryRemoveButton.Text = "Remove";
            this.categoryRemoveButton.UseVisualStyleBackColor = false;
            this.categoryRemoveButton.Click += new System.EventHandler(this.categoryRemoveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(223)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Heading1,
            this.Heading2,
            this.Heading3});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(242, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(762, 347);
            this.dataGridView1.TabIndex = 26;
       
            // 
            // Heading1
            // 
            this.Heading1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Heading1.DataPropertyName = "Cat_ID";
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Heading1.DefaultCellStyle = dataGridViewCellStyle9;
            this.Heading1.FillWeight = 50F;
            this.Heading1.Frozen = true;
            this.Heading1.HeaderText = "Category ID";
            this.Heading1.Name = "Heading1";
            this.Heading1.ReadOnly = true;
            this.Heading1.Width = 103;
            // 
            // Heading2
            // 
            this.Heading2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Heading2.DataPropertyName = "Cat_Name";
            this.Heading2.Frozen = true;
            this.Heading2.HeaderText = "Category Name";
            this.Heading2.Name = "Heading2";
            this.Heading2.ReadOnly = true;
            this.Heading2.Width = 206;
            // 
            // Heading3
            // 
            this.Heading3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Heading3.DataPropertyName = "Cat_Description";
            this.Heading3.FillWeight = 200F;
            this.Heading3.Frozen = true;
            this.Heading3.HeaderText = "Category Description";
            this.Heading3.Name = "Heading3";
            this.Heading3.ReadOnly = true;
            this.Heading3.Width = 412;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(238, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
           
            // 
            // proCategoryIDTextBox
            // 
            this.proCategoryIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proCategoryIDTextBox.Location = new System.Drawing.Point(242, 95);
            this.proCategoryIDTextBox.Name = "proCategoryIDTextBox";
            this.proCategoryIDTextBox.Size = new System.Drawing.Size(117, 24);
            this.proCategoryIDTextBox.TabIndex = 13;
       
            this.proCategoryIDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.proCategoryIDTextBox_KeyDown_1);
            this.proCategoryIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.proCategoryIDTextBox_KeyPress_1);
            // 
            // closeBtn2
            // 
            this.closeBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn2.Location = new System.Drawing.Point(991, 0);
            this.closeBtn2.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.closeBtn2.Name = "closeBtn2";
            this.closeBtn2.Size = new System.Drawing.Size(25, 25);
            this.closeBtn2.TabIndex = 28;
            // 
            // sideBar2
            // 
            this.sideBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar2.Location = new System.Drawing.Point(0, 0);
            this.sideBar2.Name = "sideBar2";
            this.sideBar2.Size = new System.Drawing.Size(201, 568);
            this.sideBar2.TabIndex = 27;
            // 
            // sideBar1
            // 
            this.sideBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(201, 568);
            this.sideBar1.TabIndex = 27;
            // 
            // closeBtn1
            // 
            this.closeBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn1.Location = new System.Drawing.Point(991, 0);
            this.closeBtn1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.closeBtn1.Name = "closeBtn1";
            this.closeBtn1.Size = new System.Drawing.Size(25, 25);
            this.closeBtn1.TabIndex = 28;
            // 
            // FormProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1016, 568);
            this.Controls.Add(this.closeBtn2);
            this.Controls.Add(this.sideBar2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.categoryRemoveButton);
            this.Controls.Add(this.categoryEditButton);
            this.Controls.Add(this.proCategoryDescriptionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryAddButton);
            this.Controls.Add(this.proCategoryIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proCategoryNameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FormProductCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductCategory";
            this.Load += new System.EventHandler(this.FormProductCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button categoryAddButton;
        private System.Windows.Forms.TextBox proCategoryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox proCategoryDescriptionTextBox;
        private System.Windows.Forms.Button categoryEditButton;
        private System.Windows.Forms.Button categoryRemoveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proCategoryIDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heading1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heading2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heading3;
        private SideBar sideBar1;
        private CloseBtn closeBtn1;
        private SideBar sideBar2;
        private CloseBtn closeBtn2;
    }
}