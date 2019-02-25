<%@ Page Title="Evaluation Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EvaluationReport.aspx.cs" Inherits="MockupGUI.EvaluationReport" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link href="/css/reset.css" rel="stylesheet" type="text/css">
    <link href="/css/style.css" rel="stylesheet" type="text/css">
    <link href="/css/nav.css" rel="stylesheet" type="text/css">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="/js/nav.js"></script>

    <!-- Nav -->
    <section class="navigation">
        <div class="nav-container">
            <div class="brand">
                <img src="/images/ksu_logo.png" id="logo" />
            </div>
            <nav>
                <div class="nav-mobile"><a id="nav-toggle" href="#!"><span></span></a></div>
                <ul class="nav-list">
                    <li><a href="#!" id="nav-home">Group 5</a></li>
                    <li><a href="#!">Group 6</a></li>
                    <li><a href="#!">Group 7</a></li>
                    <li>
                        <a href="#!">Evaluation Form</a>
                        <ul class="nav-dropdown">
                            <li><a href="SponsorReview.aspx">Sponsor Evaluation</a></li>
                            <li><a href="PeerEvaluation.aspx">Peer Evaluation</a></li>
                            <li><a href="PresentationReview.aspx">Presentation Evaluation</a></li>
                            <li><a href="#!">Evaluation Report</a></li>
                        </ul>
                    </li>
                </ul>
            </nav>
        </div>
    </section>

    <!-- Header -->
    <section class="header">
    <h1 id="cms">Capstone Management System</h1>
    <br />
    <h3 id="page">Evaluation Report</h3>
  </section>

    <!-- Main -->
    <section class="main" style="padding:100px">
    <div class="margin" style="text-align: center;">
        <br />
        <asp:Table runat="server">

            <%-- Table Section --%>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Select which form to report"></asp:Label>
                </asp:TableCell>
                </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:DropDownList runat="server" ID="FormSelect">
                        <asp:ListItem>Sponsor Evaluation</asp:ListItem>
                        <asp:ListItem>Peer Evaluation</asp:ListItem>
                        <asp:ListItem>Presentation Evaluation</asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <div style="wid; height: 400px; overflow: scroll; padding-left: 0px; padding-right: 0px; margin: 0px">
                        <asp:GridView runat="server" ID="groups" AlternatingRowStyle-BackColor="lightgray" HeaderStyle-BorderWidth="2px" 
                            HeaderStyle-BorderColor="black" HeaderStyle-BackColor="#feba18"></asp:GridView>
                    </div>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- End of table --%>
        </asp:Table>
        <br />
    </div>
    </section>

    <!-- Footer -->
  <section class="footer">
    <p>© Copyright 2019. All Rights Reserved.</p>
  </section>

</asp:Content>