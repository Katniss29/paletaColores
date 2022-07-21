using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class FrmpaletaColores : Form
    {
        public FrmpaletaColores()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnPrueba1.BackColor = cmpPaletaColores.SeleccionDeColores();
            btbPrueba2.BackColor = cmpPaletaColores.SeleccionDeColores();   
            btnPrueba3.BackColor = cmpPaletaColores.SeleccionDeColores();
        }
    }
}
