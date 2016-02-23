public class TeamBattleSoloShowReceiveData
{
    public ArthurPartnerInfo[] arthurs;
    public AddCaptainReputaionInfo[] captain_group;
    public TeamBattleBossGroupInfo[] event_groups;
    public TeamBattleBossGroupInfo[] normal_groups;
}
public class ArthurPartnerInfo
{
    public sbyte arthur_type;
    public PartnerInfo[] partners;
}
public class PartnerInfo
{
    public sbyte arthur_type;
    public int atkp;
    public string comment;
    public sbyte deck_rank;
    public int get_fp;
    public int hp;
    public int intp;
    public int is_friend;
    public sbyte job_type;
    public PartnerCardInfo leader_card = new PartnerCardInfo();
    public int lv;
    public int mndp;
    public string name;
    public int userid;
}
public class AddCaptainReputaionInfo
{
    public string cardid;
    public string floor;
    public string job;
    public string pt;
    public string state;
}
public class TeamBattleBossGroupInfo
{
    public int appear_end;
    public int boss_groupid { get; set; }
    public TeamBattleBossInfo[] bosses;
    public sbyte iconindex;
    public string name { get; set; }
    public sbyte stage_type;
}
public class TeamBattleBossInfo
{
    public sbyte arthur_limit { get; set; }
    public int bg_num { get; set; }
    public int bossid { get; set; }
    public int bp_use { get; set; }
    public string difficulty { get; set; }
    public int enemy_partyid { get; set; }
    public string hint { get; set; }
    public sbyte is_continue { get; set; }
    public int is_model { get; set; }
    public sbyte is_only_my_deck { get; set; }
    public string needrank { get; set; }
    public int[] pickup_cardid { get; set; }
    public int pictid { get; set; }
    public int[] reward_cardids { get; set; }
    public int state { get; set; }
    public int unlock_expire_time { get; set; }
    public int[] user_buff_id { get; set; }
}
public class PartnerCardInfo
{
    public int cardid;
    public int love;
    public int lv;
    public short[] skill_lv;
}