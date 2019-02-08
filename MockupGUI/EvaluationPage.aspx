<%@ Page Title="Evaluation Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EvaluationPage.aspx.cs" Inherits="MockupGUI.EvaluationPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
            overflow: hidden;
            background-color: #333;
            position: fixed;
            top: 0;
            width: 100%;
            padding-left: 20px;
            padding-right:30px;
        }
        li {
            float: left;
        }
        li a {
            display: block;
            color: white;
            text-align: center;
            padding: 10px 20px;
            text-decoration: none;
        }
        li a:hover {
            background-color: #111;
        }
        .active {
            background-color: #ffd800
        }
        .margin {
            margin: 30px;
        }
    </style>

    <div>
        <ul>
            <li><a href="LandingPage.aspx">Home</a></li>
            <li class="active"><a href="EvaluationPage.aspx">Evaluation Form</a></li>
            <li><a href="EvaluationPage.aspx">Other Form</a></li>
            <li><a href="EvaluationPage.aspx">Test Page</a></li>
            <li style="float:right"><a href="Login.aspx">Logout</a></li>
        </ul>
    </div>

    <div class="margin">
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
        <br />
    </div>
</asp:Content>