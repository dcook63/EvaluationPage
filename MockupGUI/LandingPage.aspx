<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="MockupGUI.LandingPage" %>

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
            <li class="active"><a href="LandingPage.aspx">Home</a></li>
            <li><a href="EvaluationPage.aspx">Evaluation Form</a></li>
            <li><a href="EvaluationPage.aspx">Other Form</a></li>
            <li><a href="EvaluationPage.aspx">Test Page</a></li>
            <li style="float:right"><a href="Login.aspx">Logout</a></li>            
        </ul>
    </div>

    <div class="margin">
        Content for Home Page goes here.
    </div>

</asp:Content>