using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TecZone.Dominio.Entidades
{
    public abstract class Entity 
    {
        private List<string> _validationMessage {  get; set; }
        private List<string> _message {
            // Returns _validationMessage if it's not null; otherwise, initializes it as a new List<string>
            // a ?? b -> returns a if it's not null; otherwise, returns b
            get { return _validationMessage ?? (_validationMessage = new List<string>()); }
        }
        protected void ClearMessage()
        {
            _message.Clear();
        }
        protected void AddMessage(string message)
        {
            _message.Add(message);
        }
        // Must be implemented in derived classes to define business validation logic
        public abstract void Validate();

        // Returns true if there are no validation messages
        protected bool IsValid
        {
            get { return !_message.Any();  }
        }

    }
}
