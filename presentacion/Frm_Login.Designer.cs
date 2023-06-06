namespace presentacion
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Pnl_Imagen = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Pnl_login = new System.Windows.Forms.Panel();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Iniciar = new System.Windows.Forms.Button();
            this.Txtpassword_us = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtlogin_us = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Imagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnl_titulo.SuspendLayout();
            this.Pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Imagen
            // 
            this.Pnl_Imagen.Controls.Add(this.pictureBox1);
            this.Pnl_Imagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Imagen.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Imagen.Name = "Pnl_Imagen";
            this.Pnl_Imagen.Size = new System.Drawing.Size(323, 470);
            this.Pnl_Imagen.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(82)))), ((int)(((byte)(146)))));
            this.Pnl_titulo.Controls.Add(this.label3);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.ForeColor = System.Drawing.Color.Black;
            this.Pnl_titulo.Location = new System.Drawing.Point(323, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(459, 100);
            this.Pnl_titulo.TabIndex = 1;
            this.Pnl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_titulo_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(129, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sistemas de ventas";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // Pnl_login
            // 
            this.Pnl_login.BackColor = System.Drawing.Color.Gainsboro;
            this.Pnl_login.Controls.Add(this.Btn_Salir);
            this.Pnl_login.Controls.Add(this.Btn_Iniciar);
            this.Pnl_login.Controls.Add(this.Txtpassword_us);
            this.Pnl_login.Controls.Add(this.label2);
            this.Pnl_login.Controls.Add(this.Txtlogin_us);
            this.Pnl_login.Controls.Add(this.label1);
            this.Pnl_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_login.Location = new System.Drawing.Point(323, 100);
            this.Pnl_login.Name = "Pnl_login";
            this.Pnl_login.Size = new System.Drawing.Size(459, 370);
            this.Pnl_login.TabIndex = 2;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Red;
            this.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Btn_Salir.Location = new System.Drawing.Point(257, 200);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(142, 60);
            this.Btn_Salir.TabIndex = 13;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Iniciar
            // 
            this.Btn_Iniciar.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_Iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Iniciar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Btn_Iniciar.Location = new System.Drawing.Point(93, 200);
            this.Btn_Iniciar.Name = "Btn_Iniciar";
            this.Btn_Iniciar.Size = new System.Drawing.Size(142, 60);
            this.Btn_Iniciar.TabIndex = 12;
            this.Btn_Iniciar.Text = "Iniciar";
            this.Btn_Iniciar.UseVisualStyleBackColor = false;
            this.Btn_Iniciar.Click += new System.EventHandler(this.Btn_Iniciar_Click);
            // 
            // Txtpassword_us
            // 
            this.Txtpassword_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtpassword_us.Location = new System.Drawing.Point(144, 149);
            this.Txtpassword_us.MaxLength = 20;
            this.Txtpassword_us.Name = "Txtpassword_us";
            this.Txtpassword_us.PasswordChar = '*';
            this.Txtpassword_us.Size = new System.Drawing.Size(230, 24);
            this.Txtpassword_us.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password:";
            // 
            // Txtlogin_us
            // 
            this.Txtlogin_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtlogin_us.Location = new System.Drawing.Point(144, 110);
            this.Txtlogin_us.MaxLength = 20;
            this.Txtlogin_us.Name = "Txtlogin_us";
            this.Txtlogin_us.Size = new System.Drawing.Size(230, 24);
            this.Txtlogin_us.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login:";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 470);
            this.Controls.Add(this.Pnl_login);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.Pnl_Imagen);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.Pnl_Imagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.Pnl_login.ResumeLayout(false);
            this.Pnl_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Imagen;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel Pnl_login;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Iniciar;
        private System.Windows.Forms.TextBox Txtpassword_us;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtlogin_us;
        private System.Windows.Forms.Label label1;
    }
}