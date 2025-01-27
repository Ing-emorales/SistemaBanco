using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnOcultarMenu_Click(object sender, EventArgs e)
        {
            if(PanelMenu.Width==200)
            {
                PanelMenu.Width = 40;
            }
            else
            {
                PanelMenu.Width=200;
            }
        }
    }
}
