namespace UamAcces.Forms
{
    partial class ViewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbRole = new System.Windows.Forms.ComboBox();
            this.CbFaculty = new System.Windows.Forms.ComboBox();
            this.DgvUser = new System.Windows.Forms.DataGridView();
            this.btmInforme = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuarios Admitidos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 156);
            this.panel1.TabIndex = 4;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Rol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Facultad:";
            // 
            // CbRole
            // 
            this.CbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRole.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRole.FormattingEnabled = true;
            this.CbRole.Location = new System.Drawing.Point(291, 149);
            this.CbRole.Name = "CbRole";
            this.CbRole.Size = new System.Drawing.Size(216, 27);
            this.CbRole.TabIndex = 30;
            this.CbRole.SelectedIndexChanged += new System.EventHandler(this.CbRole_SelectedIndexChanged);
            // 
            // CbFaculty
            // 
            this.CbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFaculty.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFaculty.FormattingEnabled = true;
            this.CbFaculty.Location = new System.Drawing.Point(291, 210);
            this.CbFaculty.Name = "CbFaculty";
            this.CbFaculty.Size = new System.Drawing.Size(216, 27);
            this.CbFaculty.TabIndex = 31;
            this.CbFaculty.SelectedIndexChanged += new System.EventHandler(this.CbFaculty_SelectedIndexChanged);
            // 
            // DgvUser
            // 
            this.DgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUser.Location = new System.Drawing.Point(31, 274);
            this.DgvUser.Name = "DgvUser";
            this.DgvUser.ReadOnly = true;
            this.DgvUser.RowHeadersWidth = 51;
            this.DgvUser.RowTemplate.Height = 24;
            this.DgvUser.Size = new System.Drawing.Size(744, 150);
            this.DgvUser.TabIndex = 32;
            // 
            // btmInforme
            // 
            this.btmInforme.Image = global::UamAcces.Properties.Resources.formulario_de_llenado;
            this.btmInforme.Location = new System.Drawing.Point(613, 126);
            this.btmInforme.Name = "btmInforme";
            this.btmInforme.Size = new System.Drawing.Size(104, 111);
            this.btmInforme.TabIndex = 33;
            this.btmInforme.UseVisualStyleBackColor = true;
            this.btmInforme.Click += new System.EventHandler(this.btmInforme_Click);
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmInforme);
            this.Controls.Add(this.DgvUser);
            this.Controls.Add(this.CbFaculty);
            this.Controls.Add(this.CbRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ViewUser";
            this.Text = "Todos los Usuarios";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbRole;
        private System.Windows.Forms.ComboBox CbFaculty;
        private System.Windows.Forms.DataGridView DgvUser;
        private System.Windows.Forms.Button btmInforme;
    }
}