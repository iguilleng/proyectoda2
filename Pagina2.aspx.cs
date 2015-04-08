using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina2 : System.Web.UI.Page
{
    int creditos;
    protected void Page_Load(object sender, EventArgs e)
    {
        creditos=0;
    }
    protected void CheckBoxList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /*
        creditos = 0;
        foreach (ListItem list in CheckBoxList2.Items)
        {
            if (list.Selected == true)
            {
                creditos = creditos + Int32.Parse(CheckBoxList2.SelectedValue);
            }
        }
        if (creditos > 22)
        {
            LabelMensaje.Text = "Limite de Creditos Excedido";
        }
        else
        {
            LabelMensaje.Text = "Matricula Exitosa";
        }
         */
        /////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////
        creditos = 0;
        foreach (ListItem list in CheckBoxList3.Items)
        {
            if (list.Selected == true)
            {
                creditos = creditos + Int32.Parse(CheckBoxList3.SelectedValue);
            }
        }
        if (creditos > 22)
        {
            LabelMensaje.Text = "Limite de Creditos Excedido";
        }
        else
        {
            LabelMensaje.Text = "Matricula Exitosa";
        }

        /*
        creditos = 0;
        foreach (ListItem list in CheckBoxList4.Items)
        {
            if (list.Selected == true)
            {
                creditos = creditos + Int32.Parse(CheckBoxList4.SelectedValue);
            }
        }
        if (creditos > 22)
        {
            LabelMensaje.Text = "Limite de Creditos Excedido";
        }
        else
        {
            LabelMensaje.Text = "Matricula Exitosa";
        }

        creditos = 0;
        foreach (ListItem list in CheckBoxList5.Items)
        {
            if (list.Selected == true)
            {
                creditos = creditos + Int32.Parse(CheckBoxList5.SelectedValue);
            }
        }
        if (creditos > 22)
        {
            LabelMensaje.Text = "Limite de Creditos Excedido";
        }
        else
        {
            LabelMensaje.Text = "Matricula Exitosa";
        }

        creditos = 0;
        foreach (ListItem list in CheckBoxList6.Items)
        {
            if (list.Selected == true)
            {
                creditos = creditos + Int32.Parse(CheckBoxList6.SelectedValue);
            }
        }
        if (creditos > 22)
        {
            LabelMensaje.Text = "Limite de Creditos Excedido";
        }
        else
        {
            LabelMensaje.Text = "Matricula Exitosa";
        }

        creditos = 0;
        foreach (ListItem list in CheckBoxList7.Items)
        {
            if (list.Selected == true)
            {
                creditos = creditos + Int32.Parse(CheckBoxList7.SelectedValue);
            }
        }
        if (creditos > 22)
        {
            LabelMensaje.Text = "Limite de Creditos Excedido";
        }
        else
        {
            LabelMensaje.Text = "Matricula Exitosa";
        }
         */
    }
    protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = Int32.Parse(RadioButtonList1.SelectedValue);
    }
}