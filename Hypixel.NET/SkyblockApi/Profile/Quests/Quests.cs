using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class Quests
    {
        [JsonProperty("collect_log")]
        public CollectLog CollectLog { get; private set; }

        [JsonProperty("explore_hub")]
        public ExploreHub ExploreHub { get; private set; }

        [JsonProperty("explore_village")]
        public ExploreVillage ExploreVillage { get; private set; }

        [JsonProperty("talk_to_librarian")]
        public TalkToLibrarian TalkToLibrarian { get; private set; }

        [JsonProperty("talk_to_farmer")]
        public TalkToFarmer TalkToFarmer { get; private set; }

        [JsonProperty("talk_to_blacksmith")]
        public TalkToBlacksmith TalkToBlacksmith { get; private set; }

        [JsonProperty("talk_to_lumberjack")]
        public TalkToLumberjack TalkToLumberjack { get; private set; }

        [JsonProperty("talk_to_auction_master")]
        public TalkToAuctionMaster TalkToAuctionMaster { get; private set; }

        [JsonProperty("talk_to_banker")]
        public TalkToBanker TalkToBanker { get; private set; }

        [JsonProperty("talk_to_carpenter")]
        public TalkToCarpenter TalkToCarpenter { get; private set; }

        [JsonProperty("talk_to_artist_1")]
        public TalkToArtist TalkToArtist { get; private set; }

        [JsonProperty("kill_danger_mobs")]
        public KillDangerMobs KillDangerMobs { get; private set; }

        [JsonProperty("talk_to_farmhand_1")]
        public TalkToFarmhand TalkToFarmhand { get; private set; }

        [JsonProperty("increase_farming_skill_5")]
        public IncreaseFarmingSkill5 IncreaseFarmingSkill5 { get; private set; }

        [JsonProperty("reforge_item")]
        public ReforgeItem ReforgeItem { get; private set; }

        [JsonProperty("increase_foraging_skill_5")]
        public IncreaseForagingSkill5 IncreaseForagingSkill5 { get; private set; }

        [JsonProperty("increase_combat_skill_5")]
        public IncreaseCombatSkill5 IncreaseCombatSkill5 { get; private set; }

        [JsonProperty("talk_to_rick")]
        public TalkToRick TalkToRick { get; private set; }

        [JsonProperty("talk_to_lazy_miner")]
        public TalkToLazyMiner TalkToLazyMiner { get; private set; }

        [JsonProperty("increase_mining_skill_5")]
        public IncreaseMiningSkill5 IncreaseMiningSkill5 { get; private set; }

        [JsonProperty("talk_to_lapis_miner")]
        public TalkToLapisMiner TalkToLapisMiner { get; private set; }

        [JsonProperty("talk_to_guber_1")]
        public TalkToGuber TalkToGuber { get; private set; }

        [JsonProperty("talk_to_end_dealer")]
        public TalkToEndDealer TalkToEndDealer { get; private set; }
    }
}