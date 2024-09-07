using TestApplication.CQRS.QuestionOption.Commands;
using TestDomain.Models;

namespace TestApplication.Convertors.Models;

public static class QuestionOptionModelConvertor
{
    public static QuestionOption ToModel(this CreateQuestionOptionCommand command)
    {
        return new QuestionOption(command.Title,command.QuestionId);
    }

}

