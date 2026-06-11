namespace TodoApi.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        private string Name{get;set;}
        private string Position{get;set;}
        private string Email{get;set;}
        private string Password{get;set;}

        private string Role{get;set;}
    
        public UserEntity(string name, string email, string position,string role)
        {
            Id = Guid.NewGuid();
            this.Name = name;
            this.Email = email;
            this.Position = position;
            this.Role = role;
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