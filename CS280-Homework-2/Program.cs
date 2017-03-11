using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonStoreLibrary;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string Pokename = "";
            int PokeNationalNO = 0;
            string PokeAbilities = "";
            Pokemon[] pokemon = new Pokemon[3];
            pokemon[0] = new Pokemon();
            Console.WriteLine("請輸入Pokemon名稱：");
            try
            {
                Pokename = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("poke名稱為Null值");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            pokemon[1] = new Pokemon();
            Console.WriteLine("請輸入Pokemon的NationalNO：");
            try
            {
                PokeNationalNO = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("pokeNationalNO不為數值");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            pokemon[2] = new Pokemon();
            Console.WriteLine("請輸入Pokemon的Abilities：");
            try
            {
                PokeAbilities = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("pokeAbilities為Null值");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
        }
    }
}