using TestApplication.CQRS.QuestionPhoto.Commands;
using TestDomain.Models;

namespace TestApplication.Convertors.Models;

public static class QuestionPhotoModelConvertor
{
    public static QuestionPhoto ToModel(this CreateQuestionPhotoCommand command)
    {
        return new QuestionPhoto(command.Title, command.QuestionId);
    }

}

