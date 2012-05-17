using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizService
{
   public class MessageService
    {
       JModel model = new JModel();
       public enum MsgType { Joined, Message, Left, }

       public IEnumerable<object> GetMessageDetails(int GrpId)
       {

           


           //var Grpchatlist = (from Msg in model.MessageTbs
           //               join TnxFrom in cont.Tranges on Msg.FromTID  equals TnxFrom.Id
           //               join TnxTo in cont.Tranges on Msg.ToTID equals TnxTo.UId

           //               join Usr in cont.Users on 
                           
           //                from Grp in cont.Groups

           //                where TnxTo.GId==GrpId && TnxFrom.GId==GrpId
           //                 select new {Msg.Message,}).ToList();

           //if (Grpchatlist == null)
           //{
           //    return new List<string> { " No users in the Group " };
           //}
           //else
           //    return Grpchatlist;
       }
    }
}
