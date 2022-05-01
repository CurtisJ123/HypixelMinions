using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Hypixel.NET;
using Hypixel.NET.SkyblockApi;
using Hypixel.NET.SkyblockApi.Bazaar;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HypixelSkyblock
{
  public class Bazaar
  {

    public void UpdateMinionPrice(GetBazaarProducts bazaarInfo)
    {
      string connectionString;
      SqlConnection cnn;
      connectionString = @"Data Source=database-2.cwjhdz8pmoyv.us-east-2.rds.amazonaws.com,1433;Network Library = DBMSSOCN;  Initial Catalog=SkyblockMinions; User ID = admin; Password = 6FZg0M0JKUJsyUdJVEUp;";
      cnn = new SqlConnection(connectionString);


      cnn.Open();

      SqlCommand command;
      SqlDataAdapter adapter = new SqlDataAdapter();
      string sql;
      sql = "";

      sql = "SELECT COUNT(*) FROM TMinions";
      command = new SqlCommand(sql, cnn);

      int intRowCount = Convert.ToInt32(command.ExecuteScalar());
      for (int i = 1; i <= intRowCount; i++)
      {
        string upgradeMaterial = "";
        int upgradeMaterialAmount = 1;
        string upgradeMaterial2 = "";
        int upgradeMaterialAmount2 = 1;
        int price = 0;
        string minionName = "";
        int minionTier = 0;

        command.CommandText = $"select upgradeMaterial,upgradeMaterialAmount,minionName,minionTier from TMinions where TMinions.minionID = {i}";
        using (SqlDataReader reader = command.ExecuteReader())
        {
          if (reader.HasRows)
          {
            while (reader.Read())
            {
              upgradeMaterial = reader.GetString(0);
              upgradeMaterialAmount = reader.GetInt32(1);
              minionName = reader.GetString(2);
              minionTier = reader.GetInt32(3);
              
              
            }
          }
          else
          {
            Console.WriteLine("Failed to update Minion Price, No rows found. reader");
          }


          reader.Close();
        }
        if (minionName == "REVENANT" || minionName == "TARANTULA")
        {
          if(minionTier != 1)
          {
            switch (minionName)
            {
              case "REVENANT":
                minionName = "ZOMBIE";
                minionTier -= 1;
                break;
              case "TARANTULA":
                minionName = "SPIDER";
                minionTier -= 1;
                break;
            }
            command.CommandText = $"select upgradeMaterial,upgradeMaterialAmount,minionName,minionTier from TMinions where TMinions.minionName = '{minionName}' and TMinions.minionTier = {minionTier};";
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.HasRows)
              {
                while (reader.Read())
                {
                  upgradeMaterial2 = reader.GetString(0);
                  upgradeMaterialAmount2 = reader.GetInt32(1);
                }
              }
              else
              {
                Console.WriteLine("Failed to update Minion Price, No rows found. reader");
              }
            }
          }
          else
          {
            switch (minionName)
            {
              case "REVENANT":
                upgradeMaterial2 = "ENCHANTED_DIAMOND";
                upgradeMaterialAmount2 = 256;
                price = GetBazaarPrice("ENCHANTED_ROTTEN_FLESH", 256, bazaarInfo);
                break;
              case "TARANTULA":
                upgradeMaterial2 = "ENCHANTED_FERMENTED_SPIDER_EYE";
                upgradeMaterialAmount2 = 1;
                break;
            }
          }
          
          price += GetBazaarPrice(upgradeMaterial, upgradeMaterialAmount, upgradeMaterial2, upgradeMaterialAmount2, bazaarInfo);
        }
        else
        {
          price = GetBazaarPrice(upgradeMaterial, upgradeMaterialAmount, bazaarInfo);
        }

        command.CommandText = $"update TMinions set upgradeCost = {price} where TMinions.minionID = {i}";
        adapter.UpdateCommand = command;
        adapter.UpdateCommand.ExecuteNonQuery();
        command.Dispose();
      }
      
      
      
      cnn.Close();
    }
    public int GetBazaarPrice(string itemName, int itemAmount, GetBazaarProducts bazaarInfo)
    {
      
      int itemprice = 0;
      JObject data = (JObject)JToken.FromObject(bazaarInfo);
      switch (itemName)
      {
        case "MELON_BLOCK":
          itemName = "MELON";
          itemAmount = itemAmount * 9;
          break;
        case "SILVER_FANG":
          itemName = "ENCHANTED_GHAST_TEAR";
          itemAmount = itemAmount * 25;
          break;
        case "WHITE_GIFT":
          return 200000;
        case "Oak_Wood":
          itemName = "LOG";
          break;
        case "Birch_Wood":
          itemName = "LOG:2";
          break;
        case "Jungle_Wood":
          itemName = "LOG:3";
          break;
        case "Acacia_Wood":
          itemName = "LOG_2";
          break;
        case "Dark_Oak_Wood":
          itemName = "LOG_2:1";
          break;
        case "Spruce_Wood":
          itemName = "LOG:1";
          break;
        case "Cocoa_Beans":
          itemName = "INK_SACK:3";
          break;
        case "Lapis_Lazuli":
          itemName = "INK_SACK:4";
          break;
      }
      itemprice = data["products"][itemName]["quick_status"]["buyPrice"].Value<int>();
      return itemprice * itemAmount;
      
    }
    public int GetBazaarPrice(string itemName, int itemAmount, string secondItemName, int secondItemAmount, GetBazaarProducts bazaarInfo)
    {
      int itemprice = 0;
      int secondItemPrice = 0;
      JObject data = (JObject)JToken.FromObject(bazaarInfo);
      itemprice = data["products"][itemName]["quick_status"]["buyPrice"].Value<int>();
      itemprice = itemprice * itemAmount;
      secondItemPrice = data["products"][secondItemName] ["quick_status"] ["buyPrice"].Value<int>();
      secondItemPrice = secondItemPrice * secondItemAmount;
      return itemprice + secondItemPrice;
    }
    #region SQL code
