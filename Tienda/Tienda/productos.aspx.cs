using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) //Valida si es la primera vez que se carga la pagina
            {
                using (var cnn = new TiendaEntities())
                {
                    cmbCategorias.DataSource = cnn.Categoria.OrderBy(c => c.NombreCategoria).ToList();
                    cmbCategorias.DataTextField = "NombreCategoria";
                    cmbCategorias.DataValueField = "IdCategoria";
                    cmbCategorias.DataBind();
                }
            }
            
        }

        protected void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarProductosPorCategoria();
        }

        private void ConsultarProductosPorCategoria()
        {
            using (var cnn = new TiendaEntities())
            {
                int idCategoria = int.Parse(cmbCategorias.SelectedValue);
                lstProductos.DataSource = cnn.Producto.Where(p => p.IdCategoria.Equals(idCategoria)).ToList();
                lstProductos.DataTextField = "NombreProducto";
                lstProductos.DataValueField = "IdProducto";
                lstProductos.DataBind();
            }
        }

        protected void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var cnn = new TiendaEntities())
            {
                int idProducto = int.Parse(lstProductos.SelectedValue);
                var productoSeleccionado = cnn.Producto.SingleOrDefault(p => p.IdProducto.Equals(idProducto));
                txtNombreProducto.Text = productoSeleccionado.NombreProducto;
                txtDescripcion.Text = productoSeleccionado.Descripcion;
                txtPrecio.Text = productoSeleccionado.Precio.ToString();
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNombreProducto.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            lstProductos.ClearSelection();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var cnn = new TiendaEntities())
            {
                var nuevoProducto = new Producto() {
                    NombreProducto = txtNombreProducto.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    IdCategoria = int.Parse(cmbCategorias.SelectedValue),
                    Imagen = "IMG"
                };
                cnn.Producto.Add(nuevoProducto);
                cnn.SaveChanges();
                LimpiarFormulario();
                ConsultarProductosPorCategoria();
            }
        }
    }
}