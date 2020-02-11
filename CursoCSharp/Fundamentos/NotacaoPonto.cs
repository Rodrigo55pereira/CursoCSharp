using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            // Navegação segura
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace(" World!", " Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            // ? valida se foi definido
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
