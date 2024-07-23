using Microsoft.AspNetCore.Identity;

namespace AuthenticationDomain
{
    public class User : IdentityUser
    {
        public User(string firstName, string lastName,string email,string username,string mobile,string sender) : base(username)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Mobile = mobile;
            Creator = sender;
            CreateDate = DateTime.Now;
            Editor = sender;
            EditDate = DateTime.Now;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Mobile { get; private set; }
        public string Creator { get; private set; }
        public DateTime CreateDate { get; private set; }
        public string Editor { get; set; }
        public DateTime EditDate { get; set; }

        public void Update(User user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            Mobile = user.Mobile;
            Editor = user.Editor;
            EditDate = DateTime.Now;
        }

        private User() { }

    }
}
