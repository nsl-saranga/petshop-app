namespace PetManage
{
    partial class FormProduct
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
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.Pro_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProIDTextBox = new System.Windows.Forms.TextBox();
            this.ProNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProQtyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProPriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProRemoveButton = new System.Windows.Forms.Button();
            this.ProEditButton = new System.Windows.Forms.Button();
            this.ProAddButton = new System.Windows.Forms.Button();
            this.ProCat_IDTextBox = new System.Windows.Forms.TextBox();
            this.closeBtn1 = new PetManage.CloseBtn();
            this.sideBar1 = new PetManage.SideBar();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToResizeColumns = false;
            this.productDataGridView.AllowUserToResizeRows = false;
            this.productDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(223)))));
            this.productDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.productDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productDataGridView.ColumnHeadersHeight = 40;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pro_ID,
            this.Pro_Name,
            this.Pro_Qty,
            this.Pro_Price,
            this.Category_ID});
            this.productDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productDataGridView.EnableHeadersVisualStyles = false;
            this.productDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.productDataGridView.Location = new System.Drawing.Point(238, 243);
            this.productDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.productDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.productDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.productDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.RowTemplate.ReadOnly = true;
            this.productDataGridView.Size = new System.Drawing.Size(728, 314);
            this.productDataGridView.TabIndex = 20;
            // 
            // Pro_ID
            // 
            this.Pro_ID.DataPropertyName = "Pro_ID";
            this.Pro_ID.FillWeight = 50F;
            this.Pro_ID.HeaderText = "Product ID";
            this.Pro_ID.MinimumWidth = 6;
            this.Pro_ID.Name = "Pro_ID";
            this.Pro_ID.ReadOnly = true;
            this.Pro_ID.Width = 107;
            // 
            // Pro_Name
            // 
            this.Pro_Name.DataPropertyName = "Pro_Name";
            this.Pro_Name.HeaderText = "Product Name";
            this.Pro_Name.MinimumWidth = 6;
            this.Pro_Name.Name = "Pro_Name";
            this.Pro_Name.ReadOnly = true;
            this.Pro_Name.Width = 214;
            // 
            // Pro_Qty
            // 
            this.Pro_Qty.DataPropertyName = "Pro_Quantity";
            this.Pro_Qty.FillWeight = 50F;
            this.Pro_Qty.HeaderText = "Product Quantity";
            this.Pro_Qty.MinimumWidth = 6;
            this.Pro_Qty.Name = "Pro_Qty";
            this.Pro_Qty.ReadOnly = true;
            this.Pro_Qty.Width = 106;
            // 
            // Pro_Price
            // 
            this.Pro_Price.DataPropertyName = "Pro_Price";
            this.Pro_Price.FillWeight = 50F;
            this.Pro_Price.HeaderText = "Product Price(Rs.)";
            this.Pro_Price.MinimumWidth = 6;
            this.Pro_Price.Name = "Pro_Price";
            this.Pro_Price.ReadOnly = true;
            this.Pro_Price.Width = 107;
            // 
            // Category_ID
            // 
            this.Category_ID.DataPropertyName = "Cat_ID";
            this.Category_ID.FillWeight = 50F;
            this.Category_ID.HeaderText = "Category ID";
            this.Category_ID.MinimumWidth = 6;
            this.Category_ID.Name = "Category_ID";
            this.Category_ID.ReadOnly = true;
            this.Category_ID.Width = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label6.Location = new System.Drawing.Point(234, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Product ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label7.Location = new System.Drawing.Point(235, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label8.Location = new System.Drawing.Point(380, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "Name";
            // 
            // ProIDTextBox
            // 
            this.ProIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProIDTextBox.Location = new System.Drawing.Point(238, 78);
            this.ProIDTextBox.Name = "ProIDTextBox";
            this.ProIDTextBox.Size = new System.Drawing.Size(117, 24);
            this.ProIDTextBox.TabIndex = 32;
            this.ProIDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProIDTextBox_KeyDown);
            this.ProIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProIDTextBox_KeyPress);
            // 
            // ProNameTextBox
            // 
            this.ProNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProNameTextBox.Location = new System.Drawing.Point(383, 78);
            this.ProNameTextBox.Name = "ProNameTextBox";
            this.ProNameTextBox.Size = new System.Drawing.Size(243, 24);
            this.ProNameTextBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label5.Location = new System.Drawing.Point(653, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Quantity";
            // 
            // ProQtyTextBox
            // 
            this.ProQtyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProQtyTextBox.Location = new System.Drawing.Point(656, 78);
            this.ProQtyTextBox.Name = "ProQtyTextBox";
            this.ProQtyTextBox.Size = new System.Drawing.Size(117, 24);
            this.ProQtyTextBox.TabIndex = 35;
            this.ProQtyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProQtyTextBox_KeyDown);
            this.ProQtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProQtyTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(803, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Price";
            // 
            // ProPriceTextBox
            // 
            this.ProPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProPriceTextBox.Location = new System.Drawing.Point(806, 78);
            this.ProPriceTextBox.Name = "ProPriceTextBox";
            this.ProPriceTextBox.Size = new System.Drawing.Size(117, 24);
            this.ProPriceTextBox.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(235, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Category ID";
            // 
            // ProRemoveButton
            // 
            this.ProRemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.ProRemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProRemoveButton.FlatAppearance.BorderSize = 0;
            this.ProRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProRemoveButton.ForeColor = System.Drawing.Color.White;
            this.ProRemoveButton.Location = new System.Drawing.Point(590, 194);
            this.ProRemoveButton.Name = "ProRemoveButton";
            this.ProRemoveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProRemoveButton.Size = new System.Drawing.Size(89, 35);
            this.ProRemoveButton.TabIndex = 41;
            this.ProRemoveButton.Text = "Remove";
            this.ProRemoveButton.UseVisualStyleBackColor = false;
            this.ProRemoveButton.Click += new System.EventHandler(this.ProRemoveButton_Click);
            // 
            // ProEditButton
            // 
            this.ProEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.ProEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProEditButton.FlatAppearance.BorderSize = 0;
            this.ProEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProEditButton.ForeColor = System.Drawing.Color.White;
            this.ProEditButton.Location = new System.Drawing.Point(419, 194);
            this.ProEditButton.Name = "ProEditButton";
            this.ProEditButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProEditButton.Size = new System.Drawing.Size(75, 35);
            this.ProEditButton.TabIndex = 40;
            this.ProEditButton.Text = "Edit";
            this.ProEditButton.UseVisualStyleBackColor = false;
            this.ProEditButton.Click += new System.EventHandler(this.ProEditButton_Click_1);
            // 
            // ProAddButton
            // 
            this.ProAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.ProAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProAddButton.FlatAppearance.BorderSize = 0;
            this.ProAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProAddButton.ForeColor = System.Drawing.Color.White;
            this.ProAddButton.Location = new System.Drawing.Point(238, 194);
            this.ProAddButton.Name = "ProAddButton";
            this.ProAddButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProAddButton.Size = new System.Drawing.Size(74, 35);
            this.ProAddButton.TabIndex = 39;
            this.ProAddButton.Text = "Add";
            this.ProAddButton.UseVisualStyleBackColor = false;
            this.ProAddButton.Click += new System.EventHandler(this.ProAddButton_Click);
            // 
            // ProCat_IDTextBox
            // 
            this.ProCat_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProCat_IDTextBox.Location = new System.Drawing.Point(238, 153);
            this.ProCat_IDTextBox.Name = "ProCat_IDTextBox";
            this.ProCat_IDTextBox.Size = new System.Drawing.Size(117, 24);
            this.ProCat_IDTextBox.TabIndex = 42;
            this.ProCat_IDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProCat_IDTextBox_KeyDown);
            this.ProCat_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProCat_IDTextBox_KeyPress);
            // 
            // closeBtn1
            // 
            this.closeBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn1.Location = new System.Drawing.Point(991, 0);
            this.closeBtn1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.closeBtn1.Name = "closeBtn1";
            this.closeBtn1.Size = new System.Drawing.Size(25, 25);
            this.closeBtn1.TabIndex = 44;
            // 
            // sideBar1
            // 
            this.sideBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(201, 568);
            this.sideBar1.TabIndex = 43;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1016, 568);
            this.Controls.Add(this.closeBtn1);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.ProCat_IDTextBox);
            this.Controls.Add(this.ProRemoveButton);
            this.Controls.Add(this.ProEditButton);
            this.Controls.Add(this.ProAddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProPriceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProQtyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProNameTextBox);
            this.Controls.Add(this.ProIDTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ProIDTextBox;
        private System.Windows.Forms.TextBox ProNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProQtyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ProRemoveButton;
        private System.Windows.Forms.Button ProEditButton;
        private System.Windows.Forms.Button ProAddButton;
        private System.Windows.Forms.TextBox ProCat_IDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_ID;
        private SideBar sideBar1;
        private CloseBtn closeBtn1;
    }
}