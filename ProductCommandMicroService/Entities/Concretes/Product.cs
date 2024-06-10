using ProductCommandMicroService.Entities.Abstracts;

namespace ProductCommandMicroService.Entities.Concretes
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
