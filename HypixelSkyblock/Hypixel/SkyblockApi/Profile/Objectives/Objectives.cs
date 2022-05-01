using Hypixel.NET.SkyblockApi.Profile.Objectives;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Profile.Objectives
{
    public class Objectives
    {
        [JsonProperty("collect_log")]
        public ObjectiveData CollectLog { get; private set; }

        [JsonProperty("talk_to_guide")]
        public ObjectiveData TalkToGuide { get; private set; }

        [JsonProperty("public_island")]
        public ObjectiveData PublicIsland { get; private set; }

        [JsonProperty("explore_hub")]
        public ObjectiveData ExploreHub { get; private set; }

        [JsonProperty("explore_village")]
        public ObjectiveData ExploreVillage { get; private set; }

        [JsonProperty("talk_to_librarian")]
        public ObjectiveData TalkToLibrarian { get; private set; }

        [JsonProperty("talk_to_farmer")]
        public ObjectiveData TalkToFarmer { get; private set; }

        [JsonProperty("talk_to_blacksmith")]
        public ObjectiveData TalkToBlacksmith { get; private set; }

        [JsonProperty("talk_to_lumberjack")]
        public ObjectiveData TalkToLumberjack { get; private set; }

        [JsonProperty("talk_to_event_master")]
        public ObjectiveData TalkToEventMaster { get; private set; }

        [JsonProperty("talk_to_auction_master")]
        public ObjectiveData TalkToAuctionMaster { get; private set; }

        [JsonProperty("talk_to_banker")]
        public ObjectiveData TalkToBanker { get; private set; }

        [JsonProperty("talk_to_fairy")]
        public ObjectiveData TalkToFairy { get; private set; }

        [JsonProperty("talk_to_fisherman_1")]
        public ObjectiveData TalkToFisherman1 { get; private set; }

        [JsonProperty("collect_clay")]
        public ObjectiveData CollectClay { get; private set; }

        [JsonProperty("collect_wheat")]
        public ObjectiveData CollectWheat { get; private set; }

        [JsonProperty("mine_coal")]
        public ObjectiveData MineCoal { get; private set; }

        [JsonProperty("talk_to_farmer_2")]
        public ObjectiveData TalkToFarmer2 { get; private set; }

        [JsonProperty("increase_farming_skill")]
        public ObjectiveData IncreaseFarmingSkill { get; private set; }

        [JsonProperty("warp_barn_island")]
        public ObjectiveData WarpBarnIsland { get; private set; }

        [JsonProperty("chop_tree")]
        public ObjectiveData ChopTree { get; private set; }

        [JsonProperty("talk_to_lumberjack_2")]
        public ObjectiveData TalkToLumberjack2 { get; private set; }

        [JsonProperty("increase_foraging_skill")]
        public ObjectiveData IncreaseForagingSkill { get; private set; }

        [JsonProperty("warp_foraging_islands")]
        public ObjectiveData WarpForagingIslands { get; private set; }

        [JsonProperty("increase_foraging_skill_5")]
        public ObjectiveData IncreaseForagingSkill5 { get; private set; }

        [JsonProperty("collect_birch_logs")]
        public ObjectiveData CollectBirchLogs { get; private set; }

        [JsonProperty("talk_to_charlie")]
        public ObjectiveData TalkToCharlie { get; private set; }

        [JsonProperty("collect_dark_oak_logs")]
        public ObjectiveData CollectDarkOakLogs { get; private set; }

        [JsonProperty("talk_to_charlie_2")]
        public ObjectiveData TalkToCharlie2 { get; private set; }

        [JsonProperty("craft_workbench")]
        public ObjectiveData CraftWorkbench { get; private set; }

        [JsonProperty("talk_to_blacksmith_2")]
        public ObjectiveData TalkToBlacksmith2 { get; private set; }

        [JsonProperty("deposit_coins")]
        public ObjectiveData DepositCoins { get; private set; }

        [JsonProperty("talk_to_lazy_miner")]
        public ObjectiveData TalkToLazyMiner { get; private set; }

        [JsonProperty("increase_mining_skill_5")]
        public ObjectiveData IncreaseMiningSkill5 { get; private set; }

        [JsonProperty("increase_mining_skill")]
        public ObjectiveData IncreaseMiningSkill { get; private set; }

        [JsonProperty("reforge_item")]
        public ObjectiveData ReforgeItem { get; private set; }

        [JsonProperty("warp_gold_mine")]
        public ObjectiveData WarpGoldMine { get; private set; }

        [JsonProperty("find_pickaxe")]
        public ObjectiveData FindPickaxe { get; private set; }

        [JsonProperty("warp_deep_caverns")]
        public ObjectiveData WarpDeepCaverns { get; private set; }

        [JsonProperty("talk_to_lapis_miner")]
        public ObjectiveData TalkToLapisMiner { get; private set; }

        [JsonProperty("talk_to_lift_operator")]
        public ObjectiveData TalkToLiftOperator { get; private set; }

        [JsonProperty("collect_ingots")]
        public CollectIngots CollectIngots { get; private set; }

        [JsonProperty("reach_lapis_quarry")]
        public ObjectiveData ReachLapisQuarry { get; private set; }

        [JsonProperty("collect_lapis")]
        public ObjectiveData CollectLapis { get; private set; }

        [JsonProperty("reach_pigmens_den")]
        public ObjectiveData ReachPigmensDen { get; private set; }

        [JsonProperty("collect_redstone")]
        public ObjectiveData CollectRedstone { get; private set; }

        [JsonProperty("give_pickaxe_lapis_miner")]
        public ObjectiveData GivePickaxeLapisMiner { get; private set; }

        [JsonProperty("kill_danger_mobs")]
        public ObjectiveData KillDangerMobs { get; private set; }

        [JsonProperty("talk_to_bartender")]
        public ObjectiveData TalkToBartender { get; private set; }

        [JsonProperty("increase_combat_skill")]
        public ObjectiveData IncreaseCombatSkill { get; private set; }

        [JsonProperty("warp_spiders_den")]
        public ObjectiveData WarpSpidersDen { get; private set; }

        [JsonProperty("talk_to_farmhand_1")]
        public ObjectiveData TalkToFarmhand1 { get; private set; }

        [JsonProperty("increase_farming_skill_5")]
        public ObjectiveData IncreaseFarmingSkill5 { get; private set; }

        [JsonProperty("craft_wheat_minion")]
        public ObjectiveData CraftWheatMinion { get; private set; }

        [JsonProperty("warp_mushroom_desert")]
        public ObjectiveData WarpMushroomDesert { get; private set; }

        [JsonProperty("collect_farming_resources_2")]
        public CollectFarmingResources2 CollectFarmingResources2 { get; private set; }

        [JsonProperty("collect_farm_animal_resources_2")]
        public CollectFarmAnimalResources2 CollectFarmAnimalResources2 { get; private set; }

        [JsonProperty("reach_slimehill")]
        public ObjectiveData ReachSlimehill { get; private set; }

        [JsonProperty("collect_emerald")]
        public ObjectiveData CollectEmerald { get; private set; }

        [JsonProperty("reach_diamond_reserve")]
        public ObjectiveData ReachDiamondReserve { get; private set; }

        [JsonProperty("collect_diamond")]
        public ObjectiveData CollectDiamond { get; private set; }

        [JsonProperty("reach_obsidian_sanctuary")]
        public ObjectiveData ReachObsidianSanctuary { get; private set; }

        [JsonProperty("collect_obsidian")]
        public ObjectiveData CollectObsidian { get; private set; }

        [JsonProperty("increase_combat_skill_5")]
        public ObjectiveData IncreaseCombatSkill5 { get; private set; }

        [JsonProperty("talk_to_rick")]
        public ObjectiveData TalkToRick { get; private set; }

        [JsonProperty("talk_to_haymitch")]
        public ObjectiveData TalkToHaymitch { get; private set; }

        [JsonProperty("warp_blazing_fortress")]
        public ObjectiveData WarpBlazingFortress { get; private set; }

        [JsonProperty("collect_spider")]
        public CollectSpider CollectSpider { get; private set; }

        [JsonProperty("talk_to_elle")]
        public ObjectiveData TalkToElle { get; private set; }

        [JsonProperty("collect_nether_resources")]
        public CollectNetherResources CollectNetherResources { get; private set; }

        [JsonProperty("give_fairy_souls")]
        public ObjectiveData GiveFairySouls { get; private set; }

        [JsonProperty("collect_nether_resources_2")]
        public CollectNetherResources2 CollectNetherResources2 { get; private set; }

        [JsonProperty("craft_wood_pickaxe")]
        public ObjectiveData CraftWoodPickaxe { get; private set; }

        [JsonProperty("enchant_item")]
        public ObjectiveData EnchantItem { get; private set; }

        [JsonProperty("talk_to_telekinesis_applier")]
        public ObjectiveData TalkToTelekinesisApplier { get; private set; }

        [JsonProperty("talk_to_carpenter")]
        public ObjectiveData TalkToCarpenter { get; private set; }

        [JsonProperty("talk_to_artist_1")]
        public ObjectiveData TalkToArtist1 { get; private set; }

        [JsonProperty("paint_canvas")]
        public ObjectiveData PaintCanvas { get; private set; }

        [JsonProperty("talk_to_artist_2")]
        public ObjectiveData TalkToArtist2 { get; private set; }

        [JsonProperty("collect_wool_carpenter")]
        public ObjectiveData CollectWoolCarpenter { get; private set; }

        [JsonProperty("warp_the_end")]
        public ObjectiveData WarpTheEnd { get; private set; }

        [JsonProperty("talk_to_guber_1")]
        public ObjectiveData TalkToGuber1 { get; private set; }

        [JsonProperty("talk_to_end_dealer")]
        public ObjectiveData TalkToEndDealer { get; private set; }

        [JsonProperty("collect_end_stone")]
        public ObjectiveData CollectEndStone { get; private set; }

        [JsonProperty("reach_dragons_nest")]
        public ObjectiveData ReachDragonsNest { get; private set; }

        [JsonProperty("give_rick_ingots")]
        public ObjectiveData GiveRickIngots { get; private set; }

        [JsonProperty("fight_dragon")]
        public ObjectiveData FightDragon { get; private set; }

        [JsonProperty("complete_the_end_race_1")]
        public ObjectiveData CompleteTheEndRace1 { get; private set; }

        [JsonProperty("talk_to_farmhand_2")]
        public ObjectiveData TalkToFarmhand2 { get; private set; }

        [JsonProperty("talk_to_fisherman_2")]
        public ObjectiveData TalkToFisherman2 { get; private set; }

        [JsonProperty("collect_farming_resources")]
        public CollectFarmingResources CollectFarmingResources { get; private set; }

        [JsonProperty("collect_farm_animal_resources")]
        public CollectFarmAnimalResources CollectFarmAnimalResources { get; private set; }
    }
}
