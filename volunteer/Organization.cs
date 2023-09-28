namespace volunteer
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }

        public string Logo { get; set; }

        public Organization(int id, string name, string description, string website, string logo)
        {
            Id = id;
            Name = name;
            Description = description;
            Website = website;
            Logo = logo;
        }
    }
}