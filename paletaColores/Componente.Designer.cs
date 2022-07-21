namespace paletaColores
{
    partial class Componente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPaleta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPaleta
            // 
            this.btnPaleta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPaleta.BackgroundImage = global::paletaColores.Properties.Resources.crear_paleta_de_color_secundario;
            this.btnPaleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaleta.Location = new System.Drawing.Point(0, 0);
            this.btnPaleta.Name = "btnPaleta";
            this.btnPaleta.Size = new System.Drawing.Size(121, 97);
            this.btnPaleta.TabIndex = 0;
            this.btnPaleta.UseVisualStyleBackColor = false;
            this.btnPaleta.Click += new System.EventHandler(this.btnPaleta_Click);
            // 
            // Componente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPaleta);
            this.Name = "Componente";
            this.Size = new System.Drawing.Size(118, 94);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPaleta;
    }
}
