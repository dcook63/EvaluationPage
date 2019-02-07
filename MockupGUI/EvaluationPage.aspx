<%@ Page Title="Evaluation Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EvaluationPage.aspx.cs" Inherits="MockupGUI.EvaluationPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <div>
        <h1>KSU IT Capstone Evaluation Webpage</h1>
    </div>
    <br />
    <br />

    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" text="Enter Team Member's Name"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" placeholder="Last, First"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow Height="30"></asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" Text="Rate your team members ability to research the topic"></asp:Label>
            </asp:TableCell>

            <asp:TableCell></asp:TableCell>

            <asp:TableCell>
                <asp:dropdownlist runat="server" id="evalQ1">
                    <asp:ListItem Text="1 - Very Poor"></asp:ListItem>
                    <asp:ListItem Text="2 - Poor"></asp:ListItem>
                    <asp:ListItem Text="3 - OK"></asp:ListItem>
                    <asp:ListItem Text="4 - Very Good"></asp:ListItem>
                    <asp:ListItem Text="5 - Excellent"></asp:ListItem>
                </asp:dropdownlist>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow Height="10"></asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" Text="Rate your team members ability to communicate with the group"></asp:Label>
            </asp:TableCell>

            <asp:TableCell></asp:TableCell>

            <asp:TableCell>
                <asp:dropdownlist runat="server" id="evalQ2">
                    <asp:ListItem Text="1 - Very Poor"></asp:ListItem>
                    <asp:ListItem Text="2 - Poor"></asp:ListItem>
                    <asp:ListItem Text="3 - OK"></asp:ListItem>
                    <asp:ListItem Text="4 - Very Good"></asp:ListItem>
                    <asp:ListItem Text="5 - Excellent"></asp:ListItem>
                </asp:dropdownlist>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow Height="30"></asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" Text="Submit"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Add Team Member"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>