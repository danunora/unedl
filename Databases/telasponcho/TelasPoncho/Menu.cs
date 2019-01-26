using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasPoncho
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void tapetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tapetes tapetes = new Tapetes();
            tapetes.MdiParent = this;
            tapetes.Show();
        }

        private void BrowseClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseClientes bc = new BrowseClientes();
            bc.MdiParent = this;
            bc.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
