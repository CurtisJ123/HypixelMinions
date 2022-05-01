using Newtonsoft.Json;
using System.Collections.Generic;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Pit
    {
        [JsonProperty("profile")]
        public Profile Profile { get; private set; }

        [JsonProperty("pit_stats_ptl")]
        public PitStats PitStatsPtl { get; private set; }

    }

    public class Profile
    {
        #region Prestige
        [JsonProperty("prestiges")]
        public List<Prestige> Prestiges { get; private set; }

        [JsonProperty("unlocks")]
        public List<PrestigeUnlocks> Unlocks { get; private set; }

        [JsonProperty("unlocks_26")]
        public List<PrestigeUnlocks> Unlocks26 { get; private set; }

        [JsonProperty("cash_during_prestige_28")]
        public double CashDuringPrestige28 { get; private set; }

        [JsonProperty("unlocks_27")]
        public List<PrestigeUnlocks> Unlocks27 { get; private set; }

        [JsonProperty("cash_during_prestige_29")]
        public double CashDuringPrestige29 { get; private set; }

        [JsonProperty("unlocks_28")]
        public List<PrestigeUnlocks> Unlocks28 { get; private set; }

        [JsonProperty("unlocks_29")]
        public List<PrestigeUnlocks> Unlocks29 { get; private set; }

        [JsonProperty("unlocks_22")]
        public List<PrestigeUnlocks> Unlocks22 { get; private set; }

        [JsonProperty("unlocks_23")]
        public List<PrestigeUnlocks> Unlocks23 { get; private set; }

        [JsonProperty("unlocks_24")]
        public List<PrestigeUnlocks> Unlocks24 { get; private set; }

        [JsonProperty("unlocks_25")]
        public List<PrestigeUnlocks> Unlocks25 { get; private set; }

        [JsonProperty("cash_during_prestige_20")]
        public double CashDuringPrestige20 { get; private set; }

        [JsonProperty("cash_during_prestige_21")]
        public double CashDuringPrestige21 { get; private set; }

        [JsonProperty("unlocks_20")]
        public List<PrestigeUnlocks> Unlocks20 { get; private set; }

        [JsonProperty("cash_during_prestige_22")]
        public double CashDuringPrestige22 { get; private set; }

        [JsonProperty("unlocks_21")]
        public List<PrestigeUnlocks> Unlocks21 { get; private set; }

        [JsonProperty("cash_during_prestige_23")]
        public double CashDuringPrestige23 { get; private set; }

        [JsonProperty("cash_during_prestige_24")]
        public double CashDuringPrestige24 { get; private set; }

        [JsonProperty("cash_during_prestige_25")]
        public double CashDuringPrestige25 { get; private set; }

        [JsonProperty("cash_during_prestige_26")]
        public double CashDuringPrestige26 { get; private set; }

        [JsonProperty("cash_during_prestige_27")]
        public double CashDuringPrestige27 { get; private set; }

        [JsonProperty("cash_during_prestige_7")]
        public double CashDuringPrestige7 { get; private set; }

        [JsonProperty("cash_during_prestige_6")]
        public double CashDuringPrestige6 { get; private set; }

        [JsonProperty("cash_during_prestige_9")]
        public double CashDuringPrestige9 { get; private set; }

        [JsonProperty("cash_during_prestige_8")]
        public double CashDuringPrestige8 { get; private set; }

        [JsonProperty("cash_during_prestige_30")]
        public double CashDuringPrestige30 { get; private set; }

        [JsonProperty("unlocks_30")]
        public List<PrestigeUnlocks> Unlocks30 { get; private set; }

        [JsonProperty("renown_unlocks")]
        public List<PrestigeUnlocks> RenownUnlocks { get; private set; }

        [JsonProperty("unlocks_15")]
        public List<PrestigeUnlocks> Unlocks15 { get; private set; }

        [JsonProperty("cash_during_prestige_17")]
        public double CashDuringPrestige17 { get; private set; }

        [JsonProperty("unlocks_16")]
        public List<PrestigeUnlocks> Unlocks16 { get; private set; }

        [JsonProperty("cash_during_prestige_18")]
        public double CashDuringPrestige18 { get; private set; }

        [JsonProperty("unlocks_17")]
        public List<PrestigeUnlocks> Unlocks17 { get; private set; }

        [JsonProperty("cash_during_prestige_19")]
        public double CashDuringPrestige19 { get; private set; }

        [JsonProperty("unlocks_18")]
        public List<PrestigeUnlocks> Unlocks18 { get; private set; }

        [JsonProperty("unlocks_11")]
        public List<PrestigeUnlocks> Unlocks11 { get; private set; }

        [JsonProperty("unlocks_12")]
        public List<PrestigeUnlocks> Unlocks12 { get; private set; }

        [JsonProperty("unlocks_13")]
        public List<PrestigeUnlocks> Unlocks13 { get; private set; }

        [JsonProperty("unlocks_14")]
        public List<PrestigeUnlocks> Unlocks14 { get; private set; }

        [JsonProperty("unlocks_19")]
        public List<PrestigeUnlocks> Unlocks19 { get; private set; }

        [JsonProperty("unlocks_10")]
        public List<PrestigeUnlocks> Unlocks10 { get; private set; }

        [JsonProperty("cash_during_prestige_12")]
        public double CashDuringPrestige12 { get; private set; }

        [JsonProperty("cash_during_prestige_13")]
        public double CashDuringPrestige13 { get; private set; }

        [JsonProperty("cash_during_prestige_14")]
        public double CashDuringPrestige14 { get; private set; }

        [JsonProperty("cash_during_prestige_15")]
        public double CashDuringPrestige15 { get; private set; }

        [JsonProperty("cash_during_prestige_16")]
        public double CashDuringPrestige16 { get; private set; }

        [JsonProperty("cash_during_prestige_10")]
        public double CashDuringPrestige10 { get; private set; }

        [JsonProperty("cash_during_prestige_11")]
        public double CashDuringPrestige11 { get; private set; }

        [JsonProperty("cash_during_prestige_0")]
        public double CashDuringPrestige0 { get; private set; }

        [JsonProperty("cash_during_prestige_1")]
        public double CashDuringPrestige1 { get; private set; }

        [JsonProperty("cash_during_prestige_2")]
        public double CashDuringPrestige2 { get; private set; }

        [JsonProperty("cash_during_prestige_3")]
        public double CashDuringPrestige3 { get; private set; }

        [JsonProperty("cash_during_prestige_4")]
        public double CashDuringPrestige4 { get; private set; }

        [JsonProperty("cash_during_prestige_5")]
        public double CashDuringPrestige5 { get; private set; }

        [JsonProperty("unlocks_8")]
        public List<PrestigeUnlocks> Unlocks8 { get; private set; }

        [JsonProperty("unlocks_9")]
        public List<PrestigeUnlocks> Unlocks9 { get; private set; }

        [JsonProperty("unlocks_1")]
        public List<PrestigeUnlocks> Unlocks1 { get; private set; }

        [JsonProperty("unlocks_2")]
        public List<PrestigeUnlocks> Unlocks2 { get; private set; }

        [JsonProperty("unlocks_3")]
        public List<PrestigeUnlocks> Unlocks3 { get; private set; }

        [JsonProperty("unlocks_4")]
        public List<PrestigeUnlocks> Unlocks4 { get; private set; }

        [JsonProperty("unlocks_5")]
        public List<PrestigeUnlocks> Unlocks5 { get; private set; }

        [JsonProperty("unlocks_6")]
        public List<PrestigeUnlocks> Unlocks6 { get; private set; }

        [JsonProperty("unlocks_7")]
        public List<PrestigeUnlocks> Unlocks7 { get; private set; }

        #endregion

        #region General stats

        [JsonProperty("cash")]
        public double Cash { get; private set; }

        [JsonProperty("selected_perk_3")]
        public string SelectedPerk3 { get; private set; }

        [JsonProperty("selected_perk_2")]
        public string SelectedPerk2 { get; private set; }

        [JsonProperty("selected_perk_1")]
        public string SelectedPerk1 { get; private set; }

        [JsonProperty("selected_perk_0")]
        public string SelectedPerk0 { get; private set; }

        [JsonProperty("impatient_enabled")]
        public bool ImpatientEnabled { get; private set; }

        [JsonProperty("renown")]
        public long Renown { get; private set; }

        [JsonProperty("drop_confirm_disabled")]
        public bool DropConfirmDisabled { get; private set; }

        [JsonProperty("xp")]
        public long Xp { get; private set; }
        #endregion

        [JsonProperty("contract_choices")]
        public List<ContractChoice> ContractChoices { get; private set; }

        [JsonProperty("trade_timestamps")]
        public List<long> TradeTimestamps { get; private set; }

        [JsonProperty("inv_enderchest")]
        public EnderchestInventory InvEnderchest { get; private set; }

        [JsonProperty("death_recaps")]
        public DeathRecaps DeathRecaps { get; private set; }

        [JsonProperty("gold_transactions")]
        public List<GoldTransaction> GoldTransactions { get; private set; }

        [JsonProperty("chat_option_player_chat")]
        public bool ChatOptionPlayerChat { get; private set; }

        [JsonProperty("inv_contents")]
        public InventoryContent InvContents { get; private set; }

        [JsonProperty("last_midfight_disconnect")]
        public long LastMidfightDisconnect { get; private set; }

        [JsonProperty("ended_contracts")]
        public List<EndedContract> EndedContracts { get; private set; }

        [JsonProperty("last_save")]
        public long LastSave { get; private set; }

        [JsonProperty("chat_option_bounties")]
        public bool ChatOptionBounties { get; private set; }

        [JsonProperty("king_quest")]
        public KingQuest KingQuest { get; private set; }

        [JsonProperty("hat_color")]
        public long HatColor { get; private set; }

        [JsonProperty("chat_option_misc")]
        public bool ChatOptionMisc { get; private set; }

        [JsonProperty("leaderboard_stats")]
        public Dictionary<string, long> LeaderboardStats { get; private set; }

        [JsonProperty("last_contract")]
        public long LastContract { get; private set; }

        [JsonProperty("chat_option_prestige_announcements")]
        public bool ChatOptionPrestigeAnnouncements { get; private set; }

        [JsonProperty("hat_enabled")]
        public bool HatEnabled { get; private set; }

        [JsonProperty("chat_option_minor_events")]
        public bool ChatOptionMinorEvents { get; private set; }

        [JsonProperty("chat_option_streaks")]
        public bool ChatOptionStreaks { get; private set; }

        [JsonProperty("zero_point_three_gold_transfer")]
        public bool ZeroPointThreeGoldTransfer { get; private set; }

        [JsonProperty("selected_launch_trail")]
        public string SelectedLaunchTrail { get; private set; }

        [JsonProperty("inv_armor")]
        public DeathRecaps InvArmor { get; private set; }

        [JsonProperty("chat_option_kill_feed")]
        public bool ChatOptionKillFeed { get; private set; }

        [JsonProperty("hotbar_favorites")]
        public List<long> HotbarFavorites { get; private set; }

        [JsonProperty("recent_kills")]
        public List<RecentKill> RecentKills { get; private set; }

        [JsonProperty("apollo_enabled")]
        public bool ApolloEnabled { get; private set; }
    }

    public class ContractChoice
    {
        [JsonProperty("difficulty")]
        public string Difficulty { get; private set; }

        [JsonProperty("gold_reward")]
        public long GoldReward { get; private set; }

        [JsonProperty("progress")]
        public KingQuest Progress { get; private set; }

        [JsonProperty("completion_date")]
        public long CompletionDate { get; private set; }

        [JsonProperty("remaining_ticks")]
        public long RemainingTicks { get; private set; }

        [JsonProperty("key")]
        public string Key { get; private set; }
    }

    public partial class KingQuest
    {
        [JsonProperty("kills", NullValueHandling = NullValueHandling.Ignore)]
        public long? Kills { get; private set; }
    }

    public class DeathRecaps
    {
        [JsonProperty("type")]
        public long Type { get; private set; }

        [JsonProperty("data")]
        public List<long> Data { get; private set; }
    }

    public class EnderchestInventory
    {
        [JsonProperty("type")]
        public long Type { get; private set; }

        [JsonProperty("data")]
        public List<long> Data { get; private set; }
    }

    public class InventoryContent
    {
        [JsonProperty("type")]
        public long Type { get; private set; }

        [JsonProperty("data")]
        public List<long> Data { get; private set; }
    }
    public class EndedContract
    {
        [JsonProperty("difficulty")]
        public string Difficulty { get; private set; }

        [JsonProperty("gold_reward")]
        public long GoldReward { get; private set; }

        [JsonProperty("progress")]
        public Progress Progress { get; private set; }

        [JsonProperty("completion_date")]
        public long CompletionDate { get; private set; }

        [JsonProperty("remaining_ticks")]
        public long RemainingTicks { get; private set; }

        [JsonProperty("key")]
        public string Key { get; private set; }
    }

    public  class Progress
    {
        [JsonProperty("kills", NullValueHandling = NullValueHandling.Ignore)]
        public long? Kills { get; private set; }

        [JsonProperty("shots", NullValueHandling = NullValueHandling.Ignore)]
        public long? Shots { get; private set; }

        [JsonProperty("streak", NullValueHandling = NullValueHandling.Ignore)]
        public long? Streak { get; private set; }
    }

    public class GoldTransaction
    {
        [JsonProperty("amount")]
        public long Amount { get; private set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; private set; }
    }

    public class Prestige
    {
        [JsonProperty("index")]
        public long Index { get; private set; }

        [JsonProperty("xp_on_prestige")]
        public long XpOnPrestige { get; private set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; private set; }
    }

    public class RecentKill
    {
        [JsonProperty("victim")]
        public string Victim { get; private set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; private set; }
    }

    public class PrestigeUnlocks
    {
        [JsonProperty("tier")]
        public long Tier { get; private set; }

        [JsonProperty("acquireDate")]
        public long AcquireDate { get; private set; }

        [JsonProperty("key")]
        public string Unlock { get; private set; }
    }
    public class PitLeaderboardStats
    {
        [JsonProperty("Pit_rage_pit_damage_2019_summer")]
        public long PitRagePitDamage2019Summer { get; private set; }

        [JsonProperty("Pit_raffle_jackpot_2019_summer")]
        public long PitRaffle_Jackpot2019Summer { get; private set; }

        [JsonProperty("Pit_auction_bid_2019_summer")]
        public long PitAuctionBid2019Summer { get; private set; }

        [JsonProperty("Pit_raffle_tickets_2019_summer")]
        public long PitRaffleTickets2019Summer { get; private set; }

        [JsonProperty("Pit_blockhead_blocks_2019_summer")]
        public long PitBlockheadBlocks2019Summer { get; private set; }

        [JsonProperty("Pit_cake_eaten_2019_summer")]
        public long PitCakeEaten2019Summer { get; private set; }

        [JsonProperty("Pit_tdm_blue_kills_2019_summer")]
        public long PitTdmBlueKills2019Summer { get; private set; }

        [JsonProperty("Pit_kotl_gold_2019_summer")]
        public long PitKotlGold2019Summer { get; private set; }

        [JsonProperty("Pit_kills_as_beast_2019_summer")]
        public long PitKillsAsBeast2019Summer { get; private set; }

        [JsonProperty("Pit_kotl_time_2019_summer")]
        public long PitKotlTime2019Summer { get; private set; }

        [JsonProperty("Pit_tdm_red_kills_2019_summer")]
        public long PitTdmRed_Kills2019Summer { get; private set; }
    }
    public class PitStats
    {
        [JsonProperty("playtime_minutes")]
        public long PlaytimeMinutes { get; private set; }

        [JsonProperty("chat_messages")]
        public long ChatMessages { get; private set; }

        [JsonProperty("enderchest_opened")]
        public long EnderchestOpened { get; private set; }

        [JsonProperty("joins")]
        public long Joins { get; private set; }

        [JsonProperty("left_clicks")]
        public long LeftClicks { get; private set; }

        [JsonProperty("gapple_eaten")]
        public long GapplesEaten { get; private set; }

        [JsonProperty("fishing_rod_launched")]
        public long FishingRodLaunched { get; private set; }

        [JsonProperty("blocks_placed")]
        public long BlocksPlaced { get; private set; }

        [JsonProperty("melee_damage_dealt")]
        public long MeleeDamageDealt { get; private set; }

        [JsonProperty("cash_earned")]
        public long CashEarned { get; private set; }

        [JsonProperty("launched_by_launchers")]
        public long LaunchedByLaunchers { get; private set; }

        [JsonProperty("arrows_fired")]
        public long ArrowsFired { get; private set; }

        [JsonProperty("enchanted_tier2")]
        public long EnchantedTier2 { get; private set; }

        [JsonProperty("enchanted_tier1")]
        public long EnchantedTier1 { get; private set; }

        [JsonProperty("bow_damage_received")]
        public long BowDamageReceived { get; private set; }

        [JsonProperty("enchanted_tier3")]
        public long EnchantedTier3 { get; private set; }

        [JsonProperty("kills")]
        public long Kills { get; private set; }

        [JsonProperty("diamond_items_purchased")]
        public long DiamondItemsPurchased { get; private set; }

        [JsonProperty("deaths")]
        public long Deaths { get; private set; }

        [JsonProperty("soups_drank")]
        public long SoupsDrank { get; private set; }

        [JsonProperty("blocks_broken")]
        public long BlocksBroken { get; private set; }

        [JsonProperty("ghead_eaten")]
        public long GheadEaten { get; private set; }

        [JsonProperty("sword_hits")]
        public long SwordHits { get; private set; }

        [JsonProperty("contracts_completed")]
        public long ContractsCompleted { get; private set; }

        [JsonProperty("bow_damage_dealt")]
        public long BowDamageDealt { get; private set; }

        [JsonProperty("contracts_started")]
        public long ContractsStarted { get; private set; }

        [JsonProperty("damage_received")]
        public long DamageReceived { get; private set; }

        [JsonProperty("jumped_longo_pit")]
        public long JumpedlongoPit { get; private set; }

        [JsonProperty("melee_damage_received")]
        public long MeleeDamageReceived { get; private set; }

        [JsonProperty("arrow_hits")]
        public long ArrowHits { get; private set; }

        [JsonProperty("damage_dealt")]
        public long DamageDealt { get; private set; }

        [JsonProperty("assists")]
        public long Assists { get; private set; }

        [JsonProperty("lava_bucket_emptied")]
        public long LavaBucketEmptied { get; private set; }

        [JsonProperty("max_streak")]
        public long MaxStreak { get; private set; }

        [JsonProperty("wheat_farmed")]
        public long WheatFarmed { get; private set; }

        [JsonProperty("night_quests_completed")]
        public long NightQuestsCompleted { get; private set; }
    }
}