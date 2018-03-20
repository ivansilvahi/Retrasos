namespace Retrasos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblrut = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcurso = new System.Windows.Forms.Label();
            this.lblrun = new System.Windows.Forms.Label();
            this.txtrut = new System.Windows.Forms.TextBox();
            this.txtrun = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcurso = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblhora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtAtrasos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltitulo.Location = new System.Drawing.Point(206, 38);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(418, 54);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Colegio San Mateo";
            // 
            // lblrut
            // 
            this.lblrut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblrut.AutoSize = true;
            this.lblrut.BackColor = System.Drawing.Color.Transparent;
            this.lblrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblrut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblrut.Location = new System.Drawing.Point(46, 205);
            this.lblrut.Name = "lblrut";
            this.lblrut.Size = new System.Drawing.Size(127, 22);
            this.lblrut.TabIndex = 1;
            this.lblrut.Text = "Ingrese RUT : ";
            // 
            // lblnombre
            // 
            this.lblnombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblnombre.Location = new System.Drawing.Point(46, 245);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(88, 22);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre : ";
            // 
            // lblcurso
            // 
            this.lblcurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblcurso.AutoSize = true;
            this.lblcurso.BackColor = System.Drawing.Color.Transparent;
            this.lblcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblcurso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcurso.Location = new System.Drawing.Point(46, 296);
            this.lblcurso.Name = "lblcurso";
            this.lblcurso.Size = new System.Drawing.Size(73, 22);
            this.lblcurso.TabIndex = 3;
            this.lblcurso.Text = "Curso : ";
            // 
            // lblrun
            // 
            this.lblrun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblrun.AutoSize = true;
            this.lblrun.BackColor = System.Drawing.Color.Transparent;
            this.lblrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblrun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblrun.Location = new System.Drawing.Point(46, 351);
            this.lblrun.Name = "lblrun";
            this.lblrun.Size = new System.Drawing.Size(63, 22);
            this.lblrun.TabIndex = 4;
            this.lblrun.Text = "RUT : ";
            // 
            // txtrut
            // 
            this.txtrut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txtrut.Location = new System.Drawing.Point(164, 200);
            this.txtrut.MaxLength = 8;
            this.txtrut.Name = "txtrut";
            this.txtrut.Size = new System.Drawing.Size(181, 27);
            this.txtrut.TabIndex = 0;
            this.txtrut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrut_KeyPress);
            // 
            // txtrun
            // 
            this.txtrun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txtrun.Location = new System.Drawing.Point(164, 346);
            this.txtrun.Name = "txtrun";
            this.txtrun.Size = new System.Drawing.Size(181, 27);
            this.txtrun.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txtnombre.Location = new System.Drawing.Point(164, 245);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(365, 27);
            this.txtnombre.TabIndex = 3;
            // 
            // txtcurso
            // 
            this.txtcurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txtcurso.Location = new System.Drawing.Point(164, 296);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(181, 27);
            this.txtcurso.TabIndex = 4;
            // 
            // btningresar
            // 
            this.btningresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btningresar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btningresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btningresar.Image = global::Retrasos.Properties.Resources.search;
            this.btningresar.Location = new System.Drawing.Point(381, 194);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(42, 40);
            this.btningresar.TabIndex = 1;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.TextChanged += new System.EventHandler(this.btningresar_Click);
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnactualizar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnactualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnactualizar.Image = global::Retrasos.Properties.Resources.clear;
            this.btnactualizar.Location = new System.Drawing.Point(431, 194);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(45, 40);
            this.btnactualizar.TabIndex = 2;
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.TextChanged += new System.EventHandler(this.btnactualizar_Click);
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblhora
            // 
            this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblhora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblhora.Location = new System.Drawing.Point(272, 401);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(20, 29);
            this.lblhora.TabIndex = 6;
            this.lblhora.Text = ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(280, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sistema de Atrasos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Location = new System.Drawing.Point(544, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // txtAtrasos
            // 
            this.txtAtrasos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAtrasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F);
            this.txtAtrasos.Location = new System.Drawing.Point(400, 296);
            this.txtAtrasos.Name = "txtAtrasos";
            this.txtAtrasos.Size = new System.Drawing.Size(105, 77);
            this.txtAtrasos.TabIndex = 10;
            this.txtAtrasos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(407, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad Atrasos";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(541, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fotografia Alumno";
            // 
            // DgvAlumnos
            // 
            this.DgvAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlumnos.Location = new System.Drawing.Point(277, 456);
            this.DgvAlumnos.Name = "DgvAlumnos";
            this.DgvAlumnos.Size = new System.Drawing.Size(252, 186);
            this.DgvAlumnos.TabIndex = 13;
            // 
            // Form1
            // 
            this.AcceptButton = this.btningresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(751, 654);
            this.Controls.Add(this.DgvAlumnos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAtrasos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcurso);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtrun);
            this.Controls.Add(this.txtrut);
            this.Controls.Add(this.lblrun);
            this.Controls.Add(this.lblcurso);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblrut);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblrut;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcurso;
        private System.Windows.Forms.Label lblrun;
        private System.Windows.Forms.TextBox txtrut;
        private System.Windows.Forms.TextBox txtrun;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcurso;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtAtrasos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvAlumnos;
    }
}

