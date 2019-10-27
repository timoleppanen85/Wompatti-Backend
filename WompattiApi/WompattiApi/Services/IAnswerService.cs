﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;

namespace WompattiApi.Services
{
    public interface IAnswerService
    {
        Answer CreateAnswer(Answer answer);
        Answer ReadAnswer(long id);
        List<Answer> ReadAnswers();
        List<Answer> ReadAnswers(string searchAnswer);
        Answer UpdateAnswer(Answer answer, long id);
        Answer DeleteAnswer(long id);
    }
}
