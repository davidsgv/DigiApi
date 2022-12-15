namespace DigiApi.DataContext
{
    public class Digimon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int PreviousEvolution { get; set; }
        public int NextEvolution { get; set; }

        public List<Type>? Types { get; set; }
        public List<Atribute>? Atributes { get; set; }


    }
}
