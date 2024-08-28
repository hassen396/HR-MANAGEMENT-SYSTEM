namespace HRSystem.Domain.Entities
{
    public class JobPosition
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
