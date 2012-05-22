using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizService
{
    class UserStateService
    {
        ModelEntities model = new ModelEntities();
        public int Create(UserState obj)
        {
            obj.Datetime = DateTime.Now;

            model.UserStates.AddObject(obj);
            return model.SaveChanges();
        }

        public string GetStatusByUserID(int UId)
        {
            var objUsrStatus = (from a in model.UserStates where a.UID == UId select new {a.Status,a.Datetime}).OrderBy(d => d.Datetime).SingleOrDefault();
            if (objUsrStatus != null)
                return objUsrStatus.Status;
            else
                return "";
        }
    }
}
