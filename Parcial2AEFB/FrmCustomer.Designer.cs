namespace Parcial2AEFB
{
    partial class FrmCustomer
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
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.LblNum = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(26, 51);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Nombre";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(87, 51);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(87, 128);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 3;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(26, 128);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(44, 13);
            this.LblLastName.TabIndex = 2;
            this.LblLastName.Text = "Apellido";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(87, 205);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(26, 205);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 4;
            this.LblEmail.Text = "Email";
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(87, 274);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(100, 20);
            this.TxtNum.TabIndex = 7;
            // 
            // LblNum
            // 
            this.LblNum.AutoSize = true;
            this.LblNum.Location = new System.Drawing.Point(26, 274);
            this.LblNum.Name = "LblNum";
            this.LblNum.Size = new System.Drawing.Size(44, 13);
            this.LblNum.TabIndex = 6;
            this.LblNum.Text = "Número";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(87, 342);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(100, 20);
            this.TxtAddress.TabIndex = 9;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(26, 342);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(52, 13);
            this.LblAddress.TabIndex = 8;
            this.LblAddress.Text = "Dirección";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 425);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.LblNum);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Name = "FrmCustomer";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.Label LblNum;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label LblAddress;
    }
}