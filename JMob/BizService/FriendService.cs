using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizService
{
   public  class FriendService
    {
       ModelEntities cont = new ModelEntities();
       public int Create(Friend obj)
       {
           var Frnd = cont.Friends.Single(e => e.UID == obj.UID && e.FrID ==obj.FrID && e.GID== obj.GID);
           if (Frnd != null)
           {
               return Frnd.FId;
           }
           cont.Friends.AddObject(obj);
           cont.SaveChanges();
           return Frnd.FId;
       }
    }
}
