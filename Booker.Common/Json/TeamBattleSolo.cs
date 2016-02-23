public class TeamBattleSoloStartSendData
{
    public int bossid;
    public sbyte deck_arthur_type;
    public sbyte deck_arthur_type_idx;
    public PartnerDeckSelectInfo[] partner_deck_selects;
    public long starttime;
}
public class PartnerDeckSelectInfo
{
    public int userid;
    public sbyte arthur_type;
    public sbyte deck_idx;
}
public class TeamBattleSoloStartReceiveData : BaseResponse
{
    public TeamBattleSoloBattleInfo[] battles;
    public int cost_initial;
    public int free_continue_remain;
    public sbyte is_unlimited_free_continue;
    public PartnerDeckInfo[] partner_deck;
    public int seed;
    public int unlimited_free_continue_lv;
}
public class TeamBattleSoloBattleInfo
{
    public TeamBattleSoloDropInfo[] drop;
    public int enemy_partyid;
    public sbyte enemy_type;
    public RewardInfo[] event_special_reward;
}
public class TeamBattleSoloDropInfo
{
    public RewardInfo[] drops;
    public int enemy_idx;
}
public class PartnerDeckInfo
{
    public sbyte arthur_type;
    public int atkp;
    public AvatarInfo avatar = new AvatarInfo();
    public PartnerCardInfo[] deck;
    public int hp;
    public int intp;
    public sbyte job_type;
    public int mndp;
    public int userid;
}
public class TeamBattleSoloEndSendData
{
    public int progress;
    public sbyte is_clear;
    public string[] input_cmd;
    public int[] enemy_dead_bit;
}
public class TeamBattleSoloEndReceiveData : BaseResponse
{
    public ResultRewardInfo[] clear_rewards;
    public CardInfo[] deck_cards;
    public FameResultRewardInfo[] fame_rewards;
    public sbyte is_clear_reward_in_present_box;
    public sbyte is_fame_reward_in_present_box;
    public sbyte is_result_reward_in_present_box;
    public CardInfo[] new_cards;
    public ItemInfo[] new_items;
    public CardStackInfo[] new_stack_cards;
    public FriendUserInfo[] partners;
    public ResultRewardInfo[] result_rewards;
    public int show_boss_coin;
    public UnlockNotificationInfo[] unlock_notice;
    public UserInfo user = new UserInfo();
}
public class FameResultRewardInfo
{
    public sbyte arthur_type;
    public ResultRewardInfo result_reward = new ResultRewardInfo();
}
public class FriendUserInfo
{
    public sbyte arthur_type;
    public string comment;
    public sbyte deck_rank;
    public sbyte is_first_matching;
    public int last_login_time;
    public int leader_card_fame;
    public int leader_card_lv;
    public int leader_cardid;
    public int lv;
    public string name;
    public int pvp_point;
    public sbyte state;
    public int userid;
}