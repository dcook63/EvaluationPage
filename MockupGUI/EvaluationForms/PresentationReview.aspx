﻿<%@ Page Title="Evaluation Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PresentationReview.aspx.cs" Inherits="MockupGUI.PresentationReview" %>

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
                            <li><a href="PeerReview.aspx">Peer Evaluation</a></li>
                            <li><a href="#!">Presentation Evaluation</a></li>
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
    <h3 id="page">Presentation Review</h3>
  </section>

    <!-- Main -->
    <section class="main" style="padding:100px;  height:100%">
    <div class="margin" style="text-align: center; height:100%">


        <div style="margin: 50px; align-content: center">
            <asp:Label runat="server" ID="searchup" Text="Search For Group"></asp:Label>
            <asp:DropDownList runat="server" ID="groupList" style="margin-right:15px; margin-left:10px" AutoPostBack="true"></asp:DropDownList>
            <div style="margin-top:20px">
                <asp:Label runat="server">First Name</asp:Label>
                <asp:TextBox runat="server" ID="FNameInput"></asp:TextBox>
                <asp:Label runat="server">Last Name</asp:Label>
                <asp:TextBox runat="server" ID="LNameInput"></asp:TextBox>
            </div>
            <div>
                <asp:Label runat="server" ID="Label1" Text="Search For Group"></asp:Label>
                <asp:DropDownList runat="server" ID="roleList" style="margin-right:15px; margin-left:10px" AutoPostBack="true">
                    <asp:ListItem>External Project Sponsor</asp:ListItem>
                    <asp:ListItem>IAB Member</asp:ListItem>
                    <asp:ListItem>IT Department Faculty</asp:ListItem>
                </asp:DropDownList>
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
                    <asp:Label runat="server" Text="Poster design: the quality and creativity of the poster, including style, layout, content, readability, media use, etc"></asp:Label>
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
                    <asp:Label runat="server" Text="Team talk: how well does the team communicate with the audience?"></asp:Label>
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
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="commentBox2"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- Question 3 --%>
              <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Presentation slides and content: quality of presentation slides and content; covered major aspects of the project in a logical flow."></asp:Label>
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
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="commentBox3"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- Question 4 --%>
              <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Presentation skill and performance: how well did the team talk to the audience about the project and answer questions? Demonstrated confidence and enthusiasm."></asp:Label>
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
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="commentBox4"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- Question 5 --%>
              <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Project goals and deliverables: completion of the project goals and deliverables; quality of the solution and work; application of appropriate technologies, practices, and methods. "></asp:Label>
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
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="commentBox5"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- Question 6 --%>
              <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Soft skills: demonstrated good project experiences related to soft skills, including communication, team work, dealing with challenges, learning, research, documentation, project management, etc."></asp:Label>
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
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="commentBox6"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- Question 7 --%>
              <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="What is your overall evaluation score of this project?"></asp:Label>
                </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                <asp:TableCell>
                    <%-- Radio Button List --%>
                    <asp:RadioButtonList runat="server" id="question_seven" RepeatDirection="Horizontal">
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
            <asp:TableRow Height="25"></asp:TableRow>

             <%-- Question 8 --%>
              <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Please comment on any observed excellence of the project and the team."></asp:Label>
                </asp:TableCell>
                </asp:TableRow>
            <asp:TableRow Height="15px"></asp:TableRow>
            <asp:TableRow height="75px">
                <asp:TableCell Width="100%" height="75px">
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="commentBox7"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- Question 9 --%>
              <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Please comment on any observed weakness of the project and the team."></asp:Label>
                </asp:TableCell>
                </asp:TableRow>
            <asp:TableRow Height="15px"></asp:TableRow>
            <asp:TableRow height="75px">
                <asp:TableCell Width="100%" height="75px">
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="commentBox8"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- Question 10 --%>
              <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Please comment on student’s project website and supplement materials on the website."></asp:Label>
                </asp:TableCell>
                </asp:TableRow>
            <asp:TableRow Height="15px"></asp:TableRow>
            <asp:TableRow height="75px">
                <asp:TableCell Width="100%" height="75px">
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="commentBox9"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>

            <%-- Question 11 --%>
              <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Please share any other comment to improve the project."></asp:Label>
                </asp:TableCell>
                </asp:TableRow>
            <asp:TableRow Height="15px"></asp:TableRow>
            <asp:TableRow height="75px">
                <asp:TableCell Width="100%" height="75px">
                    <asp:textbox runat="server" height="75px" width="100%" Placeholder="Comment..." Font-Size="Small" TextMode="MultiLine" ID="commentBox10"></asp:textbox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow Height="25"></asp:TableRow>


            <%-- End of Questions --%>

            <%-- It is a good idea to section off different areas to keep track of what controls what --%>
            <asp:TableRow>
                <asp:TableCell>
                    <button runat="server" onserverclick="SubmitForm" type="button">Submit</button>
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