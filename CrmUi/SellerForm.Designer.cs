namespace CrmUi
{
    partial class SellerForm
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
            this.SellerFormNameAdd = new System.Windows.Forms.Label();
            this.SellerFormAddNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SellerFormNameAdd
            // 
            this.SellerFormNameAdd.AutoSize = true;
            this.SellerFormNameAdd.Location = new System.Drawing.Point(13, 13);
            this.SellerFormNameAdd.Name = "SellerFormNameAdd";
            this.SellerFormNameAdd.Size = new System.Drawing.Size(72, 13);
            this.SellerFormNameAdd.TabIndex = 0;
            this.SellerFormNameAdd.Text = "Введите имя";
            // 
            // SellerFormAddNameTextBox
            // 
            this.SellerFormAddNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SellerFormAddNameTextBox.Location = new System.Drawing.Point(91, 10);
            this.SellerFormAddNameTextBox.Name = "SellerFormAddNameTextBox";
            this.SellerFormAddNameTextBox.Size = new System.Drawing.Size(215, 20);
            this.SellerFormAddNameTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(231, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 95);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SellerFormAddNameTextBox);
            this.Controls.Add(this.SellerFormNameAdd);
            this.Name = "SellerForm";
            this.Text = "Продавец";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SellerFormNameAdd;
        private System.Windows.Forms.TextBox SellerFormAddNameTextBox;
        private System.Windows.Forms.Button button1;
    }
}