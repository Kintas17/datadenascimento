using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datadenascimento
{
    class Class1
    {
        private DateTime data = new DateTime().Date;
        private DateTime tempodevida;

        public string recebe
        {
            set
            {
                data = Convert.ToDateTime(value);
                tempodevida = Convert.ToDateTime(value);
            }
        }
        public string envia
        {
            get
            {
                DateTime hoje = DateTime.Now;
                int anos = hoje.Year - tempodevida.Year;
                int meses = hoje.Month - tempodevida.Month;
                int dias = hoje.Day - tempodevida.Day;
                string frase = "A sua idade é ";
                if (meses < 0)
                {
                    anos--;
                    meses += 12;
                }
                if (dias < 0)
                {
                    meses--;
                    dias += 30;
                }
                frase += anos.ToString() + " anos ";
                frase += meses.ToString() + " meses e ";
                frase += dias.ToString() + " dias ";
                return frase;
            }
        }
        public string envia2
        {
            get
            {
                return "O dia da semana em que você nasceu foi " + data.ToString("dddddd");
            }
        }
        public string envia3
        {
            get
            {
                DateTime hoje = DateTime.Now;
                int meses = hoje.Month - tempodevida.Month;
                int dias = hoje.Day - tempodevida.Day;
                string frase = "O seu signo é";
                switch (meses)
                {
                    case 01: frase += " Capricornio";break;
                }
                return frase;
            }
        }
         
    }
}   
