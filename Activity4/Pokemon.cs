using System;

namespace Activity4
{
	public class Pokemon
	{
        public string Name { get; set; }
        public Type Type { get; set; }
        public int AttackStat { get; set; }
		public Pokemon(string name, Type type, int attack_stat)
		{

			this.Name = name;
			this.Type = type;
			this.AttackStat = attack_stat;
		}

		public void EvolutionScence()
		{
			Console.WriteLine($"{this.Name} has evolved!");
		}
	}
}

