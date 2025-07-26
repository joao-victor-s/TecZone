using System.Collections.Generic;

namespace TecZone.Dominio.Entidades
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public ICollection<Order> Requests { get; set; } // user can get any or no requests

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
