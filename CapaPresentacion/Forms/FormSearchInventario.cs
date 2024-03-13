using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormSearchInventario : Form
    {
        public FormSearchInventario()
        {
            InitializeComponent();
            panel_search_load.Paint += new PaintEventHandler(panel_search_load_Paint);
        }
        N_Empleados objNegocio = new N_Empleados(); 

        private void labelTitleStock_Click(object sender, EventArgs e)
        {

        }

        private void labelTitleName_Click(object sender, EventArgs e)
        {

        }

        private void TituloDelete_Click(object sender, EventArgs e)
        {

        }

        private void Name_label_search_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormSearchInventario_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string terminoBusqueda = TextBoxSearch.Text;

            Producto productoEncontrado = objNegocio.N_BuscarProductoEnBD(terminoBusqueda);

            if (productoEncontrado != null)
            {
                Label_Name_find.Text = productoEncontrado.ProductName;
                Label_Price_find.Text = productoEncontrado.Price.ToString("0.00");
                Label_stock_find.Text = productoEncontrado.QuantityAvaible.ToString();
                Label_Decription_find.Text = productoEncontrado.ProductDescription;
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel_search_load_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(panel_search_load.ClientRectangle, Color.FromArgb(10, 61, 124), Color.FromArgb(14, 87, 176), LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panel_search_load.ClientRectangle);
            }
        }

        private void labelTitleDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void labelTitlePrice_Click(object sender, EventArgs e)
        {

        }
    }
}