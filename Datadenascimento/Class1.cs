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
                frase += dias.ToString() + " dias.   ";
                return frase;
            }
        }
        public string envia2
        {
            get
            {
                return "O dia da semana em que você nasceu foi " + data.ToString("dddddd") + ".";
            }
        }
        public string envia3
        {
            get
            {
                DateTime hoje = DateTime.Now;
                int d = data.Month*100 +data.Day;
                string s;
                string frase = "O seu signo é ";
                if (d < 120 | d > 1221) s = "Caprocórnio \n  O amor, vai estar em alta durante todo o ano, se estiver solteiro, existe uma forte possibilidade de encontrar a sua alma gémea, se já for comprometido, então o seu relacionamento irá entrar num ciclo cheio de cumplicidade e amor.";
                else if (d < 219) s = "Aquário \n  A solidão é um sentimento muito pesado, mas os aquarianos convivem com ele com alguma naturalidade, no entanto durante este ano, irão sentir uma grande necessidade de companhia e irão concentrar-se em encontrar o seu par ideal.";
                else if (d < 321) s = "Peixe  \n No que respeita ao amor, os solteiros irão permanecer sozinhos, o que lhes trará a oportunidade para refletir sobre quais as qualidades que são verdadeiramente importantes para alguém tomar conquistar o seu coração.";
                else if (d < 420) s = "Carneiro  \n O amor, vai estar em alta durante todo o ano, se estiver solteiro, existe uma forte possibilidade de encontrar a sua alma gémea, se já for comprometido, então o seu relacionamento irá entrar num ciclo cheio de cumplicidade e amor.";
                else if (d < 521) s = "Touro \n No amor, os nativos solteiros vão ter necessidade de mudar o seu paradigma e olhar primeiro para o interior das pessoas e só depois para os seus atributos fisicos, só assim vão diminuir as probabilidades de serem magoados.";
                else if (d < 621) s = "Gémeos \n Será um ano para os geminianos analisarem os passos que percorreram e as decisões tomadas anteriormente para assim, para conseguirem identificar os motivos que o estão a impedir de alcançar o tão desejado bem-estar.";
                else if (d < 723) s = "Caranguejo \n Se está solteiro, este ano vai sentir uma vontade arrebatadora de viver um grande amor, aproveite que o amor está no ar e quem sabe a pessoa por que tanto esperou esteve sempre ali mesmo ao pé de si à sua espera.";
                else if (d < 823) s = "Leão \n No amor, dedique algum tempo e energia para se conhecer melhor, os seus sonhos, desejos. Aproveite este ano para namorar muito, mas já sabe que as relações serão muito fugazes, tudo não passará de simples atração física.";
                else if (d < 923) s = "Virgem \n O ano de 2019, reserva também no amor grandes mudanças, dê voz ao seu poder de sedução e erotismo e aproveite a embalagem e revolucione também a sua vida amorosa.";
                else if (d < 1022) s = "Balança \n Já no amor, é tempo de aproveitar o que de bom os astros têm para si, viva intensamente cada momento de alegria e romance.";
                else if (d < 1122) s = "Escorpião \n No que respeita ao amor, os solteiros vão necessitar de um período de reflexão sobre o que é verdadeiramente importante num relacionamento, deixando para trás a ideia de que só o amor é suficiente para manter uma relação estável e duradoura.";
                else if (d < 1222) s = "Sagitário \n A vida amorosa dos sagitarianos, vai ser caracterizada pela descoberta da sua sexualidade, dispam-se de preconceitos e aproveitem.";
                else s = "não és humano";
                frase += s + ".";
                return frase ;
            }
        }
         
    }
}   
    