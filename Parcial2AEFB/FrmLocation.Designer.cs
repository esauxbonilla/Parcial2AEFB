namespace Parcial2AEFB
{
    partial class Locación
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
            this.TxtCP = new System.Windows.Forms.TextBox();
            this.TxtCountry = new System.Windows.Forms.TextBox();
            this.LblCountry = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblCP = new System.Windows.Forms.Label();
            this.TxtInt = new System.Windows.Forms.TextBox();
            this.LblInt = new System.Windows.Forms.Label();
            this.TxtExt = new System.Windows.Forms.TextBox();
            this.LblExt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtCP
            // 
            this.TxtCP.Location = new System.Drawing.Point(123, 211);
            this.TxtCP.Name = "TxtCP";
            this.TxtCP.Size = new System.Drawing.Size(100, 20);
            this.TxtCP.TabIndex = 39;
            // 
            // TxtCountry
            // 
            this.TxtCountry.Location = new System.Drawing.Point(123, 348);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(100, 20);
            this.TxtCountry.TabIndex = 38;
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.Location = new System.Drawing.Point(34, 351);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(29, 13);
            this.LblCountry.TabIndex = 37;
            this.LblCountry.Text = "País";
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(123, 280);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(100, 20);
            this.TxtCity.TabIndex = 36;
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(34, 283);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(40, 13);
            this.LblCity.TabIndex = 35;
            this.LblCity.Text = "Cuidad";
            // 
            // LblCP
            // 
            this.LblCP.AutoSize = true;
            this.LblCP.Location = new System.Drawing.Point(34, 214);
            this.LblCP.Name = "LblCP";
            this.LblCP.Size = new System.Drawing.Size(72, 13);
            this.LblCP.TabIndex = 34;
            this.LblCP.Text = "Código Postal";
            // 
            // TxtInt
            // 
            this.TxtInt.Location = new System.Drawing.Point(123, 134);
            this.TxtInt.Name = "TxtInt";
            this.TxtInt.Size = new System.Drawing.Size(100, 20);
            this.TxtInt.TabIndex = 33;
            // 
            // LblInt
            // 
            this.LblInt.AutoSize = true;
            this.LblInt.Location = new System.Drawing.Point(34, 137);
            this.LblInt.Name = "LblInt";
            this.LblInt.Size = new System.Drawing.Size(80, 13);
            this.LblInt.TabIndex = 32;
            this.LblInt.Text = "Número Interno";
            // 
            // TxtExt
            // 
            this.TxtExt.Location = new System.Drawing.Point(123, 60);
            this.TxtExt.Name = "TxtExt";
            this.TxtExt.Size = new System.Drawing.Size(100, 20);
            this.TxtExt.TabIndex = 31;
            // 
            // LblExt
            // 
            this.LblExt.AutoSize = true;
            this.LblExt.Location = new System.Drawing.Point(34, 60);
            this.LblExt.Name = "LblExt";
            this.LblExt.Size = new System.Drawing.Size(83, 13);
            this.LblExt.TabIndex = 30;
            this.LblExt.Text = "Número Externo";
            // 
            // Locación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.TxtCP);
            this.Controls.Add(this.TxtCountry);
            this.Controls.Add(this.LblCountry);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblCP);
            this.Controls.Add(this.TxtInt);
            this.Controls.Add(this.LblInt);
            this.Controls.Add(this.TxtExt);
            this.Controls.Add(this.LblExt);
            this.Name = "Locación";
            this.Text = "FrmLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCP;
        private System.Windows.Forms.TextBox TxtCountry;
        private System.Windows.Forms.Label LblCountry;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblCP;
        private System.Windows.Forms.TextBox TxtInt;
        private System.Windows.Forms.Label LblInt;
        private System.Windows.Forms.TextBox TxtExt;
        private System.Windows.Forms.Label LblExt;
    }
}