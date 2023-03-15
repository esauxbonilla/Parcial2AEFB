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
            this.LblTitle = new System.Windows.Forms.Label();
            this.GrpInfo = new System.Windows.Forms.GroupBox();
            this.GrpContact = new System.Windows.Forms.GroupBox();
            this.GrpInfo.SuspendLayout();
            this.GrpContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(6, 16);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(79, 24);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Nombre";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(120, 21);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(120, 70);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 3;
            this.TxtLastName.TextChanged += new System.EventHandler(this.TxtLastName_TextChanged);
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.Location = new System.Drawing.Point(6, 66);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(79, 24);
            this.LblLastName.TabIndex = 2;
            this.LblLastName.Text = "Apellido";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(110, 31);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(7, 26);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(57, 24);
            this.LblEmail.TabIndex = 4;
            this.LblEmail.Text = "Email";
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(110, 71);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(100, 20);
            this.TxtNum.TabIndex = 7;
            // 
            // LblNum
            // 
            this.LblNum.AutoSize = true;
            this.LblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNum.Location = new System.Drawing.Point(7, 66);
            this.LblNum.Name = "LblNum";
            this.LblNum.Size = new System.Drawing.Size(79, 24);
            this.LblNum.TabIndex = 6;
            this.LblNum.Text = "Número";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(110, 118);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(100, 20);
            this.TxtAddress.TabIndex = 9;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.Location = new System.Drawing.Point(7, 113);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(90, 24);
            this.LblAddress.TabIndex = 8;
            this.LblAddress.Text = "Dirección";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(13, 13);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(359, 37);
            this.LblTitle.TabIndex = 10;
            this.LblTitle.Text = "Información del cliente";
            this.LblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // GrpInfo
            // 
            this.GrpInfo.Controls.Add(this.LblName);
            this.GrpInfo.Controls.Add(this.LblLastName);
            this.GrpInfo.Controls.Add(this.TxtName);
            this.GrpInfo.Controls.Add(this.TxtLastName);
            this.GrpInfo.Location = new System.Drawing.Point(12, 79);
            this.GrpInfo.Name = "GrpInfo";
            this.GrpInfo.Size = new System.Drawing.Size(309, 120);
            this.GrpInfo.TabIndex = 11;
            this.GrpInfo.TabStop = false;
            this.GrpInfo.Text = "Información";
            // 
            // GrpContact
            // 
            this.GrpContact.Controls.Add(this.TxtNum);
            this.GrpContact.Controls.Add(this.LblEmail);
            this.GrpContact.Controls.Add(this.TxtEmail);
            this.GrpContact.Controls.Add(this.TxtAddress);
            this.GrpContact.Controls.Add(this.LblAddress);
            this.GrpContact.Controls.Add(this.LblNum);
            this.GrpContact.Location = new System.Drawing.Point(341, 79);
            this.GrpContact.Name = "GrpContact";
            this.GrpContact.Size = new System.Drawing.Size(236, 166);
            this.GrpContact.TabIndex = 12;
            this.GrpContact.TabStop = false;
            this.GrpContact.Text = "Contacto";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 290);
            this.Controls.Add(this.GrpContact);
            this.Controls.Add(this.GrpInfo);
            this.Controls.Add(this.LblTitle);
            this.Name = "FrmCustomer";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.GrpInfo.ResumeLayout(false);
            this.GrpInfo.PerformLayout();
            this.GrpContact.ResumeLayout(false);
            this.GrpContact.PerformLayout();
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
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.GroupBox GrpInfo;
        private System.Windows.Forms.GroupBox GrpContact;
    }
}