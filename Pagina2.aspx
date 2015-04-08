<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Pagina2.aspx.cs" Inherits="Pagina2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal">
        <asp:ListItem Value="0">SEMESTRE I</asp:ListItem>
        <asp:ListItem Value="1">SEMESTRE III</asp:ListItem>
        <asp:ListItem Value="2">SEMESTRE V</asp:ListItem>
        <asp:ListItem Value="3">SEMESTRE VII</asp:ListItem>
        <asp:ListItem Value="4">SEMESTRE IX</asp:ListItem>
    </asp:RadioButtonList>
    <asp:MultiView ID="MultiView1" runat="server" OnActiveViewChanged="MultiView1_ActiveViewChanged">
        <asp:View ID="View1" runat="server">
            <asp:CheckBoxList ID="CheckBoxList3" runat="server">
                <asp:ListItem Value="4">algebra y geometria</asp:ListItem>
                <asp:ListItem Value="4">sociologia</asp:ListItem>
                <asp:ListItem Value="4">Preopedeutica</asp:ListItem>
                <asp:ListItem Value="4">metodologia de Programacion</asp:ListItem>
                <asp:ListItem Value="4">I. ciencias de la computacion</asp:ListItem>
                <asp:ListItem Value="4">Doctrina Social de la Iglesia</asp:ListItem>
                <asp:ListItem Value="4">I. Ingenieria de Sistemas</asp:ListItem>
            </asp:CheckBoxList>
            <br />
        </asp:View>
        <asp:View ID="View2" runat="server">
            <asp:CheckBoxList ID="CheckBoxList4" runat="server">
                <asp:ListItem>Fisica I</asp:ListItem>
                <asp:ListItem>Calculo Integral</asp:ListItem>
                <asp:ListItem>Teoria General de Sistemas</asp:ListItem>
                <asp:ListItem>Programacion II</asp:ListItem>
                <asp:ListItem>Algoritmia y Estructura De Datos I</asp:ListItem>
                <asp:ListItem>Estructuras Discretas II</asp:ListItem>
            </asp:CheckBoxList>
            <br />
        </asp:View>
        <asp:View ID="View3" runat="server">
            <asp:CheckBoxList ID="CheckBoxList5" runat="server">
                <asp:ListItem>Sistemas De Informacion</asp:ListItem>
                <asp:ListItem>Estadistica y Probabilidad</asp:ListItem>
                <asp:ListItem>Dinamica de Sistemas</asp:ListItem>
                <asp:ListItem>Desarrollo de Aplicaciones II</asp:ListItem>
                <asp:ListItem>Informatica Orientada a la Red I</asp:ListItem>
                <asp:ListItem>Administracion de Empresas</asp:ListItem>
                <asp:ListItem>Sistemas Operativos</asp:ListItem>
            </asp:CheckBoxList>
            <br />
        </asp:View>
        <asp:View ID="View4" runat="server">
            <asp:CheckBoxList ID="CheckBoxList6" runat="server">
                <asp:ListItem>Seguridad de Redes</asp:ListItem>
                <asp:ListItem>Tecnologia Moviles</asp:ListItem>
                <asp:ListItem>Optimizacion de Operaciones</asp:ListItem>
            </asp:CheckBoxList>
            <br />
        </asp:View>
        <asp:View ID="View5" runat="server">
            <asp:CheckBoxList ID="CheckBoxList7" runat="server">
                <asp:ListItem>Proyecto de Investigacion en ingenieria </asp:ListItem>
                <asp:ListItem>Gestion de Informacion y el conocimiento</asp:ListItem>
                <asp:ListItem>Negocios Electronicos</asp:ListItem>
                <asp:ListItem>Etica y Deontologia en Ingenieria</asp:ListItem>
            </asp:CheckBoxList>
            <br />
        </asp:View>
        <br />
    </asp:MultiView>
    <asp:CheckBoxList ID="CheckBoxList2" runat="server" AutoPostBack="True" Font-Names="Arial" Font-Size="8pt" Height="403px" OnSelectedIndexChanged="CheckBoxList2_SelectedIndexChanged" Width="887px" style="margin-top: 87px">
    <asp:ListItem Value="4">Calculo Diferencial</asp:ListItem>
    <asp:ListItem Value="2">Desarrollo Humano</asp:ListItem>
    <asp:ListItem Value="2">Comunicacion Oral y Escrita</asp:ListItem>
    <asp:ListItem Value="4">Fundamentos de la Programacion</asp:ListItem>
    <asp:ListItem Value="5">Programacion I</asp:ListItem>
    <asp:ListItem Value="4">Estructuras Discretas I</asp:ListItem>
    <asp:ListItem Value="4">Calculo Vectorial</asp:ListItem>
    <asp:ListItem Value="3">Bases de Datos</asp:ListItem>
    <asp:ListItem Value="4">Desarrollo de Aplicaciones I</asp:ListItem>
    <asp:ListItem Value="4">Algoritmos y Estructura de Datos II</asp:ListItem>
    <asp:ListItem Value="2">Gestion Financiera</asp:ListItem>
</asp:CheckBoxList>
<asp:Button ID="Button1" runat="server" Text="Matricularse" OnClick="Button1_Click" />
    <asp:Label ID="LabelMensaje" runat="server" Font-Names="Arial" Font-Size="8pt"></asp:Label>
</asp:Content>