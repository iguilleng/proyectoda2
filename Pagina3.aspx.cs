using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        initPositionRol();
    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
       
    }
    protected void Grabar_Click(object sender, EventArgs e)
    {
        string posicion = " ";
        if (RadioButtonList1.SelectedValue == "Ciencias de la Salud")
            posicion = "Ciencias de la Salud";
        if (RadioButtonList1.SelectedValue == "Ciencias e Ingenierías")
            posicion = "Ciencias e Ingenierías";
        if (RadioButtonList1.SelectedValue == "Ciencias Jurídicas y Empresariales")
            posicion = "Ciencias Jurídicas y Empresariales";
        if (RadioButtonList1.SelectedValue == "Ciencias Sociales")
            posicion = "Ciencias Sociales";

        InfoLabel.Text = "Nombre : " + Nombre.Text + "   " + Apellido.Text + "Codigo  :" + Codigo.Text +" Escuela: "+ RadioButtonList1.SelectedItem +" Programa Professional : " +Rol.SelectedItem;
        RadioButtonList1.SelectedIndex = 0;
    }
    protected void Limpiar_Click(object sender, EventArgs e)
    {
        Nombre.Text = "";
        Apellido.Text = "";
        initPositionRol();
        Codigo.Text = "";
        RadioButtonList1.SelectedIndex = 0;
        
        InfoLabel.Text = "";
    }
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    private void initPositionRol()
    {
        Rol.Items.Clear();
        Rol.Enabled = true;
        Rol.Items.Add("Enfermeria");
        Rol.Items.Add("Medicina Humana");
        Rol.Items.Add("Odontologia");
        Rol.Items.Add("Ingenieria Biotecnológica");
        Rol.Items.Add("Farmacia y Bioquímica");
        Rol.Items.Add("Obstetricia y Puericultura");
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.Items[0].Selected == true)
            initPositionRol();
        if (RadioButtonList1.Items[1].Selected == true)
        {
            Rol.Items.Clear();
            Rol.Enabled = true;
            Rol.Items.Add("Analista");
            Rol.Items.Add("Diseñador");
            Rol.Items.Add("Desarrollador");

        }
        if (RadioButtonList1.Items[2].Selected == true)
        {
            Rol.Items.Clear();
            Rol.Enabled = true;
            Rol.Items.Add("GERENTE EN  VENTAS");
            Rol.Items.Add("GERENTE EN  MARKETING");
            Rol.Items.Add("GERENTE EN  PRODUCCION");
            Rol.Items.Add("GERENTE EN  RECURSOS HUMANOS");
        }
        if (RadioButtonList1.Items[3].Selected == true)
        {
            Rol.Items.Clear();
            Rol.Enabled = false;
        }

    }
}