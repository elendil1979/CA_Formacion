namespace CA_Formacion.Entities.POCO
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BreedId { get; set; }
        public Breed Breed { get; set; }
    }
}
