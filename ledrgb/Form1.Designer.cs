namespace ledrgb
{
    partial class Form1
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
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.tbRojo = new System.Windows.Forms.TrackBar();
            this.tbAzul = new System.Windows.Forms.TrackBar();
            this.tbVerde = new System.Windows.Forms.TrackBar();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnApagar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Black;
            this.btnRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRojo.ForeColor = System.Drawing.Color.Red;
            this.btnRojo.Location = new System.Drawing.Point(12, 247);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(126, 56);
            this.btnRojo.TabIndex = 0;
            this.btnRojo.Text = "ROJO";
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(12, 472);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(126, 42);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "RANDOM";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(736, 345);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(143, 42);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Black;
            this.btnVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerde.ForeColor = System.Drawing.Color.Lime;
            this.btnVerde.Location = new System.Drawing.Point(12, 389);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(126, 54);
            this.btnVerde.TabIndex = 3;
            this.btnVerde.Text = "VERDE";
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Black;
            this.btnAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzul.ForeColor = System.Drawing.Color.Blue;
            this.btnAzul.Location = new System.Drawing.Point(12, 315);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(126, 56);
            this.btnAzul.TabIndex = 4;
            this.btnAzul.Text = "AZUL";
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // tbRojo
            // 
            this.tbRojo.BackColor = System.Drawing.Color.Red;
            this.tbRojo.Location = new System.Drawing.Point(216, 247);
            this.tbRojo.Maximum = 250;
            this.tbRojo.Name = "tbRojo";
            this.tbRojo.Size = new System.Drawing.Size(453, 56);
            this.tbRojo.TabIndex = 6;
            this.tbRojo.Scroll += new System.EventHandler(this.tbRojo_Scroll);
            this.tbRojo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbRojo_MouseDown);
            this.tbRojo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbRojo_MouseMove);
            this.tbRojo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbRojo_MouseUp);
            // 
            // tbAzul
            // 
            this.tbAzul.BackColor = System.Drawing.Color.Blue;
            this.tbAzul.Location = new System.Drawing.Point(216, 315);
            this.tbAzul.Maximum = 255;
            this.tbAzul.Name = "tbAzul";
            this.tbAzul.Size = new System.Drawing.Size(453, 56);
            this.tbAzul.TabIndex = 7;
            this.tbAzul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbAzul_MouseDown);
            this.tbAzul.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbAzul_MouseMove);
            this.tbAzul.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbAzul_MouseUp);
            // 
            // tbVerde
            // 
            this.tbVerde.BackColor = System.Drawing.Color.Lime;
            this.tbVerde.Location = new System.Drawing.Point(216, 396);
            this.tbVerde.Maximum = 255;
            this.tbVerde.Name = "tbVerde";
            this.tbVerde.Size = new System.Drawing.Size(453, 56);
            this.tbVerde.TabIndex = 8;
            this.tbVerde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbVerde_MouseDown);
            this.tbVerde.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbVerde_MouseMove);
            this.tbVerde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbVerde_MouseUp);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(716, 427);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(186, 42);
            this.btnDesconectar.TabIndex = 9;
            this.btnDesconectar.Text = "DESCONECTAR";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Location = new System.Drawing.Point(433, 280);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(14, 16);
            this.lblRojo.TabIndex = 10;
            this.lblRojo.Text = "0";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Location = new System.Drawing.Point(433, 427);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(14, 16);
            this.lblVerde.TabIndex = 11;
            this.lblVerde.Text = "0";
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Location = new System.Drawing.Point(433, 345);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(14, 16);
            this.lblAzul.TabIndex = 12;
            this.lblAzul.Text = "0";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(736, 271);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(142, 22);
            this.txtPuerto.TabIndex = 13;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(736, 504);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(142, 42);
            this.btnApagar.TabIndex = 14;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ledrgb.Properties.Resources.boton_blanco;
            this.pictureBox1.Location = new System.Drawing.Point(347, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(967, 582);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblRojo);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.tbVerde);
            this.Controls.Add(this.tbAzul);
            this.Controls.Add(this.tbRojo);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnRojo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.TrackBar tbRojo;
        private System.Windows.Forms.TrackBar tbAzul;
        private System.Windows.Forms.TrackBar tbVerde;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Timer timer;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

