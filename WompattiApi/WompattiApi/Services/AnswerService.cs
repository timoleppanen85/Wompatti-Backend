using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;
using WompattiApi.Repositories;

namespace WompattiApi.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly AnswerRepository _answerRepository;

        public AnswerService(AnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }

        public Answer CreateAnswer(Answer answer)
        {
            return _answerRepository.CreateAnswer(answer);
        }

        public Answer DeleteAnswer(long id)
        {
            Answer answer = ReadAnswer(id);
            return _answerRepository.DeleteAnswer(answer);
        }

        public Answer ReadAnswer(long id)
        {
            return _answerRepository.ReadAnswer(id);
        }

        public List<Answer> ReadAnswers()
        {
            return _answerRepository.ReadAnswers();
        }

        public List<Answer> ReadAnswers(string searchAnswer)
        {
            return _answerRepository.ReadAnswers(searchAnswer);
        }

        public Answer UpdateAnswer(Answer answer, long id)
        {
            Answer checkAnswer = ReadAnswer(id);

            if (checkAnswer.Equals(answer))
            {
                return _answerRepository.UpdateAnswer(answer);
            }
            else
            {
                return answer;
            }
        }
    }
}
