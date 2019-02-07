<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MockupGUI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <div>
        <h1>KSU IT Capstone Evaluation Webpage</h1>
    </div>
    <br />
    <br />

    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:TextBox runat="server" placeholder="Enter your KSU email"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow Height="15"></asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:TextBox runat="server" placeholder="Enter your password"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow Height="15"></asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" Text="Login"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
