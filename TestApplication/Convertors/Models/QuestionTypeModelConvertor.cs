using TestApplication.CQRS.QuestionType.Commands;
using TestDomain.Models;

namespace TestApplication.Convertors.Models;

public static class QuestionTypeModelConvertor
{
    public static QuestionType ToModel(this CreateQuestionTypeCommand command)
    {
        return new QuestionType(command.Title);
    }

}
