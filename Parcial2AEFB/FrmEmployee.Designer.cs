namespace Parcial2AEFB
{
    partial class FrmEmployee
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
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.TxtContract = new System.Windows.Forms.TextBox();
            this.LblContract = new System.Windows.Forms.Label();
            this.TxtSSN = new System.Windows.Forms.TextBox();
            this.LblSSN = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(105, 350);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(100, 20);
            this.TxtAddress.TabIndex = 19;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(44, 350);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(52, 13);
            this.LblAddress.TabIndex = 18;
            this.LblAddress.Text = "Dirección";
            // 
            // TxtContract
            // 
            this.TxtContract.Location = new System.Drawing.Point(142, 282);
            this.TxtContract.Name = "TxtContract";
            this.TxtContract.Size = new System.Drawing.Size(100, 20);
            this.TxtContract.TabIndex = 17;
            // 
            // LblContract
            // 
            this.LblContract.AutoSize = true;
            this.LblContract.Location = new System.Drawing.Point(44, 282);
            this.LblContract.Name = "LblContract";
            this.LblContract.Size = new System.Drawing.Size(86, 13);
            this.LblContract.TabIndex = 16;
            this.LblContract.Text = "Tipo de Contrato";
            // 
            // TxtSSN
            // 
            this.TxtSSN.Location = new System.Drawing.Point(192, 210);
            this.TxtSSN.Name = "TxtSSN";
            this.TxtSSN.Size = new System.Drawing.Size(100, 20);
            this.TxtSSN.TabIndex = 15;
            // 
            // LblSSN
            // 
            this.LblSSN.AutoSize = true;
            this.LblSSN.Location = new System.Drawing.Point(44, 213);
            this.LblSSN.Name = "LblSSN";
            this.LblSSN.Size = new System.Drawing.Size(142, 13);
            this.LblSSN.TabIndex = 14;
            this.LblSSN.Text = "Número de Seguridad Social";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(44, 136);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(44, 13);
            this.LblLastName.TabIndex = 12;
            this.LblLastName.Text = "Apellido";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(44, 59);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 13);
            this.LblName.TabIndex = 10;
            this.LblName.Text = "Nombre";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(94, 56);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 20;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(105, 133);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 21;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 437);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.TxtContract);
            this.Controls.Add(this.LblContract);
            this.Controls.Add(this.TxtSSN);
            this.Controls.Add(this.LblSSN);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblName);
            this.Name = "FrmEmployee";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.TextBox TxtContract;
        private System.Windows.Forms.Label LblContract;
        private System.Windows.Forms.TextBox TxtSSN;
        private System.Windows.Forms.Label LblSSN;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtLastName;
    }
}