using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizService
{
    public class GroupService
    {
        JEntities1 cont = new JEntities1();
        public int Create(Group obj)
        {
          var Grp= cont.Groups.Single(e => e.GName == obj.GName);
          if (Grp != null)
          {
              Random random = new Random();
              obj.GName = obj.GName + random.Next(0, 100);
          }
          cont.Groups.AddObject(obj);
          return cont.SaveChanges(); 
        }

        public int Update(Group obj)
        {
            var Grp = cont.Groups.Single(e => e.Id == obj.Id);
            if (Grp != null)
            {
                Grp.GName = obj.GName;
                return cont.SaveChanges();
            }
            return 0;          
        }

        public int Delete(int id)
        {
            var Grp = cont.Groups.Single(e => e.Id == id);
            if (Grp != null)
            {
                cont.Groups.DeleteObject(Grp);
                return cont.SaveChanges();
            }
            return 0;    
        }

        public IEnumerable<Group> GetGroups()
        {
            return cont.Groups.ToList();
        }
    }
}
