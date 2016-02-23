public class HomeShowReceiveData : BaseResponse
{
    public int background;
    public HomeBannerInfo[] banners;
    public FPRewardInfo[] fp_reward;
    public LoginBonusBeginnerInfo[] login_bonus_beginner;
    public LoginBonusDailyInfo[] login_bonus_daily;
    public LoginBonusTotalInfo[] login_bonus_total;
    public QuestInfo[] quests;
    public int server_time;
    public UserInfo user = new UserInfo();
}