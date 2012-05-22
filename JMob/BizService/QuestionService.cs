using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizService
{
    public class QuestionService
    {
        ModelEntities model = new ModelEntities();

        public int AddQuestion(Question ques)
        {            
            model.Questions.AddObject(ques);
            return model.SaveChanges();
        }

        public IEnumerable<object> ShowQuestions()
        {
           return model.Questions.ToList();
        }
    }
}
