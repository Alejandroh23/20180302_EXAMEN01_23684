using System;
namespace _EXAMEN01_23684.Banco
{
    public class BancoEste: BancoPrincipal
    {
        public BancoEste(String name, Protocol protocol, Transfer transfer)
        {
            notifiyUser(name, protocol, transfer);
            this.transfer();
        }

        @Override
    public void Transfer(Banco meta, double monto)
        {
            String message = (String)IFormattable.ReferenceEquals(BancoEste, BancoWoods);
            protocol.Transfer(meta, monto, notifiyUser);
        }
    }
}
