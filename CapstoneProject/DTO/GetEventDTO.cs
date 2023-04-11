namespace CapstoneProject.DTO
{
    public class GetEventDTO
    {
        public int Evid { get; set; }

        public string? EventName { get; set; }

        public string? EventDescription { get; set; }

        public string? EventImage { get; set; }

        public string? EventLink { get; set; }

        public DateTime? EventDate { get; set; }
    }
}
