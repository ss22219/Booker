
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConnectReturn : BaseResponse
{
    public sbyte is_user;
    public long navi_unlock_flag;
    public PushOption push_option = new PushOption();
    public RevisionInfo[] revision;
}