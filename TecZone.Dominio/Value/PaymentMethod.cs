using TecZone.Dominio.Enumerates;

namespace TecZone.Dominio.Value
{
    public class PaymentMethod
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsBankSlip
        {
            get {  return Id == (int)PaymentMethodEnum.BankSlip; } // use Id to define the Payment Method 
        }
        public bool IsDebitCard
        {
            get { return Id == (int)PaymentMethodEnum.DebitCard; }  
        }
        public bool IsCreditCard
        {
            get { return Id == (int)PaymentMethodEnum.CreditCard; }
        }
        public bool IsNotDefined
        {
            get { return Id == (int)PaymentMethodEnum.NotDefined; }
        }
    }
}
