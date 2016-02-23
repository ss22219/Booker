

using System;

    public class ConnectReceiveData : BaseResponse
    {
        public sbyte is_user;
        public long navi_unlock_flag;
        public PushOption push_option = new PushOption();
        public RevisionInfo[] revision;
    
}

