namespace CargaDatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtOrient = new System.Windows.Forms.TextBox();
            this.txtProfes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEscuela = new System.Windows.Forms.ComboBox();
            this.txtCurso = new System.Windows.Forms.ComboBox();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.btnAgEsc = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.MaskedTextBox();
            this.btnParticular = new System.Windows.Forms.RadioButton();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.btnEstablecimiento = new System.Windows.Forms.RadioButton();
            this.itsc = new System.Windows.Forms.PictureBox();
            this.panelDatos.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itsc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Gray;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.Black;
            this.btnCargar.Location = new System.Drawing.Point(41, 200);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(301, 182);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // txtOrient
            // 
            this.txtOrient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtOrient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrient.Location = new System.Drawing.Point(282, 179);
            this.txtOrient.Name = "txtOrient";
            this.txtOrient.Size = new System.Drawing.Size(826, 41);
            this.txtOrient.TabIndex = 3;
            // 
            // txtProfes
            // 
            this.txtProfes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtProfes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfes.Location = new System.Drawing.Point(385, 338);
            this.txtProfes.Name = "txtProfes";
            this.txtProfes.Size = new System.Drawing.Size(723, 41);
            this.txtProfes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escuela:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "Orientación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 44);
            this.label3.TabIndex = 9;
            this.label3.Text = "Profesor a cargo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(410, 44);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad de alumnos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(634, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 44);
            this.label5.TabIndex = 11;
            this.label5.Text = "Curso/Año:";
            // 
            // txtEscuela
            // 
            this.txtEscuela.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEscuela.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEscuela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtEscuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscuela.FormattingEnabled = true;
            this.txtEscuela.Items.AddRange(new object[] {
            "IPEM 10 ROMA",
            "IPEM 12 PRESIDENTE JUAN DOMINGO PERON",
            "IPEM 19 POETA OSCAR GUIÑAZU ALVAREZ",
            "IPEM 122 DIEGO GOMEZ CASCO",
            "IPEM 136 DR ALFREDO PALACIOS ANEXO",
            "IPEM 169 RAFAEL M. ESCUTI",
            "IPEM 171 BRIGADIER JUAN IGNACIO SAN MARTIN",
            "IPEM 338 DR SALVADOR SALVADOR MAZZA",
            "IPEM 376 NELSON MANDELA",
            "IPEM 82 SANTIAGO PENNA",
            "IPEM 294 JESUS MARIA",
            "IPEM 374 ANEXO",
            "IPEM 350 ERNESTO SABATO"});
            this.txtEscuela.Location = new System.Drawing.Point(233, 27);
            this.txtEscuela.Name = "txtEscuela";
            this.txtEscuela.Size = new System.Drawing.Size(734, 39);
            this.txtEscuela.TabIndex = 2;
            // 
            // txtCurso
            // 
            this.txtCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.FormattingEnabled = true;
            this.txtCurso.Items.AddRange(new object[] {
            "1°",
            "2°",
            "3°",
            "4°",
            "5°",
            "6°",
            "7°"});
            this.txtCurso.Location = new System.Drawing.Point(860, 500);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(248, 44);
            this.txtCurso.TabIndex = 6;
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDatos.Controls.Add(this.btnAgEsc);
            this.panelDatos.Controls.Add(this.txtCant);
            this.panelDatos.Controls.Add(this.txtEscuela);
            this.panelDatos.Controls.Add(this.txtCurso);
            this.panelDatos.Controls.Add(this.txtOrient);
            this.panelDatos.Controls.Add(this.txtProfes);
            this.panelDatos.Controls.Add(this.label1);
            this.panelDatos.Controls.Add(this.label5);
            this.panelDatos.Controls.Add(this.label2);
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.label3);
            this.panelDatos.Location = new System.Drawing.Point(231, 289);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1141, 647);
            this.panelDatos.TabIndex = 15;
            // 
            // btnAgEsc
            // 
            this.btnAgEsc.BackColor = System.Drawing.Color.Gray;
            this.btnAgEsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgEsc.ForeColor = System.Drawing.Color.Black;
            this.btnAgEsc.Location = new System.Drawing.Point(994, 21);
            this.btnAgEsc.Name = "btnAgEsc";
            this.btnAgEsc.Size = new System.Drawing.Size(131, 59);
            this.btnAgEsc.TabIndex = 0;
            this.btnAgEsc.TabStop = false;
            this.btnAgEsc.Text = "AGREGAR ESCUELA";
            this.btnAgEsc.UseVisualStyleBackColor = false;
            // 
            // txtCant
            // 
            this.txtCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.Location = new System.Drawing.Point(448, 506);
            this.txtCant.Mask = "99";
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(64, 41);
            this.txtCant.TabIndex = 5;
            this.txtCant.ValidatingType = typeof(int);
            // 
            // btnParticular
            // 
            this.btnParticular.AutoSize = true;
            this.btnParticular.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticular.Location = new System.Drawing.Point(933, 191);
            this.btnParticular.Name = "btnParticular";
            this.btnParticular.Size = new System.Drawing.Size(213, 48);
            this.btnParticular.TabIndex = 1;
            this.btnParticular.TabStop = true;
            this.btnParticular.Text = "Particular";
            this.btnParticular.UseVisualStyleBackColor = true;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnCargar);
            this.panelBotones.Location = new System.Drawing.Point(1437, 284);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(378, 652);
            this.panelBotones.TabIndex = 16;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.titulo.Font = new System.Drawing.Font("Bahnschrift", 55.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(405, 20);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(1205, 111);
            this.titulo.TabIndex = 17;
            this.titulo.Text = "EXPO CARRERAS  ITSC 2019";
            // 
            // btnEstablecimiento
            // 
            this.btnEstablecimiento.AutoSize = true;
            this.btnEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstablecimiento.Location = new System.Drawing.Point(407, 191);
            this.btnEstablecimiento.Name = "btnEstablecimiento";
            this.btnEstablecimiento.Size = new System.Drawing.Size(327, 48);
            this.btnEstablecimiento.TabIndex = 0;
            this.btnEstablecimiento.TabStop = true;
            this.btnEstablecimiento.Text = "Establecimiento";
            this.btnEstablecimiento.UseVisualStyleBackColor = true;
            this.btnEstablecimiento.CheckedChanged += new System.EventHandler(this.BtnEstablecimiento_CheckedChanged);
            // 
            // itsc
            // 
            this.itsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.itsc.Image = global::CargaDatos.Properties.Resources.logo_2018;
            this.itsc.InitialImage = ((System.Drawing.Image)(resources.GetObject("itsc.InitialImage")));
            this.itsc.Location = new System.Drawing.Point(12, 12);
            this.itsc.Name = "itsc";
            this.itsc.Size = new System.Drawing.Size(170, 208);
            this.itsc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itsc.TabIndex = 12;
            this.itsc.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnEstablecimiento);
            this.Controls.Add(this.btnParticular);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.itsc);
            this.Controls.Add(this.panelDatos);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itsc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtOrient;
        private System.Windows.Forms.TextBox txtProfes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtEscuela;
        private System.Windows.Forms.ComboBox txtCurso;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.RadioButton btnParticular;
        private System.Windows.Forms.PictureBox itsc;
        private System.Windows.Forms.MaskedTextBox txtCant;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.RadioButton btnEstablecimiento;
        private System.Windows.Forms.Button btnAgEsc;
    }
}

