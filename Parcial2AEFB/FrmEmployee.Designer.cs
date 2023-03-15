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
            this.LblContract = new System.Windows.Forms.Label();
            this.TxtSSN = new System.Windows.Forms.TextBox();
            this.LblSSN = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.GrpConfidential = new System.Windows.Forms.GroupBox();
            this.GrpName = new System.Windows.Forms.GroupBox();
            this.CmbContract = new System.Windows.Forms.ComboBox();
            this.GrpConfidential.SuspendLayout();
            this.GrpName.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(130, 122);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(171, 20);
            this.TxtAddress.TabIndex = 19;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.Location = new System.Drawing.Point(6, 122);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(90, 24);
            this.LblAddress.TabIndex = 18;
            this.LblAddress.Text = "Dirección";
            // 
            // LblContract
            // 
            this.LblContract.AutoSize = true;
            this.LblContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContract.Location = new System.Drawing.Point(6, 75);
            this.LblContract.Name = "LblContract";
            this.LblContract.Size = new System.Drawing.Size(150, 24);
            this.LblContract.TabIndex = 16;
            this.LblContract.Text = "Tipo de Contrato";
            // 
            // TxtSSN
            // 
            this.TxtSSN.Location = new System.Drawing.Point(266, 29);
            this.TxtSSN.Name = "TxtSSN";
            this.TxtSSN.Size = new System.Drawing.Size(100, 20);
            this.TxtSSN.TabIndex = 15;
            // 
            // LblSSN
            // 
            this.LblSSN.AutoSize = true;
            this.LblSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSSN.Location = new System.Drawing.Point(6, 29);
            this.LblSSN.Name = "LblSSN";
            this.LblSSN.Size = new System.Drawing.Size(254, 24);
            this.LblSSN.TabIndex = 14;
            this.LblSSN.Text = "Número de Seguridad Social";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.Location = new System.Drawing.Point(6, 74);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(79, 24);
            this.LblLastName.TabIndex = 12;
            this.LblLastName.Text = "Apellido";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(6, 29);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(79, 24);
            this.LblName.TabIndex = 10;
            this.LblName.Text = "Nombre";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(92, 33);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 20;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(92, 79);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 21;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(14, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(413, 37);
            this.LblTitle.TabIndex = 22;
            this.LblTitle.Text = "Información del Empleado";
            // 
            // GrpConfidential
            // 
            this.GrpConfidential.Controls.Add(this.CmbContract);
            this.GrpConfidential.Controls.Add(this.LblSSN);
            this.GrpConfidential.Controls.Add(this.TxtSSN);
            this.GrpConfidential.Controls.Add(this.TxtAddress);
            this.GrpConfidential.Controls.Add(this.LblAddress);
            this.GrpConfidential.Controls.Add(this.LblContract);
            this.GrpConfidential.Location = new System.Drawing.Point(297, 81);
            this.GrpConfidential.Name = "GrpConfidential";
            this.GrpConfidential.Size = new System.Drawing.Size(432, 176);
            this.GrpConfidential.TabIndex = 23;
            this.GrpConfidential.TabStop = false;
            this.GrpConfidential.Text = "Información Confidencial";
            // 
            // GrpName
            // 
            this.GrpName.Controls.Add(this.TxtName);
            this.GrpName.Controls.Add(this.LblName);
            this.GrpName.Controls.Add(this.TxtLastName);
            this.GrpName.Controls.Add(this.LblLastName);
            this.GrpName.Location = new System.Drawing.Point(24, 81);
            this.GrpName.Name = "GrpName";
            this.GrpName.Size = new System.Drawing.Size(215, 116);
            this.GrpName.TabIndex = 24;
            this.GrpName.TabStop = false;
            this.GrpName.Text = "Información";
            // 
            // CmbContract
            // 
            this.CmbContract.FormattingEnabled = true;
            this.CmbContract.Location = new System.Drawing.Point(180, 77);
            this.CmbContract.Name = "CmbContract";
            this.CmbContract.Size = new System.Drawing.Size(186, 21);
            this.CmbContract.TabIndex = 17;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 281);
            this.Controls.Add(this.GrpName);
            this.Controls.Add(this.GrpConfidential);
            this.Controls.Add(this.LblTitle);
            this.Name = "FrmEmployee";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.GrpConfidential.ResumeLayout(false);
            this.GrpConfidential.PerformLayout();
            this.GrpName.ResumeLayout(false);
            this.GrpName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblContract;
        private System.Windows.Forms.TextBox TxtSSN;
        private System.Windows.Forms.Label LblSSN;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.GroupBox GrpConfidential;
        private System.Windows.Forms.ComboBox CmbContract;
        private System.Windows.Forms.GroupBox GrpName;
    }
}