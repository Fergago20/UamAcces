namespace UamAcces.Formularios
{
    partial class Exit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exit));
            this.label1 = new System.Windows.Forms.Label();
            this.LblRestHour = new System.Windows.Forms.Label();
            this.LblHour = new System.Windows.Forms.Label();
            this.LblEntry = new System.Windows.Forms.Label();
            this.BtmClose = new System.Windows.Forms.Button();
            this.BtmExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Marcar Salida";
            // 
            // LblRestHour
            // 
            this.LblRestHour.AutoSize = true;
            this.LblRestHour.BackColor = System.Drawing.Color.Transparent;
            this.LblRestHour.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestHour.Location = new System.Drawing.Point(211, 129);
            this.LblRestHour.Name = "LblRestHour";
            this.LblRestHour.Size = new System.Drawing.Size(162, 19);
            this.LblRestHour.TabIndex = 14;
            this.LblRestHour.Text = "Horas Transcurridas:";
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.BackColor = System.Drawing.Color.Transparent;
            this.LblHour.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHour.Location = new System.Drawing.Point(211, 173);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(98, 19);
            this.LblHour.TabIndex = 15;
            this.LblHour.Text = "Hora Actual:";
            // 
            // LblEntry
            // 
            this.LblEntry.AutoSize = true;
            this.LblEntry.BackColor = System.Drawing.Color.Transparent;
            this.LblEntry.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntry.Location = new System.Drawing.Point(211, 219);
            this.LblEntry.Name = "LblEntry";
            this.LblEntry.Size = new System.Drawing.Size(134, 19);
            this.LblEntry.TabIndex = 16;
            this.LblEntry.Text = "Hora de Entrada:";
            // 
            // BtmClose
            // 
            this.BtmClose.Image = global::UamAcces.Properties.Resources.error;
            this.BtmClose.Location = new System.Drawing.Point(431, 271);
            this.BtmClose.Name = "BtmClose";
            this.BtmClose.Size = new System.Drawing.Size(110, 94);
            this.BtmClose.TabIndex = 18;
            this.BtmClose.UseVisualStyleBackColor = true;
            this.BtmClose.Click += new System.EventHandler(this.BtmClose_Click);
            // 
            // BtmExit
            // 
            this.BtmExit.Image = global::UamAcces.Properties.Resources.cerrar_sesion;
            this.BtmExit.Location = new System.Drawing.Point(215, 271);
            this.BtmExit.Name = "BtmExit";
            this.BtmExit.Size = new System.Drawing.Size(95, 94);
            this.BtmExit.TabIndex = 17;
            this.BtmExit.UseVisualStyleBackColor = true;
            this.BtmExit.Click += new System.EventHandler(this.BtmExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 156);
            this.panel1.TabIndex = 19;
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtmClose);
            this.Controls.Add(this.BtmExit);
            this.Controls.Add(this.LblEntry);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.LblRestHour);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Exit";
            this.Sizable = false;
            this.Text = "Salida";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblRestHour;
        private System.Windows.Forms.Label LblHour;
        private System.Windows.Forms.Label LblEntry;
        private System.Windows.Forms.Button BtmExit;
        private System.Windows.Forms.Button BtmClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}