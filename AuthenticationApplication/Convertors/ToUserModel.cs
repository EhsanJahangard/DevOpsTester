using AuthenticationApplication.Commands.User;
using AuthenticationDomain;

namespace AuthenticationApplication.Convertors
{
    public static class ToUserModel
    {
        public static User ToModel(this AddUserCommand command)
        {
            return new User(command.FirstName, command.LastName, command.Email, command.UserName,command.Mobile,command.Sender);
        }

        public static User ToModel(this UpdateUserCommand command)
        {
            return new User(command.FirstName, command.LastName, command.Email, command.Username, command.Mobile, command.Sender);
        }
    }
}
