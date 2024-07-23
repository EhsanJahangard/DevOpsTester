namespace AuthenticationDomain
{
    public class VerificationCode
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Code { get; set; }
        public DateTime ExpireTime { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        private VerificationCode() { }

        public VerificationCode(string username, string code, DateTime expireTime)
        {
            Username = username;
            Code = code;
            ExpireTime = expireTime;
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }

        public void Update(string code,DateTime expireTime)
        {
            Code = code;
            ExpireTime = expireTime;    
            UpdateDate = DateTime.Now;
        }
    }
}
