using TestApplication.CQRS.Question.Commands;
using TestDomain.Models;

namespace TestApplication.Convertors.Models;

public static class QuestionModelConvertor
{
    public static Question ToModel(this CreateQuestionCommand command)
    {
        return new Question(command.Letter, command.Answer, command.LevelId, command.QuestionTypeId);
    }

}

