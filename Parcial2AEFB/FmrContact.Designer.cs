namespace Parcial2AEFB
{
    partial class FmrContact
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
            this.TxtWeb = new System.Windows.Forms.TextBox();
            this.LblWeb = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtWeb
            // 
            this.TxtWeb.Location = new System.Drawing.Point(519, 148);
            this.TxtWeb.Name = "TxtWeb";
            this.TxtWeb.Size = new System.Drawing.Size(141, 20);
            this.TxtWeb.TabIndex = 28;
            this.TxtWeb.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // LblWeb
            // 
            this.LblWeb.AutoSize = true;
            this.LblWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeb.Location = new System.Drawing.Point(383, 148);
            this.LblWeb.Name = "LblWeb";
            this.LblWeb.Size = new System.Drawing.Size(113, 24);
            this.LblWeb.TabIndex = 27;
            this.LblWeb.Text = "Página Web";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(138, 213);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(179, 20);
            this.TxtPhone.TabIndex = 26;
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhone.Location = new System.Drawing.Point(17, 208);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(85, 24);
            this.LblPhone.TabIndex = 25;
            this.LblPhone.Text = "Teléfono";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(383, 94);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(57, 24);
            this.LblEmail.TabIndex = 24;
            this.LblEmail.Text = "Email";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(138, 148);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(179, 20);
            this.TxtAddress.TabIndex = 23;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.Location = new System.Drawing.Point(17, 148);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(90, 24);
            this.LblAddress.TabIndex = 22;
            this.LblAddress.Text = "Dirección";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(17, 89);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(79, 24);
            this.LblName.TabIndex = 20;
            this.LblName.Text = "Nombre";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(519, 94);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(141, 20);
            this.TxtEmail.TabIndex = 29;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(138, 94);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(179, 20);
            this.TxtName.TabIndex = 30;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(15, 21);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(383, 37);
            this.LblTitle.TabIndex = 52;
            this.LblTitle.Text = "Contacto de la Empresa";
            // 
            // FmrContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 258);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtWeb);
            this.Controls.Add(this.LblWeb);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblName);
            this.Name = "FmrContact";
            this.Text = "Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtWeb;
        private System.Windows.Forms.Label LblWeb;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblTitle;
    }
}