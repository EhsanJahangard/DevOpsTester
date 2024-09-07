using TestApplication.CQRS.TestQuestion.Commands;
using TestDomain.Models;

namespace TestApplication.Convertors.Models;

public static class TestQuestionModelConvertor
{
    public static TestQuestion ToModel(this CreateTestQuestionCommand command)
    {
        return new TestQuestion(command.TestId, command.QuestionId);
    }

}
