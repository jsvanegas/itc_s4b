using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntroduccionASP
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCaja1.Text = "Hola Mundo";
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            txtCaja2.Text = txtCaja1.Text;
            txtCaja1.Text = "";
        }
    }
}