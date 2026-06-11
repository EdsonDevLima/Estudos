namespace Nexa.Entities
{
    public class TaskEntity
    {
        public Guid Id { get; set; }
        public string Status{get;set;}
        private string Tittle{get;set;}
        private string Description{get;set;}
        public Guid UserId { get; set; }
        private  DateTime CreateAt = DateTime.Now;
        private  DateTime CompletedAt{get;set;}

        public TaskEntity(string tittle,string status,string description,Guid userId,DateTime completedAt)
        {
            Id = Guid.NewGuid();
            this.Tittle = tittle;
            this.Description = description;
            this.UserId = userId;
            this.CompletedAt = completedAt;
            this.Status = status;
        }


    }
    
}