namespace Nexa.Dtos
{
    public interface ITaskCreateDto
    {
        public Guid Id { get; set; }
        public string Status{get;set;}
        public string Tittle{get;set;}
        public string Description{get;set;}
        public Guid UserId { get; set; }
        public  DateTime CompletedAt{get;set;}

    }
    public interface ITaskUpdateDto
    {
        public string Status{get;set;}
        public string Tittle{get;set;}
        public string Description{get;set;}
        public Guid UserId { get; set; } 
    }
    public interface ITaskDeleteDto
    {
        public string id{get;set;}
    }
}