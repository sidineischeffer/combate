using System;

namespace Combate {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite os dados do primeiro campeão (Nome, Vida, Ataque, Armadura):");
            string nome1 = Console.ReadLine();
            int vida1 = int.Parse(Console.ReadLine());
            int ataque1 = int.Parse(Console.ReadLine());
            int armadura1 = int.Parse(Console.ReadLine());

            Champion champion1 = new Champion(nome1, vida1, ataque1, armadura1);

            Console.WriteLine("Digite os dados do segundo campeão (Nome, Vida, Ataque, Armadura):");
            string nome2 = Console.ReadLine();
            int vida2 = int.Parse(Console.ReadLine());
            int ataque2 = int.Parse(Console.ReadLine());
            int armadura2 = int.Parse(Console.ReadLine());

            Champion champion2 = new Champion(nome2, vida2, ataque2, armadura2);

            Console.Write("Quantos turnos você deseja executar: ");
            int turnos = int.Parse(Console.ReadLine());

            for (int i = 0; i < turnos; i++) {
                Console.WriteLine($"Turno {i + 1}:");
                champion1.takeDamage(champion2.attack);
                champion2.takeDamage(champion1.attack);

                Console.WriteLine(champion1.status());
                Console.WriteLine(champion2.status());

                if (champion1.life == 0 || champion2.life == 0) {
                    Console.WriteLine("FIM DO COMBATE");
                    break;
                }
            }

            if (champion1.life > 0 && champion2.life > 0) {
                Console.WriteLine("FIM DO COMBATE");
            }
        }
    }
}
