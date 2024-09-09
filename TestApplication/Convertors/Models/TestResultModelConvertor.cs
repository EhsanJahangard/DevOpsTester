using TestApplication.CQRS.TestResult.Commands;
using TestDomain.Models;

namespace TestApplication.Convertors.Models;

public static class TestResultModelConvertor
{
    public static TestResult ToModel(this CreateTestResultCommand command)
    {
        return new TestResult(dateExam:command.DateExam,testId:command.TestId,grade:command.Grade,description:command.Description,personId:command.PersonId);
    }

}

