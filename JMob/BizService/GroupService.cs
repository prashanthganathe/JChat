using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizService
{
    public class GroupService
    {
        ModelEntities cont = new ModelEntities();
        public int Create(Group obj)
        {
          var Grp= cont.Groups.Single(e => e.GName == obj.GName);
          if (Grp != null)
          {
              return Grp.GId;
          }
          cont.Groups.AddObject(obj);
           cont.SaveChanges();
           return Grp.GId;
        }

        public int Update(Group obj)
        {
            var Grp = cont.Groups.Single(e => e.GId == obj.GId);
            if (Grp != null)
            {
                Grp.GName = obj.GName;
                return cont.SaveChanges();
            }
            return 0;          
        }

        public int Delete(int id)
        {
            var Grp = cont.Groups.Single(e => e.GId == id);
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
