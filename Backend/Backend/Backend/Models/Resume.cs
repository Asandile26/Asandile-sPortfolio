namespace Backend.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string NameOfInstitution { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
