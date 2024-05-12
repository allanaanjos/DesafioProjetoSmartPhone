using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoCelular.Models
{
    public class Iphone : SmartPhone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override string InstalarAplicativo(string nomeApp)
        {
             return $"Para instalar um aplicativo Entre no App Store e procure por {nomeApp}";
        }
    }
}