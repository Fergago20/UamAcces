namespace UamAcces.Formularios
{
    partial class Entry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            this.LblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.lblHora = new MaterialSkin.Controls.MaterialLabel();
            this.lblDia = new MaterialSkin.Controls.MaterialLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RbPedestrian = new System.Windows.Forms.RadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.RbVehicular = new System.Windows.Forms.RadioButton();
            this.TbPlate = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.RbResidential = new System.Windows.Forms.RadioButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.RbPrincipal = new System.Windows.Forms.RadioButton();
            this.GbAcces = new System.Windows.Forms.GroupBox();
            this.GbEntry = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GbAcces.SuspendLayout();
            this.GbEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.BackColor = System.Drawing.Color.White;
            this.LblWelcome.Depth = 0;
            this.LblWelcome.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblWelcome.Location = new System.Drawing.Point(223, 81);
            this.LblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(256, 24);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "¡Bienvenido Usuario_Apelido!";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.White;
            this.lblHora.Depth = 0;
            this.lblHora.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHora.Location = new System.Drawing.Point(223, 129);
            this.lblHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(61, 24);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Hora: ";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.White;
            this.lblDia.Depth = 0;
            this.lblDia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDia.Location = new System.Drawing.Point(223, 165);
            this.lblDia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(47, 24);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "Día: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Image = global::UamAcces.Properties.Resources.reloj_de_salida;
            this.button1.Location = new System.Drawing.Point(309, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 88);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtmEntry_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 156);
            this.panel1.TabIndex = 12;
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
            // RbPedestrian
            // 
            this.RbPedestrian.AutoSize = true;
            this.RbPedestrian.BackColor = System.Drawing.Color.Transparent;
            this.RbPedestrian.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbPedestrian.Location = new System.Drawing.Point(6, 11);
            this.RbPedestrian.Name = "RbPedestrian";
            this.RbPedestrian.Size = new System.Drawing.Size(86, 21);
            this.RbPedestrian.TabIndex = 13;
            this.RbPedestrian.TabStop = true;
            this.RbPedestrian.Text = "Peatonal";
            this.RbPedestrian.UseVisualStyleBackColor = false;
            this.RbPedestrian.CheckedChanged += new System.EventHandler(this.RbPedestrian_CheckedChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(223, 198);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(142, 24);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Tipo de Acceso";
            // 
            // RbVehicular
            // 
            this.RbVehicular.AutoSize = true;
            this.RbVehicular.BackColor = System.Drawing.Color.Transparent;
            this.RbVehicular.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbVehicular.Location = new System.Drawing.Point(6, 47);
            this.RbVehicular.Name = "RbVehicular";
            this.RbVehicular.Size = new System.Drawing.Size(88, 21);
            this.RbVehicular.TabIndex = 15;
            this.RbVehicular.TabStop = true;
            this.RbVehicular.Text = "Vehicular";
            this.RbVehicular.UseVisualStyleBackColor = false;
            this.RbVehicular.CheckedChanged += new System.EventHandler(this.RbVehicular_CheckedChanged);
            // 
            // TbPlate
            // 
            this.TbPlate.Enabled = false;
            this.TbPlate.Location = new System.Drawing.Point(282, 306);
            this.TbPlate.Name = "TbPlate";
            this.TbPlate.Size = new System.Drawing.Size(149, 22);
            this.TbPlate.TabIndex = 16;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.White;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(223, 308);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(57, 24);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Placa";
            // 
            // RbResidential
            // 
            this.RbResidential.AutoSize = true;
            this.RbResidential.BackColor = System.Drawing.Color.Transparent;
            this.RbResidential.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbResidential.Location = new System.Drawing.Point(106, 22);
            this.RbResidential.Name = "RbResidential";
            this.RbResidential.Size = new System.Drawing.Size(105, 21);
            this.RbResidential.TabIndex = 20;
            this.RbResidential.TabStop = true;
            this.RbResidential.Text = "Residencial";
            this.RbResidential.UseVisualStyleBackColor = false;
            this.RbResidential.CheckedChanged += new System.EventHandler(this.RbResidential_CheckedChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.White;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(223, 347);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(74, 24);
            this.materialLabel5.TabIndex = 19;
            this.materialLabel5.Text = "Entrada";
            // 
            // RbPrincipal
            // 
            this.RbPrincipal.AutoSize = true;
            this.RbPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.RbPrincipal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbPrincipal.Location = new System.Drawing.Point(6, 21);
            this.RbPrincipal.Name = "RbPrincipal";
            this.RbPrincipal.Size = new System.Drawing.Size(85, 21);
            this.RbPrincipal.TabIndex = 18;
            this.RbPrincipal.TabStop = true;
            this.RbPrincipal.Text = "Principal";
            this.RbPrincipal.UseVisualStyleBackColor = false;
            this.RbPrincipal.CheckedChanged += new System.EventHandler(this.RbPrincipal_CheckedChanged);
            // 
            // GbAcces
            // 
            this.GbAcces.BackColor = System.Drawing.Color.Transparent;
            this.GbAcces.Controls.Add(this.RbPedestrian);
            this.GbAcces.Controls.Add(this.RbVehicular);
            this.GbAcces.Location = new System.Drawing.Point(227, 225);
            this.GbAcces.Name = "GbAcces";
            this.GbAcces.Size = new System.Drawing.Size(167, 75);
            this.GbAcces.TabIndex = 21;
            this.GbAcces.TabStop = false;
            // 
            // GbEntry
            // 
            this.GbEntry.BackColor = System.Drawing.Color.Transparent;
            this.GbEntry.Controls.Add(this.RbPrincipal);
            this.GbEntry.Controls.Add(this.RbResidential);
            this.GbEntry.Location = new System.Drawing.Point(309, 334);
            this.GbEntry.Name = "GbEntry";
            this.GbEntry.Size = new System.Drawing.Size(220, 54);
            this.GbEntry.TabIndex = 22;
            this.GbEntry.TabStop = false;
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 506);
            this.Controls.Add(this.GbEntry);
            this.Controls.Add(this.GbAcces);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.TbPlate);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.LblWelcome);
            this.MaximizeBox = false;
            this.Name = "Entry";
            this.Sizable = false;
            this.Text = "Entrada";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GbAcces.ResumeLayout(false);
            this.GbAcces.PerformLayout();
            this.GbEntry.ResumeLayout(false);
            this.GbEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblWelcome;
        private MaterialSkin.Controls.MaterialLabel lblHora;
        private MaterialSkin.Controls.MaterialLabel lblDia;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RbPedestrian;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.RadioButton RbVehicular;
        private System.Windows.Forms.TextBox TbPlate;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.RadioButton RbResidential;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.RadioButton RbPrincipal;
        private System.Windows.Forms.GroupBox GbAcces;
        private System.Windows.Forms.GroupBox GbEntry;
    }
}