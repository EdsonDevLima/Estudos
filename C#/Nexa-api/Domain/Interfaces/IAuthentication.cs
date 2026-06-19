namespace Nexa.Domain.Interfaces
{
    public class IPassword
    {
        public string password;
    }
    public class IPayloadJwt
    {
        public string email;
        public string id;
        public string role;
        public string[] permitions;
    }
}