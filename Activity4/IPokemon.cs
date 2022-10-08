using System;
namespace Activity4
{
    public interface IPokemon
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public int AttackStat { get; set; }

		public delegate void OnPokeEvolution();
		public event OnPokeEvolution EvolutionScene;
		public void EvolutionScence();
    }
}

