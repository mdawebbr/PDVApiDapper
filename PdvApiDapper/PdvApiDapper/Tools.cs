using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PdvApiDapper.Tools
{
    public class Tools
    {
        public String CalculaNotas(double valorDado,double valorDevido )
        {
            int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };
            int[] moedas = { 50, 25, 10, 5, 1 };
            String resultado;
            double troco;
            int i, valor, contador;

            troco = valorDado - valorDevido;

            resultado = "\n";

            // parte inteira do troco 
            valor = (int)troco;
            i = 0; while (valor != 0)
            {
                contador = valor / cedulas[i];
                // quantidade de notas
                if (contador != 0)
                {
                    resultado += (contador + " nota(s) de R$ " + cedulas[i] + " \n ");
                    valor %= cedulas[i];
                    // resto
                }
                i = i + 1;
                // próxima nota
            }
            resultado += "\n";
            // parte fracionária do troco

            valor = (int)Math.Round((troco - (int)troco) * 100);
            i = 0;
            while (valor != 0)
            {
                contador = valor / moedas[i];
                // quantidade de moedas
                if (contador != 0)
                {
                    resultado += (contador + " moeda(s) de " + moedas[i] + " centavo(s) \n ");
                    valor %= moedas[i];
                    // resto
                }
                i += 1;
                // próximo 
            }

            return (resultado);
        }
    }
}
