namespace TecZone.Dominio.Entidades
{
    public class Item : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Preco { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
