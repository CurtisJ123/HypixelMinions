<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HypixelSkyblock.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Skyblock Minions</title>
  <link href="Styles/HomePage.css" rel="stylesheet" />
</head>
<body>
  <form id="form1" runat="server">
    <header class="ggdgdgd">
      <div id="site_name_div">
        <a href="/" id="site_name">Skyblock Minions</a>
      </div>
      
      <div id="search_user">
        <asp:TextBox ID="inp_search_user" runat="server" OnClick="this.value=''">Enter Username</asp:TextBox>
        <asp:Button ID="btn_search_user" runat="server" Text="" OnClick="btnGetProfile_Click" />
        <asp:DropDownList ID="ProfileDropDownlist" runat="server" Visible="False" OnSelectedIndexChanged="ProfileDropDownlist_SelectedIndexChanged"></asp:DropDownList>
      </div>
    </header>
    <div style="padding: 20px; margin-top: 30px; height: 1500px;">
      <div>
        <asp:Button ID="btnUpdateDatabase" runat="server" OnClick="btnUpdateDatabase_Click" Visible="false" Text="Update Database Prices" />
        <asp:Button ID="btnGetTable" runat="server" Text="Get Table" OnClick="btnGetTable_Click" Visible="false" />
        <br />
        <asp:CheckBox ID="chkSnowMinion" runat="server" Visible="false" Text="Show Snow Minion" OnCheckedChanged="chkSnowMinion_CheckedChanged" AutoPostBack="true" />
        <br />
        <div id="Minion_Cost" runat="server">
          <asp:Label ID="lblCostToNextMinionSlot" runat="server" Text=""></asp:Label>
          <asp:Label ID="lblNumOfMinionsTilNextSlot" runat="server" Text=""></asp:Label>
        </div>
        
        <br />
        <asp:GridView ID="gvMinionTable" runat="server" CssClass="darkTable" AutoGenerateColumns="false">
          <Columns>
            <asp:TemplateField HeaderText="Minion ID">
              <ItemTemplate>
                <asp:Label ID="lblMinionID" runat="server" Text='<%# Eval("minionID") %>'></asp:Label>
              </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Minion Name">
              <ItemTemplate>
                <asp:Label ID="lblMinionName" runat="server" Text='<%# Eval("minionName") %>'></asp:Label>
              </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Minion Tier">
              <ItemTemplate>
                <asp:Label ID="lblMinionTier" runat="server" Text='<%# Eval("minionTier") %>'></asp:Label>
              </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Upgrade Material">
              <ItemTemplate>
                <asp:Label ID="lblUpgradeMaterial" runat="server" Text='<%# Eval("upgradeMaterial") %>'></asp:Label>
                <asp:Image ImageUrl='<%#("~/Images/images/")+Eval("upgradeMaterial")+(".png")%>' runat="server" Width="24" Height="24" />
              </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Upgrade Material Amount">
              <ItemTemplate>
                <asp:Label ID="lblUpgradeMaterialAmount" runat="server" Text='<%# Eval("upgradeMaterialAmount") %>'></asp:Label>
              </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Upgrade Cost">
              <ItemTemplate>
                <asp:Label ID="lblUpgradeCost" runat="server" Text='<%# Eval("upgradeCost") %>'></asp:Label>
              </ItemTemplate>
            </asp:TemplateField>
          </Columns>
        </asp:GridView>
      </div>
    </div>
  </form>
</body>
</html>
