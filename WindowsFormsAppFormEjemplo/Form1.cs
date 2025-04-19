using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBibliotecaEjemplo;

namespace WindowsFormsAppFormEjemplo
{
    public partial class Form1 : Form
    {
        // Constructor del formulario
        public Form1()
        {
            InitializeComponent(); // Inicializa todos los controles (botones, cajas de texto, etc.)
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Creamos un nuevo producto
            Producto producto = new Producto();

            // Asignamos el texto que el usuario ingresó en la caja de texto del nombre
            producto.Nombre = txtNombre.Text;

            // Intentamos convertir el texto ingresado como precio a tipo decimal
            if (decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                // Si se pudo convertir correctamente, asignamos el precio al producto
                producto.Precio = precio;

                // Mostramos la descripción del producto en una etiqueta (label)
                lblResultado.Text = producto.ObtenerDescripcion();
            }
            else
            {
                // Si el precio no es válido, mostramos un mensaje de error
                MessageBox.Show("Ingresa un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
