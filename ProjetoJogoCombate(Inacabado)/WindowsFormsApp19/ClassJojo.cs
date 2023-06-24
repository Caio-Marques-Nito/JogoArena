using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19
{
    class ClassJojo
    {
        public static int Pocao()
        {
            //ideia: cada monstro ter sua própria % de poções, será enviada uma variavel de tipo dele como 'bool gladiador = true', o programa vai analisar qual é a sorte de poção desse inimigo
            Random popo = new Random();
            int retornar = 0;
            int potion = popo.Next(0,101);

            if (potion < 85)
            {
                retornar++;

                potion = popo.Next(0, 101);

                if (potion < 65)
                {
                    retornar++;

                    potion = popo.Next(0, 101);

                    if (potion < 35)
                    {
                        retornar++;
                    }
                }


            }

            return retornar;
        }


    }
}
