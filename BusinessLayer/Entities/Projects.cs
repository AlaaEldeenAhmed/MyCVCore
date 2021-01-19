namespace BusinessLayer.Entities
{
    public class Projects : EntityBase
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ProjectUrl { get; set; }
    }
}
