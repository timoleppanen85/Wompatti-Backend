using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;

namespace WompattiApi.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        public Question CreateQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public Question ReadQuestion(long id)
        {
            throw new NotImplementedException();
        }

        public List<Question> ReadQuestions()
        {
            throw new NotImplementedException();
        }

        public List<Question> ReadQuestions(string searchQuestion)
        {
            throw new NotImplementedException();
        }

        public Question UpdateQuestion(Question question, long id)
        {
            throw new NotImplementedException();
        }
    }
}
