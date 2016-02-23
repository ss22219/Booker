using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GachaPlaySendData
{
    public string gacha_hash;
    public int gachaid;
    public int pay_type;
        //NULL = 0,
        //GOLD = 1,
        //FP = 2,
        //COIN = 3,
        //ITEM = 4,
        //FREE = 5    
}
public class GachaPlayReceiveData
{
    public CardInfo[] cards;
    public sbyte[] expectancy;
    public GachaInfo[] gacha_list;
    public RewardInfo[] gift_direct;
    public RewardInfo[] gift_present;
    public sbyte is_reward_in_present_box;
    public ItemInfo item = new ItemInfo();
    public ResultRewardInfo[] present_box_cards;
    public ResultRewardInfo[] rewards;
    public CardStackInfo[] stack_cards;
    public UserInfo user = new UserInfo();
}
public class GachaInfo
{
    public sbyte arthur_type{get;set;}
    public GachaBoxLineupInfo[] box_lineup { get; set; }
    public int box_max { get; set; }
    public int box_now { get; set; }
    public string buymsg { get; set; }
    public int card_num { get; set; }
    public int card_num_max { get; set; }
    public int[] focus_cardid { get; set; }
    public int gacha_catagory { get; set; }
    public string gacha_name { get; set; }
    public sbyte gacha_type { get; set; }
    public int gachaid { get; set; }
    public int groupid { get; set; }
    public sbyte is_daily_first { get; set; }
    public sbyte is_enable_box_reset { get; set; }
    public sbyte is_stepup_price { get; set; }
    public int order_num { get; set; }
    public PAY_TYPE pay_type { get; set; }
    public int pay_typeid { get; set; }
    public int play_count { get; set; }
    public int play_count_max { get; set; }
    public int play_count_priority_price { get; set; }
    public int price { get; set; }
    public int showtype { get; set; }
}
public class GachaBoxLineupInfo
{
    public int cardid;
    public int max;
    public int now;
    public int type;
}
public class GachaShowReceiveData
{
    public HomeBannerInfo[] banners;
    public GachaInfo[] gacha_list;
}
public enum PAY_TYPE
{
    NULL = 0 ,
    GOLD = 1,
    FP = 2,
    COIN = 3,
    ITEM = 4,
    FREE = 5
}