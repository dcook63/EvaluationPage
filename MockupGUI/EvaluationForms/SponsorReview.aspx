<%@ Page Title="Evaluation Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SponsorReview.aspx.cs" Inherits="MockupGUI.SponsorReview" %>

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
                            <li><a href="#!">Sponsor Evaluation</a></li>
                            <li><a href="PeerReview.aspx">Peer Evaluation</a></li>
                            <li><a href="PresentationReview.aspx">Presentation Evaluation</a></li>
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
    <h3 id="page">Sponsor Review</h3>
  </section>

    <!-- Main Content -->
    <section class="main" style="padding:100px">
    <div class="margin" style="text-align: center;">
        <br />
        <asp:Table runat="server">

            <%-- Table Section --%>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="This is a Label. Whatever you put in this will appear as plain text on the webpage"></asp:Label>
                </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                <asp:TableCell>
                    <%-- Radio Button List --%>
                    <asp:RadioButtonList runat="server" id="question_one" RepeatDirection="Horizontal">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                    </asp:RadioButtonList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="15px"></asp:TableRow>
            <asp:TableRow height="75px">
                <asp:TableCell Width="100%" height="75px">
                    <asp:TextBox runat="server" height="75px" width="100%" placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="commentBox1"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- It is a good idea to section off different areas to keep track of what controls what --%>
            <asp:TableRow>
                <asp:TableCell>
                    <button>Submit</button>
                </asp:TableCell>
            </asp:TableRow>

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