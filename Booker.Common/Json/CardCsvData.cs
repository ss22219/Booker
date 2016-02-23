using System;
using System.Runtime.InteropServices;
public enum ENLARGED_SIZE
{
    S,
    M,
    L,
    sizeof_MAX
}
public enum ATTR_USE
{
    NULL,
    EXP,
    EVO,
    GOLD,
    CORE
}
public enum RARITY
{
    NULL,
    NORMAL,
    HIGHNORMAL,
    RARE,
    SUPERRARE,
    ULTRARARE,
    MILLIONRARE,
    sizeof_RARITY
}
public enum SEX
{
    MALE,
    FEMALE,
    INTERSEX,
    UNKNOWN
}
public enum HAND
{
    RIGHT,
    LEFT,
    AMBIDEXTER,
    UNKNOWN
}
public enum COMMENT_TYPE
{
    DOWNLOADING,
    GACHA,
    EVOLUTION,
    LEVEL_UP,
    SKILL_LEVEL_UP,
    LEVEL_MAX,
    EXPLORE_START,
    EXPLORE_SUPPORT,
    EXPLORE_TREASURE,
    EXPLORE_ENEMY,
    LOVE_UP,
    LOVE_MAX,
    SKILL_INVOKE1,
    SKILL_INVOKE2,
    CONTINUE,
    sizeof_COMMENT_TYPE
}

[StructLayout(LayoutKind.Sequential)]
[Serializable]
public struct PARAM
{
    public int hp;
    public int atkp;
    public int intp;
    public int mndp;
}

[StructLayout(LayoutKind.Sequential)]
[Serializable]
public struct DISP_PROFILE
{
    public string sex;
    public string three_size;
    public string height;
    public string weight;
    public string hand;
    public string[] tags;
}
[StructLayout(LayoutKind.Sequential)]
[Serializable]
public struct PICT_ID
{
    public int normal;
    public int normal_kind;
    public int max;
    public int max_kind;
}

[StructLayout(LayoutKind.Sequential)]
[Serializable]
public struct PROFILE
{
    public SEX sex;
    public int bust;
    public int waist;
    public int hip;
    public int height;
    public int weight;
    public HAND hand;
    public PROFILE_TAG[] tags;
}

[StructLayout(LayoutKind.Sequential)]
[Serializable]
public struct SKILL_ID
{
    public int normal_skillid;
    public int arthur_skillid;
    public int skilllv_max;
    public int cutin_kind;
}

public enum VOICE_TYPE
{
    GREETING,
    LEVEL_UP,
    EXPLORE_START,
    EXPLORE_SUPPORT,
    EXPLORE_TREASURE,
    EXPLORE_ENEMY,
    LOVE_UP,
    SKILL_INVOKE1,
    SKILL_INVOKE2,
    CONTINUE,
    sizeof_VOICE_TYPE
}
public enum PROFILE_TAG
{
    NULL,
    SAKE,
    NENREISAGI,
    ONSEN,
    BYOUJAKU,
    YUMITSUKAICOMBO,
    MORIGIRL,
    NIKUSHOKUKEI,
    BISUKURA_DAISUKI
}
[Serializable]
public class CardCsvData
{
    public int attr_use;
    public string author;
    public int base_cardid;
    public string[] comments = new string[15];
    public int cost;
    public DISP_PROFILE[] disp_profiles = new DISP_PROFILE[2];
    public int enlarged_size;
    public string eponym;
    public int exp_table_id;
    public int fame_max;
    public string flavor_text;
    public int id;
    public bool is_downloading_view;
    public int is_stack;
    public bool is_synthon;
    public int love_max;
    public int lv_max;
    public string name;
    public PARAM param_bonus;
    public PARAM param_init;
    public PARAM param_max;
    public PICT_ID pict_id;
    public PROFILE profile;
    public int rarity;
    public int rarity_max;
    public string role_from;
    public int same_cardid;
    public int sell;
    public SKILL_ID skill_id;
    public string sub_name;
    public string voicer;
    public int[] voices = new int[10];
}