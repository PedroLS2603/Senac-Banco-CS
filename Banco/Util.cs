using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    static class Util
    {

        public static void printMenu()
        {
            Console.Write("Assistente do banco\n" +
                "Escolha uma opção\n" +
                "1 - Sacar\n" +
                "2 - Depositar\n" +
                "3 - Transferir\n" +
                "0 - Sair");
        }
    }
}
