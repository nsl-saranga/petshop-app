namespace PetManage
{
    partial class FormSellers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SellerDataGridView = new System.Windows.Forms.DataGridView();
            this.Seller_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller_Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SellerIDTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SellerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SellerAddTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SellerEmailTextBox = new System.Windows.Forms.TextBox();
            this.SellerTelTextBox = new System.Windows.Forms.TextBox();
            this.SellerRemoveButton = new System.Windows.Forms.Button();
            this.SellerEditButton = new System.Windows.Forms.Button();
            this.SellerAddButton = new System.Windows.Forms.Button();
            this.sideBar2 = new PetManage.SideBar();
            this.closeBtn2 = new PetManage.CloseBtn();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SellerDataGridView
            // 
            this.SellerDataGridView.AllowUserToAddRows = false;
            this.SellerDataGridView.AllowUserToDeleteRows = false;
            this.SellerDataGridView.AllowUserToResizeColumns = false;
            this.SellerDataGridView.AllowUserToResizeRows = false;
            this.SellerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(223)))));
            this.SellerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.SellerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SellerDataGridView.ColumnHeadersHeight = 40;
            this.SellerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SellerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seller_ID,
            this.Seller_Name,
            this.Seller_Address,
            this.Seller_Email,
            this.Seller_Telephone});
            this.SellerDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SellerDataGridView.EnableHeadersVisualStyles = false;
            this.SellerDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.SellerDataGridView.Location = new System.Drawing.Point(238, 243);
            this.SellerDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.SellerDataGridView.Name = "SellerDataGridView";
            this.SellerDataGridView.ReadOnly = true;
            this.SellerDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SellerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SellerDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.SellerDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.SellerDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SellerDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.SellerDataGridView.RowTemplate.Height = 24;
            this.SellerDataGridView.RowTemplate.ReadOnly = true;
            this.SellerDataGridView.Size = new System.Drawing.Size(717, 314);
            this.SellerDataGridView.TabIndex = 30;
            // 
            // Seller_ID
            // 
            this.Seller_ID.DataPropertyName = "Seller_ID";
            this.Seller_ID.FillWeight = 50F;
            this.Seller_ID.HeaderText = "Seller ID";
            this.Seller_ID.MinimumWidth = 6;
            this.Seller_ID.Name = "Seller_ID";
            this.Seller_ID.ReadOnly = true;
            this.Seller_ID.Width = 107;
            // 
            // Seller_Name
            // 
            this.Seller_Name.DataPropertyName = "Seller_Name";
            this.Seller_Name.HeaderText = "Seller Name";
            this.Seller_Name.MinimumWidth = 6;
            this.Seller_Name.Name = "Seller_Name";
            this.Seller_Name.ReadOnly = true;
            this.Seller_Name.Width = 214;
            // 
            // Seller_Address
            // 
            this.Seller_Address.DataPropertyName = "Seller_Address";
            this.Seller_Address.FillWeight = 150F;
            this.Seller_Address.HeaderText = "Seller Address";
            this.Seller_Address.MinimumWidth = 6;
            this.Seller_Address.Name = "Seller_Address";
            this.Seller_Address.ReadOnly = true;
            this.Seller_Address.Width = 106;
            // 
            // Seller_Email
            // 
            this.Seller_Email.DataPropertyName = "Seller_Email";
            this.Seller_Email.HeaderText = "Seller Email";
            this.Seller_Email.MinimumWidth = 6;
            this.Seller_Email.Name = "Seller_Email";
            this.Seller_Email.ReadOnly = true;
            this.Seller_Email.Width = 107;
            // 
            // Seller_Telephone
            // 
            this.Seller_Telephone.DataPropertyName = "Seller_Telephone";
            this.Seller_Telephone.HeaderText = "Seller Telephone";
            this.Seller_Telephone.MinimumWidth = 6;
            this.Seller_Telephone.Name = "Seller_Telephone";
            this.Seller_Telephone.ReadOnly = true;
            this.Seller_Telephone.Width = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label6.Location = new System.Drawing.Point(234, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Seller";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label7.Location = new System.Drawing.Point(235, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID";
            // 
            // SellerIDTextBox
            // 
            this.SellerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerIDTextBox.Location = new System.Drawing.Point(238, 71);
            this.SellerIDTextBox.Name = "SellerIDTextBox";
            this.SellerIDTextBox.Size = new System.Drawing.Size(117, 24);
            this.SellerIDTextBox.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label8.Location = new System.Drawing.Point(403, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Name";
            // 
            // SellerNameTextBox
            // 
            this.SellerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerNameTextBox.Location = new System.Drawing.Point(406, 71);
            this.SellerNameTextBox.Name = "SellerNameTextBox";
            this.SellerNameTextBox.Size = new System.Drawing.Size(243, 24);
            this.SellerNameTextBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(699, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Address";
            // 
            // SellerAddTextBox
            // 
            this.SellerAddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerAddTextBox.Location = new System.Drawing.Point(702, 71);
            this.SellerAddTextBox.Name = "SellerAddTextBox";
            this.SellerAddTextBox.Size = new System.Drawing.Size(253, 24);
            this.SellerAddTextBox.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(451, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(515, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(235, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Email";
            // 
            // SellerEmailTextBox
            // 
            this.SellerEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerEmailTextBox.Location = new System.Drawing.Point(238, 142);
            this.SellerEmailTextBox.Name = "SellerEmailTextBox";
            this.SellerEmailTextBox.Size = new System.Drawing.Size(243, 24);
            this.SellerEmailTextBox.TabIndex = 41;
            // 
            // SellerTelTextBox
            // 
            this.SellerTelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerTelTextBox.Location = new System.Drawing.Point(518, 142);
            this.SellerTelTextBox.Name = "SellerTelTextBox";
            this.SellerTelTextBox.Size = new System.Drawing.Size(243, 24);
            this.SellerTelTextBox.TabIndex = 42;
            // 
            // SellerRemoveButton
            // 
            this.SellerRemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.SellerRemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SellerRemoveButton.FlatAppearance.BorderSize = 0;
            this.SellerRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerRemoveButton.ForeColor = System.Drawing.Color.White;
            this.SellerRemoveButton.Location = new System.Drawing.Point(590, 188);
            this.SellerRemoveButton.Name = "SellerRemoveButton";
            this.SellerRemoveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SellerRemoveButton.Size = new System.Drawing.Size(89, 35);
            this.SellerRemoveButton.TabIndex = 45;
            this.SellerRemoveButton.Text = "Remove";
            this.SellerRemoveButton.UseVisualStyleBackColor = false;
            this.SellerRemoveButton.Click += new System.EventHandler(this.SellerRemoveButton_Click);
            // 
            // SellerEditButton
            // 
            this.SellerEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.SellerEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SellerEditButton.FlatAppearance.BorderSize = 0;
            this.SellerEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerEditButton.ForeColor = System.Drawing.Color.White;
            this.SellerEditButton.Location = new System.Drawing.Point(419, 188);
            this.SellerEditButton.Name = "SellerEditButton";
            this.SellerEditButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SellerEditButton.Size = new System.Drawing.Size(75, 35);
            this.SellerEditButton.TabIndex = 44;
            this.SellerEditButton.Text = "Edit";
            this.SellerEditButton.UseVisualStyleBackColor = false;
            this.SellerEditButton.Click += new System.EventHandler(this.SellerEditButton_Click_1);
            // 
            // SellerAddButton
            // 
            this.SellerAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.SellerAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SellerAddButton.FlatAppearance.BorderSize = 0;
            this.SellerAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerAddButton.ForeColor = System.Drawing.Color.White;
            this.SellerAddButton.Location = new System.Drawing.Point(238, 188);
            this.SellerAddButton.Name = "SellerAddButton";
            this.SellerAddButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SellerAddButton.Size = new System.Drawing.Size(74, 35);
            this.SellerAddButton.TabIndex = 43;
            this.SellerAddButton.Text = "Add";
            this.SellerAddButton.UseVisualStyleBackColor = false;
            this.SellerAddButton.Click += new System.EventHandler(this.SellerAddButton_Click);
            // 
            // sideBar2
            // 
            this.sideBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar2.Location = new System.Drawing.Point(0, 0);
            this.sideBar2.Name = "sideBar2";
            this.sideBar2.Size = new System.Drawing.Size(201, 568);
            this.sideBar2.TabIndex = 46;
            // 
            // closeBtn2
            // 
            this.closeBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn2.Location = new System.Drawing.Point(992, 0);
            this.closeBtn2.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.closeBtn2.Name = "closeBtn2";
            this.closeBtn2.Size = new System.Drawing.Size(25, 25);
            this.closeBtn2.TabIndex = 47;
            // 
            // FormSellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1016, 568);
            this.Controls.Add(this.closeBtn2);
            this.Controls.Add(this.sideBar2);
            this.Controls.Add(this.SellerRemoveButton);
            this.Controls.Add(this.SellerEditButton);
            this.Controls.Add(this.SellerAddButton);
            this.Controls.Add(this.SellerTelTextBox);
            this.Controls.Add(this.SellerEmailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SellerAddTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SellerNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SellerIDTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SellerDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSellers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSellers";
            this.Load += new System.EventHandler(this.FormSellers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView SellerDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SellerIDTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SellerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SellerAddTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SellerEmailTextBox;
        private System.Windows.Forms.TextBox SellerTelTextBox;
        private System.Windows.Forms.Button SellerRemoveButton;
        private System.Windows.Forms.Button SellerEditButton;
        private System.Windows.Forms.Button SellerAddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller_Telephone;
        private SideBar sideBar1;
        private CloseBtn closeBtn1;
        private SideBar sideBar2;
        private CloseBtn closeBtn2;
    }
}