using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaCartorio
{
    public class DtoTotais
    {
        public decimal TotalEntrada { get; private set; }
        public decimal TotalSaida { get; private set; }
        public decimal TotalSaidaDeposito { get; private set; }
        public decimal TotalEntradaDeposito { get; private set; }
        private List<DTOCaixa> List;
        public DtoTotais(List<DTOCaixa> list)
        {
            List = list;
            this.SomarTotoais();
        }

        private void SomarTotoais()
        {
            foreach (DTOCaixa d in List)
            {
                if(!d.DepositoFuturo)
                {
                    TotalEntrada += d.Entrada;
                    TotalSaida += d.Saida;
                }
                else
                {
                    TotalEntradaDeposito += d.Entrada;
                    TotalSaidaDeposito += d.Saida;
                }
            }
        }

    }
}
