using System;
namespace Activity4
{
    public class Trainer
    {
        public string Name { get; }
        private readonly List<Pokemon> _pokemonbag;
        private IReadOnlyCollection<Pokemon> PokemonBag => _pokemonbag.AsReadOnly();
        public Trainer( string name )
        {
            Name = name;
            _pokemonbag = new List<Pokemon>();
        }

        public void AddPokemon (Pokemon pokemon)
        {
            _pokemonbag.Add(pokemon);
            Console.WriteLine($"{pokemon.Name} has be added to your bag!");
        }
    }
}

