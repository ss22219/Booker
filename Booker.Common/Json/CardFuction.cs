public class CardStackInfo
{
    public int add_exp;
    public int base_add_price;
    public int cardid;
    public int num;
    public int atkp;
    public int hp;
    public int intp;
    public int mndp;
}
public class CardShow2ReceiveData
{
    public AvatarInfo[] avatars;
    public CardInfo[] cards;
    public DeckInfo[] decks;
    public CardStackInfo[] stack_cards;
}
public class DeckInfo
{
    public sbyte arthur_type;
    public long[] card_uniqid;
    public sbyte deck_rank;
    public sbyte idx;
    public sbyte is_active;
    public sbyte is_rental;
    public sbyte job_type;
    public sbyte leader_card_idx;
    public string name;
}
public class CardSellSendData
{
    public int[] cardids;
    public long[] uniqids;
}
public class CardSellReceiveData
{
    public int card_num; //当前玩家持有卡牌数量
    public DeckInfo[] decks;
    public int get_gold; //出售卡牌获得的金币数量
}
public class CardLockSendData
{
    public long uniqid;
}
public class CardUnlockSendData
{
    public long uniqid;
}
public class CardInfo
{
    public int cardid;
    public int create_time;
    public int fame;
    public sbyte is_lock;
    public short[] skill_lv;
    public long uniqid;
    public int add_exp { get; set; }

    public int atkp { get; set; }
    public int base_add_price { get; set; }
    public int exp { get; set; }
    public int hp { get; set; }

    public int intp { get; set; }

    public int love { get; set; }

    public int lv { get; set; }

    public int lv_max { get; set; }

    public int mndp { get; set; }

    public int next_lv_exp { get; set; }
    public int now_lv_exp { get; set; }
}
public class CardFusionSendData
{
    //public int[] add_cardids;
    public long base_uniqid; //要强化的卡牌唯一识别码
    public long[] add_uniqids;//作为狗粮的卡片的唯一识别码   
}
public class CardFusionReceiveData : BaseResponse
{
    public CardInfo base_card = new CardInfo(); //强化后的卡牌数据
    public int card_num;//玩家当前持有的卡片数目
    public DeckInfo[] decks;
    public int gold; //当前玩家金币数量
    public int success_type;//成功类型
}
public class CardEvolutionSendData
{
    public long base_uniqid;//需要进化的卡片唯一识别码
    public int to_cardid; //进化后的卡片ID
    public int[] add_cardids;//进化素材的卡片ID
    //public long[] add_uniqids;
}
public class CardEvolutionReceiveData
{
    public CardInfo base_card = new CardInfo(); //进化后的卡牌数据
    public int card_num; //当前玩家持有卡牌数量
    public DeckInfo[] decks;
    public int gold; //出售卡牌获得的金币数量
    public ResultRewardInfo reward = new ResultRewardInfo();
}