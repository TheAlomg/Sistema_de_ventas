namespace presentacion
{
    partial class Frm_Empresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empresas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_tareas = new System.Windows.Forms.Panel();
            this.Btn_Retornar = new System.Windows.Forms.Button();
            this.Btn_Estado = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_trabajo = new System.Windows.Forms.Panel();
            this.Txt_Ndocumento_em = new System.Windows.Forms.TextBox();
            this.Txt_Correo_em = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_Telefono_em = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Direccion_em = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nombre_em = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_tareas.SuspendLayout();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_trabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_tareas
            // 
            this.pnl_tareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnl_tareas.Controls.Add(this.Btn_Retornar);
            this.pnl_tareas.Controls.Add(this.Btn_Estado);
            this.pnl_tareas.Controls.Add(this.Btn_Actualizar);
            this.pnl_tareas.Controls.Add(this.Btn_Nuevo);
            this.pnl_tareas.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_tareas.Location = new System.Drawing.Point(795, 0);
            this.pnl_tareas.Name = "pnl_tareas";
            this.pnl_tareas.Size = new System.Drawing.Size(200, 519);
            this.pnl_tareas.TabIndex = 0;
            // 
            // Btn_Retornar
            // 
            this.Btn_Retornar.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Retornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Retornar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Retornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Retornar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Retornar.Location = new System.Drawing.Point(14, 452);
            this.Btn_Retornar.Name = "Btn_Retornar";
            this.Btn_Retornar.Size = new System.Drawing.Size(172, 45);
            this.Btn_Retornar.TabIndex = 3;
            this.Btn_Retornar.Text = "Retornar";
            this.Btn_Retornar.UseVisualStyleBackColor = false;
            this.Btn_Retornar.Click += new System.EventHandler(this.Btn_Retornar_Click);
            // 
            // Btn_Estado
            // 
            this.Btn_Estado.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Btn_Estado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Estado.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Estado.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Estado.Location = new System.Drawing.Point(14, 240);
            this.Btn_Estado.Name = "Btn_Estado";
            this.Btn_Estado.Size = new System.Drawing.Size(172, 45);
            this.Btn_Estado.TabIndex = 2;
            this.Btn_Estado.Text = "Estado de Empresa";
            this.Btn_Estado.UseVisualStyleBackColor = false;
            this.Btn_Estado.Click += new System.EventHandler(this.Btn_Estado_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Btn_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Actualizar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Actualizar.Location = new System.Drawing.Point(14, 172);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(172, 45);
            this.Btn_Actualizar.TabIndex = 1;
            this.Btn_Actualizar.Text = "Actualizar Empresa";
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Nuevo.Location = new System.Drawing.Point(14, 95);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(172, 45);
            this.Btn_Nuevo.TabIndex = 0;
            this.Btn_Nuevo.Text = "Nueva Empresa";
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(125)))), ((int)(((byte)(168)))));
            this.pnl_titulo.Controls.Add(this.pictureBox1);
            this.pnl_titulo.Controls.Add(this.label1);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(795, 70);
            this.pnl_titulo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(73, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresas";
            // 
            // pnl_trabajo
            // 
            this.pnl_trabajo.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_trabajo.Controls.Add(this.Txt_Ndocumento_em);
            this.pnl_trabajo.Controls.Add(this.Txt_Correo_em);
            this.pnl_trabajo.Controls.Add(this.label10);
            this.pnl_trabajo.Controls.Add(this.label12);
            this.pnl_trabajo.Controls.Add(this.Txt_Telefono_em);
            this.pnl_trabajo.Controls.Add(this.Btn_Buscar);
            this.pnl_trabajo.Controls.Add(this.dgvlistado);
            this.pnl_trabajo.Controls.Add(this.Txt_Buscar);
            this.pnl_trabajo.Controls.Add(this.label11);
            this.pnl_trabajo.Controls.Add(this.Btn_guardar);
            this.pnl_trabajo.Controls.Add(this.Btn_cancelar);
            this.pnl_trabajo.Controls.Add(this.label9);
            this.pnl_trabajo.Controls.Add(this.label8);
            this.pnl_trabajo.Controls.Add(this.label7);
            this.pnl_trabajo.Controls.Add(this.label6);
            this.pnl_trabajo.Controls.Add(this.label5);
            this.pnl_trabajo.Controls.Add(this.Txt_Direccion_em);
            this.pnl_trabajo.Controls.Add(this.label4);
            this.pnl_trabajo.Controls.Add(this.label3);
            this.pnl_trabajo.Controls.Add(this.Txt_Nombre_em);
            this.pnl_trabajo.Controls.Add(this.label2);
            this.pnl_trabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_trabajo.Location = new System.Drawing.Point(0, 70);
            this.pnl_trabajo.Name = "pnl_trabajo";
            this.pnl_trabajo.Size = new System.Drawing.Size(795, 449);
            this.pnl_trabajo.TabIndex = 2;
            // 
            // Txt_Ndocumento_em
            // 
            this.Txt_Ndocumento_em.Enabled = false;
            this.Txt_Ndocumento_em.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Ndocumento_em.Location = new System.Drawing.Point(451, 46);
            this.Txt_Ndocumento_em.MaxLength = 20;
            this.Txt_Ndocumento_em.Name = "Txt_Ndocumento_em";
            this.Txt_Ndocumento_em.Size = new System.Drawing.Size(260, 24);
            this.Txt_Ndocumento_em.TabIndex = 23;
            // 
            // Txt_Correo_em
            // 
            this.Txt_Correo_em.Enabled = false;
            this.Txt_Correo_em.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Correo_em.Location = new System.Drawing.Point(451, 103);
            this.Txt_Correo_em.MaxLength = 180;
            this.Txt_Correo_em.Name = "Txt_Correo_em";
            this.Txt_Correo_em.Size = new System.Drawing.Size(260, 24);
            this.Txt_Correo_em.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(431, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(448, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "Correo:";
            // 
            // Txt_Telefono_em
            // 
            this.Txt_Telefono_em.Enabled = false;
            this.Txt_Telefono_em.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Telefono_em.Location = new System.Drawing.Point(23, 150);
            this.Txt_Telefono_em.MaxLength = 50;
            this.Txt_Telefono_em.Name = "Txt_Telefono_em";
            this.Txt_Telefono_em.Size = new System.Drawing.Size(243, 24);
            this.Txt_Telefono_em.TabIndex = 18;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Buscar.Location = new System.Drawing.Point(477, 271);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(81, 36);
            this.Btn_Buscar.TabIndex = 17;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // dgvlistado
            // 
            this.dgvlistado.AllowUserToAddRows = false;
            this.dgvlistado.AllowUserToDeleteRows = false;
            this.dgvlistado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlistado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlistado.ColumnHeadersHeight = 40;
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvlistado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvlistado.EnableHeadersVisualStyles = false;
            this.dgvlistado.Location = new System.Drawing.Point(23, 315);
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlistado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvlistado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvlistado.Size = new System.Drawing.Size(602, 122);
            this.dgvlistado.TabIndex = 16;
            this.dgvlistado.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistado_CellEnter);
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Buscar.Location = new System.Drawing.Point(23, 276);
            this.Txt_Buscar.MaxLength = 20;
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(438, 24);
            this.Txt_Buscar.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Buscar:";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(110)))), ((int)(((byte)(117)))));
            this.Btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_guardar.Location = new System.Drawing.Point(317, 197);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(158, 36);
            this.Btn_guardar.TabIndex = 13;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Visible = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_cancelar.Location = new System.Drawing.Point(108, 197);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(158, 36);
            this.Btn_cancelar.TabIndex = 12;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Visible = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(3, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(4, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(3, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(431, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefono:";
            // 
            // Txt_Direccion_em
            // 
            this.Txt_Direccion_em.Enabled = false;
            this.Txt_Direccion_em.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Direccion_em.Location = new System.Drawing.Point(23, 91);
            this.Txt_Direccion_em.MaxLength = 180;
            this.Txt_Direccion_em.Name = "Txt_Direccion_em";
            this.Txt_Direccion_em.Size = new System.Drawing.Size(374, 24);
            this.Txt_Direccion_em.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero Docuemento:";
            // 
            // Txt_Nombre_em
            // 
            this.Txt_Nombre_em.Enabled = false;
            this.Txt_Nombre_em.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre_em.Location = new System.Drawing.Point(23, 31);
            this.Txt_Nombre_em.MaxLength = 180;
            this.Txt_Nombre_em.Name = "Txt_Nombre_em";
            this.Txt_Nombre_em.Size = new System.Drawing.Size(374, 24);
            this.Txt_Nombre_em.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // Frm_Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 519);
            this.Controls.Add(this.pnl_trabajo);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.pnl_tareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Empresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.Frm_Empresas_Load);
            this.pnl_tareas.ResumeLayout(false);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_trabajo.ResumeLayout(false);
            this.pnl_trabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_tareas;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Panel pnl_trabajo;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Retornar;
        private System.Windows.Forms.Button Btn_Estado;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Direccion_em;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Nombre_em;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_Telefono_em;
        private System.Windows.Forms.TextBox Txt_Correo_em;
        private System.Windows.Forms.TextBox Txt_Ndocumento_em;
    }
}