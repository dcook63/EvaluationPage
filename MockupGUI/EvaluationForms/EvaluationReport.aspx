﻿<%@ Page Title="Evaluation Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EvaluationReport.aspx.cs" Inherits="MockupGUI.EvaluationReport" %>

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
    <section class="main" style="height:40px">
    <div class="margin" style="text-align: center;">
        <br />
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Select which form to report"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:DropDownList runat="server" ID="FormSelect" OnSelectedIndexChanged="EvalReportSelect" AutoPostBack="true">
                        <asp:ListItem>Peer Evaluation</asp:ListItem>
                        <asp:ListItem>Presentation Evaluation</asp:ListItem>
                        <asp:ListItem>Sponsor Evaluation</asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br />
    </div>
    </section>

    <div style="margin: 50px; align-content: center">
        <asp:Label runat="server" ID="searchup"></asp:Label>
        <input id="search-input" type="text" onkeypress="checkForMatches()" />
        <asp:TextBox runat="server" AutoCompleteType="Search"></asp:TextBox>
        <div>
            <asp:Label runat="server" ID="scLabel" autopostback="true"></asp:Label>
            <div style="margin-top:10px">
                <asp:GridView runat="server" ID="groups" AlternatingRowStyle-BackColor="white" HeaderStyle-BorderWidth="2px" 
                    HeaderStyle-BorderColor="black" HeaderStyle-BackColor="#feba18" AutoGenerateColumns="false" RowStyle-HorizontalAlign="Center">
                </asp:GridView>
            </div>
        </div>
    </div>

    <!-- Footer -->
  <section class="footer">
    <p>© Copyright 2019. All Rights Reserved.</p>
  </section>

    <script>
        searchForMatches(event) {
            xhttp = new XMLHttpRequest();
            var input = document.getElementById("search-input");
            var searchTerm = input.value;
            var sqlQuery = "SELECT * from Student WHERE LOWER(FirstName) LIKE LOWER(" + searchTerm + ")";

            xhttp.open("")
        };
    </script>

    <?php
        $mysqli = new mysqli("servername", "username", "password", "dbname");
        if($mysqli->connect_error) {
          exit('Could not connect');
        }

        $sql = "SELECT customerid, companyname, contactname, address, city, postalcode, country
        FROM customers WHERE customerid = ?";

        $stmt = $mysqli->prepare(sql);
        $stmt->bind_param("s", $_GET['q']);
        $stmt->execute();
        $stmt->store_result();
        $stmt->bind_result($cid, $cname, $name, $adr, $city, $pcode, $country);
        $stmt->fetch();
        $stmt->close();

        echo "<table>";
        echo "<tr>";
        echo "<th>CustomerID</th>";
        echo "<td>" . $cid . "</td>";
        echo "<th>CompanyName</th>";
        echo "<td>" . $cname . "</td>";
        echo "<th>ContactName</th>";
        echo "<td>" . $name . "</td>";
        echo "<th>Address</th>";
        echo "<td>" . $adr . "</td>";
        echo "<th>City</th>";
        echo "<td>" . $city . "</td>";
        echo "<th>PostalCode</th>";
        echo "<td>" . $pcode . "</td>";
        echo "<th>Country</th>";
        echo "<td>" . $country . "</td>";
        echo "</tr>";
        echo "</table>";
    ?>
</asp:Content>