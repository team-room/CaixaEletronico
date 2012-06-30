using System.Collections.Generic;
using System.Linq;

namespace TeamOnDojo.CaixaEletronico
{
    public class CaixaEletronico
    {
        List<uint> notasDisponiveis = new List<uint> { 100, 50, 20, 10 };

        public List<uint> Sacar(uint valor)
        {
          
            if (valor % 10 != 0)
                throw new ValorInvalidoException();

            var saque = new List<uint>();

            while (valor > 0)
            {
                uint nota = notasDisponiveis.FirstOrDefault(n => valor >= n);

                if (nota != 0)
                {
                    saque.Add(nota);
                    valor -= nota;
                }
            }

            return saque;
        }
    }
}
