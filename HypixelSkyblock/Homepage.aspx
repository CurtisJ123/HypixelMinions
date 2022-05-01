<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="HypixelSkyblock_Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Skyblock Minions</title>
    <link href="Styles/HomePage.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
      <header class="ggdgdgd">
        <div data-tippy-content="Happy Pride Month! ❤️" class="pride-flag rainbow"></div>
        <a href="/" id="site_name">sky.lea.moe</a>
        <div class="social-button" id="info_button" onclick="toggleInfo()">About</div>
            <a title="Patreon" target="_blank" rel="nofollow" href="https://patreon.com/LeaPhant" class="social-button patreon"> Patrons<div class="social-icon"></div></a>
            <a title="Ko-fi" target="_blank" rel="nofollow" href="https://ko-fi.com/leaphant" class="social-button ko-fi">x Ko-fi<div class="social-icon"></div></a>
        <div id="search_user"><asp:TextBox ID="inp_search_user" runat="server" OnClick="this.value=''">Enter Username</asp:TextBox><asp:DropDownList ID="ProfileDropDownlist" runat="server" Visible="False"></asp:DropDownList></div>
        <div data-tippy-content="#BlackLivesMatter" class="blm-logo"></div>
      </header>

      <!--<ul>
        <li><a href="Default.aspx">Home</a></li>
        <li><a href="Tier11Minions.aspx">Tier 11 Minions</a></li>
        <li><a href="contact.aspx">Contact</a></li>
        <li></li>
        <li></li>
        <li></li>
      </ul>-->
        <div style="padding:20px;margin-top:30px;height:1500px;">
          <div>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <asp:Button ID="btnGetProfile" runat="server" Text="Get Profile" OnClick="btnGetProfile_Click" />
            <asp:Button ID="btnUpdateDatabase" runat="server" OnClick="btnUpdateDatabase_Click" Text="Update Database Prices"/>
            <asp:Button ID="btnGetTable" runat="server" Text="Get Table" OnClick="btnGetTable_Click" Visible="false" />
            <br />
            <asp:CheckBox ID="chkSnowMinion" runat="server" Visible="false" Text="Show Snow Minion" OnCheckedChanged="chkSnowMinion_CheckedChanged" AutoPostBack="true"/>
            <br />
            <asp:Label ID="lblCostToNextMinionSlot" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblNumOfMinionsTilNextSlot" runat="server" Text=""></asp:Label>
            <br />
            <asp:GridView ID="gvMinionTable" runat="server" CssClass="darkTable"></asp:GridView>
          </div>
        </div>
    </form>
</body>
</html>
