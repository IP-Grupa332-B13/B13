<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ViewProject.aspx.cs" Inherits="TeamProject_Soft.ViewProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Title<br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    Description<br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    Price<br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    Start Date<br />
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    End Date<br />
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
</asp:Content>