//    insert into TMinions(minionName, minionTier, upgradeMaterial, upgradeMaterialAmount, upgradeCost)
//VALUES('COBBLESTONE',1,'COBBLESTONE',80,null);
//    insert into TMinions(minionName, minionTier, upgradeMaterial, upgradeMaterialAmount, upgradeCost)
//VALUES('COBBLESTONE',2,'COBBLESTONE',160,null);
//    insert into TMinions(minionName, minionTier, upgradeMaterial, upgradeMaterialAmount, upgradeCost)
//VALUES('COBBLESTONE',3,'COBBLESTONE',320,null);
//    insert into TMinions(minionName, minionTier, upgradeMaterial, upgradeMaterialAmount, upgradeCost)
//VALUES('COBBLESTONE',4,'COBBLESTONE',512,null);
//    insert into TMinions(minionName, minionTier, upgradeMaterial, upgradeMaterialAmount, upgradeCost)
//VALUES('COBBLESTONE',5,'ENCHANTED_COBBLESTONE',8,null);
//    insert into TMinions(minionName, minionTier, upgradeMaterial, upgradeMaterialAmount, upgradeCost)
//VALUES('COBBLESTONE',6,'ENCHANTED_COBBLESTONE',16,null);
//    insert into TMinions(minionName, minionTier, upgradeMaterial, upgradeMaterialAmount, upgradeCost)
//VALUES('COBBLESTONE',7,'ENCHANTED_COBBLESTONE',32,null);
//    insert into TMinions(minionName, minionTier, upgradeMaterial, upgradeMaterialAmount, upgradeCost)
//VALUES('COBBLESTONE',8,'ENCHANTED_COBBLESTONE',64,null);
//    insert into TMinions(minionName, minionTier, upgradeMaterial, upgradeMaterialAmount, upgradeCost)
//VALUES('COBBLESTONE',9,'ENCHANTED_COBBLESTONE',128,null);
//    insert into TMinions(minionName, minionTier, upgradeMaterial, upgradeMaterialAmount, upgradeCost)
//VALUES('COBBLESTONE',10,'ENCHANTED_COBBLESTONE',256,null);
//    insert into TMinions(minionName, minionTier, upgradeMaterial, upgradeMaterialAmount, upgradeCost)
//VALUES('COBBLESTONE',11,'ENCHANTED_COBBLESTONE',512,null);
    #endregion
  }
}
