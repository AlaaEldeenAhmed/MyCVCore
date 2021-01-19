namespace BusinessLayer.Entities
{
    public class Owner  : EntityBase
    {
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string ImageUrl { get; set; }
        public Address Address { get; set; }
    }
}
