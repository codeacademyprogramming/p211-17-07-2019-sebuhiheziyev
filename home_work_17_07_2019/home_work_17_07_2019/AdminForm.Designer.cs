namespace home_work_17_07_2019
{
    partial class AdminForm
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
            this.lblWelcom = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.ListBox();
            this.cmvCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWelcom
            // 
            this.lblWelcom.BackColor = System.Drawing.Color.BlueViolet;
            this.lblWelcom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcom.Location = new System.Drawing.Point(0, 0);
            this.lblWelcom.Name = "lblWelcom";
            this.lblWelcom.Size = new System.Drawing.Size(821, 52);
            this.lblWelcom.TabIndex = 1;
            this.lblWelcom.Text = "Welcome, Admin";
            this.lblWelcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProduct
            // 
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProduct.FormattingEnabled = true;
            this.lblProduct.Location = new System.Drawing.Point(0, 52);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(286, 412);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.SelectedIndexChanged += new System.EventHandler(this.LblProduct_SelectedIndexChanged);
            // 
            // cmvCategories
            // 
            this.cmvCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmvCategories.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmvCategories.FormattingEnabled = true;
            this.cmvCategories.Location = new System.Drawing.Point(304, 104);
            this.cmvCategories.Name = "cmvCategories";
            this.cmvCategories.Size = new System.Drawing.Size(210, 30);
            this.cmvCategories.TabIndex = 3;
            this.cmvCategories.SelectedIndexChanged += new System.EventHandler(this.CmvCategories_SelectedIndexChanged);
            this.cmvCategories.TextChanged += new System.EventHandler(this.CmvCategories_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Category";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtcate
            // 
            this.txtcate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcate.Location = new System.Drawing.Point(304, 211);
            this.txtcate.Name = "txtcate";
            this.txtcate.Size = new System.Drawing.Size(433, 31);
            this.txtcate.TabIndex = 5;
            this.txtcate.TextChanged += new System.EventHandler(this.Txtcate_TextChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 464);
            this.Controls.Add(this.txtcate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmvCategories);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblWelcom);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcom;
        private System.Windows.Forms.ListBox lblProduct;
        private System.Windows.Forms.ComboBox cmvCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcate;
    }
}