public class ExploreEndReceiveData
{
    public CardInfo[] deck_cards;
    public sbyte is_result_reward_in_present_box;
    public CardInfo[] new_cards;
    public ItemInfo[] new_items;
    public CardStackInfo[] new_stack_cards;
    public ResultRewardInfo[] result_rewards;
    public UnlockNotificationInfo[] unlock_notice;
    public UserInfo user = new UserInfo();
}
public class ExploreEventBonusInfo
{
    public int type;
    public int value;
}
public class ExploreEventInfo
{
    public ExploreEventSymbolInfo[] symbols;
    public ExploreEventTreasureboxInfo[] treasureboxes;
}
public class ExploreEventSymbolInfo
{
    public ExploreEventBonusInfo[] bonus;
    public RewardInfo[] reward;
}
public class ExploreEventTreasureboxInfo
{
    public ExploreEventBonusInfo[] bonus;
    public int is_rare;
    public RewardInfo[] reward;
    public int talk_cardid;
}
public class ExploreStartSendData
{
    public sbyte arthur_type;
    public sbyte deck_idx;
}

public class ExploreStartReceiveData : BaseResponse
{
    public int ap;
    public int ap_max;
    public int ap_next_sec;
    public sbyte arthur_type;
    public AvatarInfo avatar = new AvatarInfo();
    public ExploreEventInfo[] events;
    public int floor_rarity;
    public int leader_cardid;
    public ExploreStageInfo stage = new ExploreStageInfo();
}
public class ExploreStageInfo
{
    public int explore_stageid;
    public ExploreFloorInfo[] floors;
    public int limit_sec;
    public int stage_mapid;
    public string stage_name;
    public sbyte stage_type;
    public int state_flag;
}
public class ExploreFloorInfo
{
    public int explore_floorid;
    public string floor_name;
}