namespace Nexa.Dtos
{
    public interface IUserCreateDto
    {
        public string name{get;set;}
        public string email{get;set;}
        public string password{get;set;}
        public string confirmPassword{get;set;}
    }
    public interface IUserUpdateDto
    {
        public string name{get;set;}
        public string email{get;set;}
        public string password{get;set;}
        public string confirmPassword{get;set;}  
    }
    public interface IUserDeleteDto
    {
        public string id{get;set;}
        public string email{get;set;}
    }
    public class ResponseDto
    {
        public int code{get;set;}
        public string message{get;set;}
    }
        public class ResponseDtoWitchItems
    {
        public int code{get;set;}
        public string message{get;set;}
        public List<object> items{get;set;}
    }
}