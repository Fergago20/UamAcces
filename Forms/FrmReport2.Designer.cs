namespace UamAcces.Forms
{
    partial class FrmReport2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CbRole = new System.Windows.Forms.ComboBox();
            this.Rol = new System.Windows.Forms.Label();
            this.btmInforme = new System.Windows.Forms.Button();
            this.BtmReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 156);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UamAcces.Properties.Resources.Logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CbRole
            // 
            this.CbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRole.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRole.FormattingEnabled = true;
            this.CbRole.Location = new System.Drawing.Point(256, 126);
            this.CbRole.Name = "CbRole";
            this.CbRole.Size = new System.Drawing.Size(264, 27);
            this.CbRole.TabIndex = 16;
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.BackColor = System.Drawing.Color.White;
            this.Rol.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rol.Location = new System.Drawing.Point(175, 125);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(37, 21);
            this.Rol.TabIndex = 15;
            this.Rol.Text = "Rol";
            // 
            // btmInforme
            // 
            this.btmInforme.Image = global::UamAcces.Properties.Resources.formulario_de_llenado;
            this.btmInforme.Location = new System.Drawing.Point(604, 82);
            this.btmInforme.Name = "btmInforme";
            this.btmInforme.Size = new System.Drawing.Size(104, 111);
            this.btmInforme.TabIndex = 17;
            this.btmInforme.UseVisualStyleBackColor = true;
            this.btmInforme.Click += new System.EventHandler(this.btmInforme_Click);
            // 
            // BtmReturn
            // 
            this.BtmReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtmReturn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmReturn.ForeColor = System.Drawing.Color.White;
            this.BtmReturn.Location = new System.Drawing.Point(12, 259);
            this.BtmReturn.Name = "BtmReturn";
            this.BtmReturn.Size = new System.Drawing.Size(130, 41);
            this.BtmReturn.TabIndex = 23;
            this.BtmReturn.Text = "Regresar";
            this.BtmReturn.UseVisualStyleBackColor = false;
            this.BtmReturn.Click += new System.EventHandler(this.BtmReturn_Click);
            // 
            // FrmReport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 312);
            this.Controls.Add(this.BtmReturn);
            this.Controls.Add(this.btmInforme);
            this.Controls.Add(this.CbRole);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmReport2";
            this.Text = "Reporte Ingresados";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CbRole;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.Button btmInforme;
        private System.Windows.Forms.Button BtmReturn;
    }
}