using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizService
{


    public class tempMsg
    {
        public DateTime dt;
        public string GName;
        public string FromIP;
        public string UsrFrom;
        public string UsrTo;
        public string ToIP;
        public string Message;
        public string MessageType;
        public int MID;

    }
   public class MessageService
    {
       ModelEntities model = new ModelEntities();
       public enum MsgType { Joined, Message, Left, Idle};

       public int AddMsg(MessageTb msg)
       {
           msg.Delivered = false;
           model.MessageTbs.AddObject(msg);
           return model.SaveChanges();
       }

     
       public IEnumerable<object> GetAllUnDeliveredMessage()
       {
           var varmsg = (from msg in model.MessageTbs
                         join UserFrom in model.Users on msg.FromIP equals UserFrom.IP
                         join UserTo in model.Users on msg.ToIP equals UserTo.IP
                         join Grp in model.Groups on msg.GID equals Grp.GId
                         where msg.Delivered == false
                         select new { msg.DateTime, Grp.GName, msg.FromIP,UsrFrom=UserFrom.UName,UsrTo=UserTo.UName,msg.ToIP, msg.Message, msg.MessageType, msg.MID }).ToList();
           SetMessageDelivered((IEnumerable<tempMsg>)varmsg);
           return varmsg;
       }

       public int SetMessageDelivered(IEnumerable<tempMsg> msgs)
       { 
           //find a optimized way to update the list of MId
           MessageTb objMsgTb;        
           for (int i = 0; i < msgs.Count(); i++)
           {
               objMsgTb = new MessageTb();               
               objMsgTb = model.MessageTbs.Single(e => e.MID == msgs.ToList()[i].MID); 
               objMsgTb.Delivered = true;             
               model.SaveChanges();
           }
           return 1;
       }

        public IEnumerable<object> GetAllUnDeliveredMessageByGrp(int GrpID)
       {
           var varmsg = (from msg in model.MessageTbs
                      join UserFrom in model.Users on msg.FromIP equals UserFrom.IP
                      join UserTo in model.Users on msg.ToIP equals UserTo.IP
                      join Grp in model.Groups on msg.GID equals Grp.GId
                      where msg.Delivered == false && Grp.GId == GrpID
                      select new { msg.DateTime, Grp.GName, msg.FromIP, UsrFrom = UserFrom.UName, UsrTo = UserTo.UName, msg.ToIP, msg.Message, msg.MessageType, msg.MID }).ToList();           
           return varmsg;
       }



        public IEnumerable<object> GetRecentMessagesByGroup(int messageCount, int GrpID)
        {
            messageCount = messageCount == 0 ? 100 : messageCount;
            var varmsg = (from msg in model.MessageTbs
                          where msg.GID == GrpID
                          select msg).Take(messageCount).ToList();
            return varmsg;
        }


        public IEnumerable<object> GetMessageByOnetoOne(string FromIP,string ToIP,int messageCount)
        {
           messageCount= messageCount == 0 ? 100 : messageCount;
            var varmsg = (from msg in model.MessageTbs
                          where msg.FromIP == FromIP && msg.ToIP == ToIP orderby msg.DateTime
                          select msg).ToList();
            return varmsg;
        }
           
    }
}
