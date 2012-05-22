using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizService
{
    public class UserService
    {
       ModelEntities model = new ModelEntities();
        public string Create(User obj)
        {
            var Grp = model.Users.Single(e => e.IP == obj.IP);
            if (Grp != null)
            {
                Grp.LastLogin = DateTime.Now;
                return Grp.UName;
            }
            obj.UName = GetUniqueUser();
            obj.IsActive = true;
            obj.LastLogin = DateTime.Now;            
            model.Users.AddObject(obj);
            if (model.SaveChanges()>0)
                return obj.UName;
            else
                return "";
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
                Usr.Model = obj.Model;
                Usr.LastLogin = DateTime.Now;             
            }
            return model.SaveChanges();
        }

        //public bool IncreaseBlockCount(int UId)
        //{
        //    var Usr = model.Users.Single(e => e.UId == UId);
        //    if (Usr != null)
        //    {
        //        Usr.BlockCount = Usr.BlockCount+1;
        //        return model.SaveChanges()>0?true:false;
        //    }
        //    return false;
        //}



        public int Update(User obj)
        {
            var Grp = model.Users.Single(e => e.UId == obj.UId);
            if (Grp != null)
            {
                Grp.UName = obj.UName;
                return model.SaveChanges();
            }
            return 0;
        }

        public int Delete(int id)
        {
            var Usr = model.Users.Single(e => e.UId == id);
            if (Usr != null)
            {
                model.Users.DeleteObject(Usr);
                return model.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<User> GetGroups()
        {
            return model.Users.ToList();
        }
    }
}
