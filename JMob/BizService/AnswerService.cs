using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizService
{
    public class AnswerService
    {
        ModelEntities model = new ModelEntities();

        public IEnumerable<object> GetAnswers(int Qid)
        {
           var ans=  (from answ in model.Answers
                      where answ.QID==Qid
                      select new {answ.AId,answ.Answer1,answ.DateTime, answ.Agree}).ToList();
            return ans;

        }

        //public int AddAnswer(Answer ans)
        //{
        //}

    }
}
