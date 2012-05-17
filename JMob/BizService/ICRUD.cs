using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizService
{
    public interface ICRUD
    {
        public int Create(object obj);
        public int Update(object obj);
        public int GetList();
        public int Delete(int id);
        public bool IsExist(object obj);
    }
}
