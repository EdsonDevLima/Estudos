namespace TodoApi.Entities
{
    public class User
    {
        private string Name{get;set;}
        private string Position{get;set;}
        private string Email{get;set;}
        private string Password{get;set;}
    
        public User(string name, string email, string position)
        {
            this.Name = name;
            this.Email = email;
            this.Position = position;
        }
        public void SetEmail(string newEmail)
        {
            this.Email = newEmail;
        }
        public void SetName(string newName)
        {
            this.Name = newName;
        }
        public void SetPosition(string newPosition)
        {
            this.Position = newPosition;
        }
        public void SetPassword(string newPassword)
        {
            this.Password = newPassword;
        }
        public string ShowUser()
        {
            return $"Name: {this.Name}, Position: {this.Position}, Email: {this.Email}";
        }

    }
}