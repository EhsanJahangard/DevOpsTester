using TestApplication.CQRS.Photo.Commands;
using TestDomain.Models;

namespace TestApplication.Convertors.Models;

public static class PhotoModelConvertor
{
    public static Photo ToModel(this CreatePhotoCommand command)
    {
        return new Photo(command.Title, command.Url);
    }

}

