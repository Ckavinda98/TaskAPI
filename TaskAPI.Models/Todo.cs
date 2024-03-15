namespace TaskAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { set; get; }
        public DateTime Deu { set; get; }
        public TodoStatus Status { get; set; }
        public int AurthorId {  get; set; }
        public Aurthor Aurthor { get; set; }

    }
}
