using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador_tarea
{
    public partial class Form1 : Form
    {
        List<string> Favoritos = new List<string>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            WebB.Navigate(NavTxt.Text);
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            WebB.GoBack();
        }

        private void Adelante_Click(object sender, EventArgs e)
        {
            WebB.GoForward();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            WebB.Refresh();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            WebB.Stop();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            WebB.GoHome();
        }

        private void FavBtn_Click(object sender, EventArgs e)
        {
            Favoritos.Add(WebB.Url.ToString());
            refreshCmb();
        }
        private void refreshCmb()
        {
            foreach(string direccion in Favoritos)
            {
                FavCmb.Items.Add(direccion);
            }
        }

        private void FavCmb_Click(object sender, EventArgs e)
        {

        }

        private void FavCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebB.Navigate(FavCmb.SelectedItem.ToString());
        }
    }
}
