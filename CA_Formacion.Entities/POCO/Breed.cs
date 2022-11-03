namespace CA_Formacion.Entities.POCO
{
    public class Breed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxAge { get; set; }
        public IEnumerable<Dog> Dogs { get; set; }
    }
}