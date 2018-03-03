using System;
namespace _EXAMEN01_23684.Banco
{
    public class BancoPrincipal
    {
        public String name;
        public Transferbehaviour transferBehaviour;
        public Protocol protocol;

        public BancoPrincipal(String name, Protocol protocol, Transfer transfer)
        {
            this.name = name;
            this.protocol = protocol;
            this.transfer = transfer;
        }
        public void setProtocol(Protocols protocol)
        {
            this.protocol = protocols;
        }

        public void setTransfer(Transfer transfer)
        {
            this.setTransfer = transfer;
        }

        public void notifiyUser()
        {
            Console.WriteLine("Usuario notificado");
        }

       }
    }
}