using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletaColores
{
    public partial class Componente : UserControl
    {
        public Componente()
        {
            InitializeComponent();
        }

        Color colorUtilizado;
    
        public Color SeleccionDeColores()
        {
            return colorUtilizado;
        }

        ColorDialog oColorDialog = new ColorDialog();

        private void btnPaleta_Click(object sender, EventArgs e)
        {
            if (oColorDialog.ShowDialog() == DialogResult.OK)
            {
                colorUtilizado = oColorDialog.Color;
                SeleccionDeColores();
            }
        }
    }
}
