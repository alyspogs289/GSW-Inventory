namespace GSW_Inventory
{
    partial class InventoryScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showProducts = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.xButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.showProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showProducts
            // 
            this.showProducts.AllowUserToAddRows = false;
            this.showProducts.AllowUserToDeleteRows = false;
            this.showProducts.AllowUserToResizeColumns = false;
            this.showProducts.AllowUserToResizeRows = false;
            this.showProducts.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.showProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Description,
            this.Count});
            this.showProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.showProducts.GridColor = System.Drawing.Color.SlateGray;
            this.showProducts.Location = new System.Drawing.Point(34, 235);
            this.showProducts.Name = "showProducts";
            this.showProducts.ReadOnly = true;
            this.showProducts.RowHeadersWidth = 43;
            this.showProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.showProducts.RowTemplate.ReadOnly = true;
            this.showProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showProducts.ShowEditingIcon = false;
            this.showProducts.Size = new System.Drawing.Size(625, 326);
            this.showProducts.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(573, 166);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(86, 33);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Black;
            this.searchBox.Location = new System.Drawing.Point(100, 168);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(449, 29);
            this.searchBox.TabIndex = 2;
            // 
            // xButton
            // 
            this.xButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.xButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xButton.ForeColor = System.Drawing.Color.Black;
            this.xButton.Location = new System.Drawing.Point(34, 168);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(41, 29);
            this.xButton.TabIndex = 4;
            this.xButton.Text = "X";
            this.xButton.UseVisualStyleBackColor = false;
            this.xButton.Click += new System.EventHandler(this.xButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(96, 200);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(463, 22);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "No products found. Please enter a valid product code.";
            this.errorLabel.Visible = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(269, 586);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(113, 36);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // logoBox
            // 
            this.logoBox.Image = global::GSW_Inventory.Properties.Resources.GlobalSolutions_logo_1;
            this.logoBox.Location = new System.Drawing.Point(136, 17);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(371, 131);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 3;
            this.logoBox.TabStop = false;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Code.HeaderText = "Product Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Code.Width = 194;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Description.HeaderText = "Product Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.Width = 194;
            // 
            // Count
            // 
            this.Count.HeaderText = "Product Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 194;
            // 
            // InventoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.xButton);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.showProducts);
            this.Name = "InventoryScreen";
            this.Size = new System.Drawing.Size(693, 650);
            ((System.ComponentModel.ISupportInitialize)(this.showProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showProducts;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button xButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}
