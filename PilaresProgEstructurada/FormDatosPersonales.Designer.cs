namespace PilaresProgEstructurada
{
    partial class FormDatosPersonales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnPasoPorValor = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPasoPorReferencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos al Sistema de Registro de Docente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(29, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa tus apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(29, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa tus nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(27, 81);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(171, 20);
            this.txtNombres.TabIndex = 3;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(27, 139);
            this.txtApellidos.MaxLength = 30;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(171, 20);
            this.txtApellidos.TabIndex = 4;
            this.txtApellidos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(59, 174);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 33);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(220, 61);
            this.txtResultado.MaxLength = 30;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(227, 156);
            this.txtResultado.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(83, 231);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // btnPasoPorValor
            // 
            this.btnPasoPorValor.Location = new System.Drawing.Point(32, 256);
            this.btnPasoPorValor.Name = "btnPasoPorValor";
            this.btnPasoPorValor.Size = new System.Drawing.Size(116, 23);
            this.btnPasoPorValor.TabIndex = 8;
            this.btnPasoPorValor.Text = "Paso Por Valor";
            this.btnPasoPorValor.UseVisualStyleBackColor = true;
            this.btnPasoPorValor.Click += new System.EventHandler(this.btnPasoPorValor_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(322, 258);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(125, 20);
            this.txtValor.TabIndex = 9;
            // 
            // btnPasoPorReferencia
            // 
            this.btnPasoPorReferencia.Location = new System.Drawing.Point(166, 256);
            this.btnPasoPorReferencia.Name = "btnPasoPorReferencia";
            this.btnPasoPorReferencia.Size = new System.Drawing.Size(135, 22);
            this.btnPasoPorReferencia.TabIndex = 10;
            this.btnPasoPorReferencia.Text = "Paso Por Referencia";
            this.btnPasoPorReferencia.UseVisualStyleBackColor = true;
            this.btnPasoPorReferencia.Click += new System.EventHandler(this.btnPasoPorReferencia_Click);
            // 
            // FormDatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 295);
            this.Controls.Add(this.btnPasoPorReferencia);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnPasoPorValor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "FormDatosPersonales";
            this.Text = "Sistema Integrado de Nómina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnPasoPorValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPasoPorReferencia;
    }
}