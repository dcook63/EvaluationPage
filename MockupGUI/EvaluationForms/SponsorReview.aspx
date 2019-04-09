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
                            <li><a href="EvaluationReport.aspx">Evaluation Report</a></li>
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

    <!-- Main -->
    <section class="main" style="padding:100px;  height:100%">
    <div class="margin" style="text-align: center; height:100%">


        <div style="margin: 50px; align-content: center">
            <asp:Label runat="server" ID="searchup" Text="Search For Group"></asp:Label>
            <asp:DropDownList runat="server" ID="groupList" style="margin-right:15px; margin-left:10px" AutoPostBack="true"></asp:DropDownList>
            <asp:Label runat="server" ID="searchup2" Text="Search For Student"></asp:Label>
            <asp:DropDownList runat="server" ID="studentList" style="margin-right:15px; margin-left:10px" AutoPostBack="true"></asp:DropDownList>
            <div style="margin:10px; margin-left:0px">
                <asp:Label runat="server" ID="scLabel" autopostback="true"></asp:Label>
            </div>
            <div style="margin-top:10px">
                <asp:GridView runat="server" ID="groups" AlternatingRowStyle-BackColor="white" HeaderStyle-BorderWidth="2px" 
                    HeaderStyle-BorderColor="black" HeaderStyle-BackColor="#feba18" AutoGenerateColumns="false" RowStyle-HorizontalAlign="Center">
                </asp:GridView>
            </div>
        </div>
        <br />
        <asp:Table runat="server">

            <%-- Table Section --%>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Clarity and quality of the final submissions: complete, well organized and explained, and on time."></asp:Label>
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
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="commentBox1"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- Question 2 --%>
                <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Quality of the solution and work to meet project goals: technical analysis, designs, system implementations, application development, research, documentation, etc."></asp:Label>
                </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                <asp:TableCell>
                    <%-- Radio Button List --%>
                    <asp:RadioButtonList runat="server" id="question_two" RepeatDirection="Horizontal">
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
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="Textbox1"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- Question 3 --%>
              <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Communication and interaction:How well did the team communicate and interact with the project owner?"></asp:Label>
                </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                <asp:TableCell>
                    <%-- Radio Button List --%>
                    <asp:RadioButtonList runat="server" id="question_three" RepeatDirection="Horizontal">
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
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="Textbox2"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- Question 4 --%>
              <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Team energy and commitment: How do you perceive the energy and passion of the team? Was the team being proactive? Did they make commitment to project completion?"></asp:Label>
                </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                <asp:TableCell>
                    <%-- Radio Button List --%>
                    <asp:RadioButtonList runat="server" id="question_four" RepeatDirection="Horizontal">
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
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="Textbox3"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- Question 5 --%>
              <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Project progress and management: To your knowledge, how well was the project planned, managed, and tracked? Was there any major delay?"></asp:Label>
                </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                <asp:TableCell>
                    <%-- Radio Button List --%>
                    <asp:RadioButtonList runat="server" id="question_five" RepeatDirection="Horizontal">
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
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="Textbox4"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- Question 6 --%>
              <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Your overall evaluation of your team of their work:"></asp:Label>
                </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                <asp:TableCell>
                    <%-- Radio Button List --%>
                    <asp:RadioButtonList runat="server" id="question_six" RepeatDirection="Horizontal">
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
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="Textbox5"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

         
            <%-- End of Questions --%>
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