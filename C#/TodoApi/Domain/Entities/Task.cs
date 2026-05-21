namespace TodoApi.Entities
{
    public class Task
    {
        private string Tittle{get;set;}
        private string Description{get;set;}
        private string Responsible{get;set;}
        private  DateTime CreateAt = DateTime.Now;
        private  DateTime CompletedAt{get;set;}

        public Task(string tittle,string description,string responsible,DateTime completedAt)
        {
            this.Tittle = tittle;
            this.Description = description;
            this.Responsible = responsible;
            this.CompletedAt = completedAt;
        }


    }
    
}