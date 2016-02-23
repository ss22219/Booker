public class LoginReturn : BaseResponse
{
    public string sess_key { get; set; }
    public string api_url { get; set; }
    public string resource_url { get; set; }
    public string web_url { get; set; }
    public int userid { get; set; }
}