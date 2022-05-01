using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hypixel.NET.BoosterApi;
using Hypixel.NET.FriendsApi;
using Hypixel.NET.GuildApi;
using Hypixel.NET.KeyApi;
using Hypixel.NET.LeaderboardsApi;
using Hypixel.NET.PlayerApi;
using Hypixel.NET.PlayerApi.Player.GameCounts;
using Hypixel.NET.SkyblockApi;
using Hypixel.NET.SkyblockApi.Bazaar;
using Hypixel.NET.SkyblockApi.News;
using Hypixel.NET.WatchdogStatsApi;
using Hypixel.NET;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json.Linq;

public partial class HypixelSkyblock_Homepage : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
  }

  protected void btnGetProfile_Click(object sender, EventArgs e)
  {
    var hypixel = new HypixelApi("8d0061cc-bb9d-4ec6-b719-d87602a8a8c5", 300);
    string strUserName;
    strUserName = inp_search_user.Text;

    ProfileDropDownlist.Items.Clear();


    // Get a list of skyblock Profiles by username

    var userData = hypixel.GetUserByPlayerName(strUserName);


    // Creates a new list
    var profileList = new List<GetSkyBlockProfile>();
    ProfileDropDownlist.Visible = true;

    // Gets the cute_name of each skyblock profile and adds it to the drop down list
    foreach (var profile in userData.Player.Stats.SkyBlock.Profiles)
    {
      ListItem item = new ListItem(profile.Value.CuteName, profile.Value.ProfileId);
      ProfileDropDownlist.Items.Add(item);
    }
    btnGetTable.Visible = true;
  }

  protected void btnUpdateDatabase_Click(object sender, EventArgs e)
  {
    var hypixel = new HypixelApi("8d0061cc-bb9d-4ec6-b719-d87602a8a8c5", 300);
    GetBazaarProducts BazaarInfo = hypixel.GetBazaarProducts();
    Bazaar bazaar = new Bazaar();

    bazaar.UpdateMinionPrice(BazaarInfo);
  }

  protected void btnGetTable_Click(object sender, EventArgs e)
  {
    getTableOfMinions();

  }
  public List<string> getCraftedMinions()
  {
    var hypixel = new HypixelApi("8d0061cc-bb9d-4ec6-b719-d87602a8a8c5", 300);
    GetSkyBlockProfile userSkyblockProfile = hypixel.GetSkyblockProfileByProfileId(ProfileDropDownlist.SelectedValue);
    JObject data = (JObject)JToken.FromObject(userSkyblockProfile);
    List<string> craftedGenerators = data["profile"]["members"][ProfileDropDownlist.SelectedValue]["crafted_generators"].ToObject<List<string>>();
    return craftedGenerators;
  }
  public List<string> getUncraftedMinions()
  {
    List<string> UncraftedMinions = new List<string>();
    List<string> CraftedMinions = new List<string>();
    List<string> TotalMinions = new List<string>();

    CraftedMinions = getCraftedMinions();
    if (CraftedMinions.Count != 0)
    {
      string connectionString;
      SqlConnection cnn;
      connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Curtis\source\repos\SkyblockWebsite\HypixelSkyblock\App_Data\SkyblockMinions.mdf;Integrated Security=True";
      cnn = new SqlConnection(connectionString);
      cnn.Open();

      string sql = "SELECT COUNT(*) FROM TMinions";
      SqlCommand command = new SqlCommand(sql, cnn);

      int intRowCount = Convert.ToInt32(command.ExecuteScalar());
      for (int i = 1; i <= intRowCount; i++)
      {
        string minionName = "";
        string minionTier = "";
        command.CommandText = $"select minionName,minionTier from TMinions Where minionID = {i}";

        using (SqlDataReader reader = command.ExecuteReader())
        {
          if (reader.HasRows)
          {
            while (reader.Read())
            {
              minionName = reader.GetString(0);
              minionTier = reader.GetInt32(1).ToString();
            }
          }
          else
          {
            Console.WriteLine("Failed to Get Minion List, No rows found. reader");
          }
          reader.Close();
        }
        TotalMinions.Add(minionName + "_" + minionTier);
      }

      UncraftedMinions = TotalMinions.Except(CraftedMinions).ToList();
      return UncraftedMinions;
    }
    else
    {
      return UncraftedMinions;
    }

  }


  public void getTableOfMinions()
  {
    string connectionString;
    SqlConnection cnn;
    connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Curtis\source\repos\SkyblockWebsite\HypixelSkyblock\App_Data\SkyblockMinions.mdf;Integrated Security=True";
    cnn = new SqlConnection(connectionString);
    cnn.Open();

    SqlCommand command;
    SqlDataAdapter adapter = new SqlDataAdapter();
    string sql;

    sql = "SELECT * FROM TMinions ORDER BY upgradeCost ASC";
    command = new SqlCommand(sql, cnn);
    SqlDataReader reader = command.ExecuteReader();
    DataTable dt = new DataTable();
    dt.Load(reader);

    List<string> UncraftedMinions = new List<string>();
    UncraftedMinions = getUncraftedMinions();
    chkSnowMinion.Visible = true;
    foreach (DataRow row in dt.Rows)
    {
      if (!UncraftedMinions.Contains(row[1].ToString() + "_" + row[2].ToString()))
      {
        row.Delete();
      }
      else
      {
        if (row[1].ToString() == "SNOW" & chkSnowMinion.Checked == false)
        {
          row.Delete();
        }
      }
    }


    cnn.Close();
    gvMinionTable.DataSource = dt;
    gvMinionTable.DataBind();

    int TotalCost = 0;
    int NextSlot = numberOfMinionsTilNextSlot();
    for (int i = 1; i <= NextSlot; i++)
    {
      TotalCost += Convert.ToInt32(gvMinionTable.Rows[i].Cells[5].Text);
    }
    lblCostToNextMinionSlot.Text = TotalCost.ToString();
    lblNumOfMinionsTilNextSlot.Text = NextSlot.ToString();
  }
  public int numberOfMinionsTilNextSlot()
  {
    int numOfMinions = 0;
    int numOfCraftedMinions = 0;
    List<string> CraftedMinions = new List<string>();

    CraftedMinions = getCraftedMinions();
    numOfCraftedMinions = CraftedMinions.Count;

    if (numOfCraftedMinions < 5)
    {
      return 5 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 15)
    {
      return 15 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 30)
    {
      return 30 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 50)
    {
      return 50 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 75)
    {
      return 75 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 100)
    {
      return 100 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 125)
    {
      return 125 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 150)
    {
      return 150 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 175)
    {
      return 175 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 200)
    {
      return 200 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 225)
    {
      return 225 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 250)
    {
      return 250 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 275)
    {
      return 275 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 300)
    {
      return 300 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 350)
    {
      return 350 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 400)
    {
      return 400 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 450)
    {
      return 450 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 500)
    {
      return 500 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 550)
    {
      return 550 - numOfCraftedMinions;
    }
    else if (numOfCraftedMinions < 600)
    {
      return 600 - numOfCraftedMinions;
    }


    return numOfMinions;
  }


  protected void chkSnowMinion_CheckedChanged(object sender, EventArgs e)
  {
    getTableOfMinions();
  }
}
