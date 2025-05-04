namespace EjercicioTres
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
            this.lstEspectadores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnNuevoEspectador = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregarDespues = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.lblTotaRecaudado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEspectadores
            // 
            this.lstEspectadores.FormattingEnabled = true;
            this.lstEspectadores.Location = new System.Drawing.Point(445, 12);
            this.lstEspectadores.Name = "lstEspectadores";
            this.lstEspectadores.Size = new System.Drawing.Size(343, 420);
            this.lstEspectadores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(15, 77);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(166, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(15, 132);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(166, 20);
            this.txtEdad.TabIndex = 6;
            // 
            // btnNuevoEspectador
            // 
            this.btnNuevoEspectador.Location = new System.Drawing.Point(15, 183);
            this.btnNuevoEspectador.Name = "btnNuevoEspectador";
            this.btnNuevoEspectador.Size = new System.Drawing.Size(166, 30);
            this.btnNuevoEspectador.TabIndex = 7;
            this.btnNuevoEspectador.Text = "Ingresar";
            this.btnNuevoEspectador.UseVisualStyleBackColor = true;
            this.btnNuevoEspectador.Click += new System.EventHandler(this.btnNuevoEspectador_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(243, 22);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(166, 30);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(243, 77);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(166, 30);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregarDespues
            // 
            this.btnAgregarDespues.Location = new System.Drawing.Point(243, 132);
            this.btnAgregarDespues.Name = "btnAgregarDespues";
            this.btnAgregarDespues.Size = new System.Drawing.Size(166, 30);
            this.btnAgregarDespues.TabIndex = 10;
            this.btnAgregarDespues.Text = "Agregar Despues";
            this.btnAgregarDespues.UseVisualStyleBackColor = true;
            this.btnAgregarDespues.Click += new System.EventHandler(this.btnAgregarDespues_Click);
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(243, 183);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(166, 30);
            this.btnListado.TabIndex = 11;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // lblTotaRecaudado
            // 
            this.lblTotaRecaudado.AutoSize = true;
            this.lblTotaRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaRecaudado.Location = new System.Drawing.Point(165, 305);
            this.lblTotaRecaudado.Name = "lblTotaRecaudado";
            this.lblTotaRecaudado.Size = new System.Drawing.Size(0, 25);
            this.lblTotaRecaudado.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total recaudado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotaRecaudado);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.btnAgregarDespues);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevoEspectador);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEspectadores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio Tres";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEspectadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnNuevoEspectador;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregarDespues;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Label lblTotaRecaudado;
        private System.Windows.Forms.Label label4;
    }
}

