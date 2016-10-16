using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtSenha_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {

        if(txtUsuario.Text == "Vinny" || txtUsuario.Text == "admin" || txtUsuario.Text == "Leonardo")
        {
            args.IsValid = true;
        }

    }

    protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (txtSenha.Text == "123" || txtSenha.Text == "password")
        {
            args.IsValid = true;
        }

    }

    protected void btnLogar_Click(object sender, EventArgs e)
    {
        Session["usuario"] = txtUsuario.Text.ToString();
        if (this.IsValid)
        Response.Redirect("Area Administrativa.aspx");
        
        

    }
}