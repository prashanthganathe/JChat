using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizService
{
    public class GroupClass
    {
        public int Id { get; set; }
        public string GName { get; set; }
    }

    public class MessageTbClass
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public string Message { get; set; }
    }

    public class TranxClass
    {
        public int Id { get; set; }
        public int GId { get; set; }
        public int UId { get; set; }
        public string IP { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class Userclass
    {
        public int UId { get; set; }
        public string UName { get; set; }
    }






 



}
