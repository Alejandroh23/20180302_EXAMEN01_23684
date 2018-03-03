using System;
namespace _EXAMEN01_23684.Protocols
{
    public class Http:Protocolo
    {
        public string Transferencia(Banco meta, Double monto)
        {
            Console.WriteLine("Monto mandado y confirmado por Http");
        }
    }
}