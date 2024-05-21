using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaCartorio
{
    public class DTOCaixa
    {
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public string Historico { get; set; }
        public decimal Entrada { get; set; }
        public decimal Saida { get; set; }
        public string Forma { get; set; }
        public bool DepositoFuturo { get; set; }
       
        public DTOCaixa(int codigo, DateTime data, string historico, decimal entrada, decimal saida, string forma, bool deposito)
        {
            this.Codigo = codigo;
            this.Data = data;   
            this.Entrada = entrada;
            this.Saida = saida;
            this.Forma = forma;
            this.DepositoFuturo = deposito;
            this.Historico = historico;
        }
        
        public DTOCaixa() {   
        }
    }
}
