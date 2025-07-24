
namespace TecZone.Dominio.Entidades
{
    public class OrderItem : Entity
    {
        public int Id { get; set; }
        public string IdProduct { get; set; }
        public int Quantity { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
