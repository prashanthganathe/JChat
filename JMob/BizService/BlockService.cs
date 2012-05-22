using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizService
{
    public class BlockService
    {
        ModelEntities cont = new ModelEntities();
        public int Create(Block obj)
        {            
            cont.Blocks.AddObject(obj);
            return cont.SaveChanges();
        }
    }
}
