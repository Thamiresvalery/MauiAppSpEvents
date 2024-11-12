using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppSpEvents.Models
{
    public class Evento
    {
        public string Descricao { get; set; }
        public string Local {  get; set; }
        public double ValorDiariaMulher {  get; set; }
        public double ValorDiariaHomem { get; set; }

        public static explicit operator Evento(Picker v)
        {
            throw new NotImplementedException();
        }
    }
}
