using System;
namespace _EXAMEN01_23684.Protocols
{
    public class Email : Protocolo
    {
        public string Transferencia (Banco meta, Double monto)
        {
            Console.WriteLine("Monto mandado y confirmado por mensaje de correo");
        }
    }
}
