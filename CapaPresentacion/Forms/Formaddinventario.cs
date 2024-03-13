﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class Formaddinventario : Form
    {
        public Formaddinventario()
        {
            InitializeComponent();
            customizaDesing();
        }

        private void customizaDesing()
        {
            PanelTornillo.Visible = false;
            panel_tubos.Visible = false;
            panelotros_suministros.Visible = false;
        }

        private void hideSubMenu()
        {
            if (PanelTornillo.Visible == true)
                PanelTornillo.Visible = false;
            if (panel_tubos.Visible == true)
                panel_tubos.Visible = false;
            if (panelotros_suministros.Visible == true)
                panelotros_suministros.Visible = false;

        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelfondoaddInventary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            showsubmenu(panelotros_suministros);
        }

        private void Tubos_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_tubos);
        }

        private void iconButtontornillo_Click(object sender, EventArgs e)
        {
            showsubmenu(PanelTornillo);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelslideinventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tornillos_phillips_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "90872";
            label_nombre_producto.Text = "Tornillos phillips";
            label_precio_producto.Text = "150";
            label_descripcion_producto.Text = "Un paquete de tornillos phillips #8 x 1-1/4 de 100 unidades";
        }

        private void Tornillos_plano_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "10763";
            label_nombre_producto.Text = "Tornillos plano";
            label_precio_producto.Text = "180";
            label_descripcion_producto.Text = "Un paquete de tornillos plano 1/2 planos de 100 unidades ";
        }

        private void tornillo_hexagonal_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "890123";
            label_nombre_producto.Text = "Tornillos hexagonal";
            label_precio_producto.Text = "255";
            label_descripcion_producto.Text = "Un paquete de tornillos hexagonal 1/4 20 de 100 unidades ";

        }

        private void tornillo_estrella_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "98130";
            label_nombre_producto.Text = "Tornillos estrella";
            label_precio_producto.Text = "200";
            label_descripcion_producto.Text = "Un paquete de tornillos estrella #8 x 1-1/2 estrella de 100 unidades ";
        }

        private void tornillo_Pozidriv_btn_Click(object sender, EventArgs e)
        {

            label_id_producto.Text = "81293";
            label_nombre_producto.Text = "Tornillos Pozidriv";
            label_precio_producto.Text = "300";
            label_descripcion_producto.Text = "Un paquete de tornillos Pozidriv 1 / 2 estrella de 100 unidades ";

        }

        private void tornillo_bristol_btn_Click(object sender, EventArgs e)
        {

            label_id_producto.Text = "928132";
            label_nombre_producto.Text = "Tornillos bristol";
            label_precio_producto.Text = "350";
            label_descripcion_producto.Text = "Un paquete de tornillos bristol M8 X 12mm estrella de 100 unidades ";

        }
        private void tubos_drenaje_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "193230";
            label_nombre_producto.Text = "Tubo de drenaje";
            label_precio_producto.Text = "600";
            label_descripcion_producto.Text = "Tubo de 8 pies, 2 pulgadas de diámetro";

        }

        private void tubo_presion_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "152721";
            label_nombre_producto.Text = "Tubo de presion";
            label_precio_producto.Text = "300";
            label_descripcion_producto.Text = "Tubo presion 1/2 pulgadas X 19 pies";
        }

        private void tubosemi_presion_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "193766";
            label_nombre_producto.Text = "Tubo semipresion";
            label_precio_producto.Text = "195";
            label_descripcion_producto.Text = "Tubo semipresion  1/2 X 19";

        }

        private void Pvc_sdr_26_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "1937612";
            label_nombre_producto.Text = "PVC";
            label_precio_producto.Text = "195";
            label_descripcion_producto.Text = "Tubo de conducto de PVC SRV  3mm";
        }

        private void tubo_ppr_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "1937613";
            label_nombre_producto.Text = "Tubo PPR";
            label_precio_producto.Text = "160";
            label_descripcion_producto.Text = "TUBO DE PPR, LÍNEA TERMOFLOW FOSET  1/2";
        }

        private void tubo_flexible_acero_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "15727";
            label_nombre_producto.Text = "Tubo flexible acero";
            label_precio_producto.Text = "50";
            label_descripcion_producto.Text = "Tubos flexibles metálicos 3/4";

        }

        private void Toma_corriente_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "679312";
            label_nombre_producto.Text = "Toma corriente";
            label_precio_producto.Text = "150";
            label_descripcion_producto.Text = "Toma corriente doble aterrizado con tapa color blanco";
        }

        private void Probador_corriente_6_12_v_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "9842";
            label_nombre_producto.Text = "Probador de corriente";
            label_precio_producto.Text = "140";
            label_descripcion_producto.Text = "PROBADOR DE CORRIENTE 6-12 V, TRUPER 6-12 v";
        }

        private void Cajaoctagonal_electrica_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "680319";
            label_nombre_producto.Text = "Caja octagonal eléctrica";
            label_precio_producto.Text = "100";
            label_descripcion_producto.Text = "CAJA OCTAGONAL ELÉCTRICA 3/4 - 1/2";
        }

        private void Alambre_dulce_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "679183";
            label_nombre_producto.Text = "Alambre Dulce";
            label_precio_producto.Text = "55";
            label_descripcion_producto.Text = "ALAMBRE DULCE CORTADO C. 16 se vende por LB";
        }

        private void Alambre_duplex_300v_btn_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "53182";
            label_nombre_producto.Text = "ALAMBRE DUPLEX AWG 300 V";
            label_precio_producto.Text = "20";
            label_descripcion_producto.Text = "ALAMBRE DUPLEX AWG 300 V #16, CORDIFLEX";

        }

        private void Alambre_puas_250mts_Click(object sender, EventArgs e)
        {
            label_id_producto.Text = "91723";
            label_nombre_producto.Text = "Alambre de púa grueso";
            label_precio_producto.Text = "3050";
            label_descripcion_producto.Text = "ALAMBRE PUA GRUESO, CORVISE VENDE POR ROLLO 110MTS-450MTS";
        }

        private void text_box_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_box_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Aceptar_add_inventario_Click(object sender, EventArgs e)
        {

            string id = label_id_producto.Text;
            string nombre = label_nombre_producto.Text;
            string precio = label_precio_producto.Text;
            string descripcionproducto = label_descripcion_producto.Text;
            string cantidad = text_box_cantidad.Text;


            bool productoExiste = VerificarExistenciaProducto(id, nombre);

            DialogResult result = MessageBox.Show("¿Deseas agregar el producto al inventario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (productoExiste)
                {

                    ActualizarStockProducto(id, cantidad);
                }
                else
                {

                    InsertarProducto(id, nombre, precio, descripcionproducto, cantidad);
                }

                // Mostrar mensaje de éxito
                MessageBox.Show("Producto agregado al inventario correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mostrar mensaje de cancelación
                MessageBox.Show("Operación cancelada por el usuario.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private bool VerificarExistenciaProducto(string id, string nombre)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Inventario WHERE SaleID = @ID AND ProductName = @Nombre";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void ActualizarStockProducto(string id, string cantidad)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Inventario SET QuantityAvailable = QuantityAvailable + @Cantidad WHERE SaleID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.ExecuteNonQuery();
                }
            }
        }
       
        private void InsertarProducto(string id, string nombre, string precio, string descripcion, string cantidad)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                connection.Open();
                string query = "INSERT INTO Inventario (SaleID, ProductName, Price, ProductDescription, QuantityAvailable) VALUES (@ID, @Nombre, @Precio, @Descripcion, @Cantidad)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.ExecuteNonQuery();
                }
            }

        }

        private void Formaddinventario_Load(object sender, EventArgs e)
        {

        }
    }
}