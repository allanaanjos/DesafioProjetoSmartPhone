using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoCelular.Models
{
    public class Nokia : SmartPhone
    {
        public Nokia(string numero, string modelo, string imei, int memoria):base(numero, modelo, imei,memoria)
        {}

        public override string InstalarAplicativo(string nomeApp)
        {
            return $"Para instalar um aplicativo Entre no Play Store e procure por {nomeApp}";
        }
    }
}