using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(){}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }else
            {
                throw new Exception("A capacidade da suite e menor que o numeor de hospedes recebico");

            }
        }

        public void CadastraSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObeterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count();
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal desconto = 0.10M;
            decimal valorfinal = Suite.ValorDiaria * DiasReservados;

            if(DiasReservados >= 10)
            {
                valorfinal -= Suite.ValorDiaria * desconto;
            }

            return valorfinal;
        }
    }
}