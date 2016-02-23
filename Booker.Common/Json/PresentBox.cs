public class PresentBoxInfo
{
    public string comment { get; set; }
    public long presentid { get; set; }
    public Reward reward { get; set; }
}
public class PresentBoxReceiveData : BaseResponse
{
    public long[] failed_presentid;
    public long[] presentid;
    public ResultRewardInfo[] result_rewards;
    public UserInfo user = new UserInfo();
}
public class PresentBoxRevPostData
{
    public long presentid;
}
public class PresentBoxShowReceiveData
{
    public PresentBoxInfo[] histories;
    public PresentBoxInfo[] presents;
}