namespace CrmUi
{
    partial class CustomerForm
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
            this.CastomerFormNameAdd = new System.Windows.Forms.Label();
            this.CustomerFormAddNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CastomerFormNameAdd
            // 
            this.CastomerFormNameAdd.AutoSize = true;
            this.CastomerFormNameAdd.Location = new System.Drawing.Point(13, 13);
            this.CastomerFormNameAdd.Name = "CastomerFormNameAdd";
            this.CastomerFormNameAdd.Size = new System.Drawing.Size(72, 13);
            this.CastomerFormNameAdd.TabIndex = 0;
            this.CastomerFormNameAdd.Text = "Введите имя";
            // 
            // CustomerFormAddNameTextBox
            // 
            this.CustomerFormAddNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerFormAddNameTextBox.Location = new System.Drawing.Point(91, 10);
            this.CustomerFormAddNameTextBox.Name = "CustomerFormAddNameTextBox";
            this.CustomerFormAddNameTextBox.Size = new System.Drawing.Size(215, 20);
            this.CustomerFormAddNameTextBox.TabIndex = 1;
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
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 95);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CustomerFormAddNameTextBox);
            this.Controls.Add(this.CastomerFormNameAdd);
            this.Name = "CustomerForm";
            this.Text = "Покупатель";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CastomerFormNameAdd;
        private System.Windows.Forms.TextBox CustomerFormAddNameTextBox;
        private System.Windows.Forms.Button button1;
    }
}