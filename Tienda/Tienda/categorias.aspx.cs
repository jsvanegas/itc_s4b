using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class categorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultarCategorias();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            using (var cnn = new TiendaEntities())
            {
                var nuevaCategoria = new Categoria() {
                    NombreCategoria = txtNombre.Text,
                    Imagen = txtImagen.Text
                };
                cnn.Categoria.Add(nuevaCategoria);
                cnn.SaveChanges();
                ConsultarCategorias();
            }
        }

        private void ConsultarCategorias() {
            using (var cnn = new TiendaEntities())
            {
                lstCategorias.DataSource = cnn.Categoria.ToList();
                lstCategorias.DataTextField = "NombreCategoria"; // -> Lo que se muestra
                lstCategorias.DataValueField = "IdCategoria"; // -> Lo que vale cada opcion
                lstCategorias.DataBind();
            } // --> Cierra la conexion a la BD
        }
    }
}