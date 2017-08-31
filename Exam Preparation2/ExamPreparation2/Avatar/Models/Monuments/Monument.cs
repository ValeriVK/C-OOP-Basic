namespace Avatar.Models.Monuments
{
    public abstract class Monument
    {
        public Monument(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public int Affinity { get; set; }

    
    }
}