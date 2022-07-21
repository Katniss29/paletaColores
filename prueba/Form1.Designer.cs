namespace prueba
{
    partial class FrmpaletaColores
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
            this.cmpPaletaColores = new paletaColores.Componente();
            this.btnPrueba1 = new System.Windows.Forms.Button();
            this.btbPrueba2 = new System.Windows.Forms.Button();
            this.btnPrueba3 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmpPaletaColores
            // 
            this.cmpPaletaColores.Location = new System.Drawing.Point(240, 194);
            this.cmpPaletaColores.Name = "cmpPaletaColores";
            this.cmpPaletaColores.Size = new System.Drawing.Size(122, 99);
            this.cmpPaletaColores.TabIndex = 0;
            // 
            // btnPrueba1
            // 
            this.btnPrueba1.Location = new System.Drawing.Point(77, 69);
            this.btnPrueba1.Name = "btnPrueba1";
            this.btnPrueba1.Size = new System.Drawing.Size(91, 65);
            this.btnPrueba1.TabIndex = 1;
            this.btnPrueba1.UseVisualStyleBackColor = true;
            // 
            // btbPrueba2
            // 
            this.btbPrueba2.Location = new System.Drawing.Point(240, 69);
            this.btbPrueba2.Name = "btbPrueba2";
            this.btbPrueba2.Size = new System.Drawing.Size(91, 65);
            this.btbPrueba2.TabIndex = 2;
            this.btbPrueba2.UseVisualStyleBackColor = true;
            // 
            // btnPrueba3
            // 
            this.btnPrueba3.Location = new System.Drawing.Point(404, 69);
            this.btnPrueba3.Name = "btnPrueba3";
            this.btnPrueba3.Size = new System.Drawing.Size(91, 65);
            this.btnPrueba3.TabIndex = 3;
            this.btnPrueba3.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(529, 215);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 65);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmpaletaColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnPrueba3);
            this.Controls.Add(this.btbPrueba2);
            this.Controls.Add(this.btnPrueba1);
            this.Controls.Add(this.cmpPaletaColores);
            this.Name = "FrmpaletaColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba";
            this.ResumeLayout(false);

        }

        #endregion

        private paletaColores.Componente cmpPaletaColores;
        private System.Windows.Forms.Button btnPrueba1;
        private System.Windows.Forms.Button btbPrueba2;
        private System.Windows.Forms.Button btnPrueba3;
        private System.Windows.Forms.Button btnActualizar;
    }
}

