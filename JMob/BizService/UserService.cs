using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizService
{
    public class UserService
    {
       JModelEntities model = new JModelEntities();
        public int Create(User obj)
        {
            var Grp = model.Users.Single(e => e.IP == obj.IP);
            if (Grp != null)
                return Grp.UId;
            obj.UName = GetUniqueUser();
            model.Users.AddObject(obj);
            return model.SaveChanges();            
        }

        public string GetUniqueUser()
        {
            Random random = new Random();
            string username = "User" + random.Next(0, 1000);
            var Grp = model.Users.Single(e => e.UName == username);
            if (Grp == null)
            {
                return username;
            }
            else
                return GetUniqueUser();
        }

        public int UpdateUser(User obj)
        {
            var Usr = model.Users.Single(e => e.UId == obj.UId );
            if (Usr != null)
            {
                Usr.UName = obj.UName;
                Usr.Status = obj.Status;
                Usr.Model = obj.Model;
                Usr.LastLogin = DateTime.Now;
                Usr.BlockCount = obj.BlockCount;
            }
            return model.SaveChanges();
        }

        public bool IncreaseBlockCount(int UId)
        {
            var Usr = model.Users.Single(e => e.UId == UId);
            if (Usr != null)
            {
                Usr.BlockCount = Usr.BlockCount+1;
                return model.SaveChanges()>0?true:false;
            }
            return false;
        }



        public int Update(User obj)
        {
            var Grp = cont.Users.Single(e => e.UId == obj.UId);
            if (Grp != null)
            {
                Grp.UName = obj.UName;
                return cont.SaveChanges();
            }
            return 0;
        }

        public int Delete(int id)
        {
            var Usr = cont.Users.Single(e => e.UId == id);
            if (Usr != null)
            {
                cont.Users.DeleteObject(Usr);
                return cont.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<User> GetGroups()
        {
            return cont.Users.ToList();
        }
    }
}
