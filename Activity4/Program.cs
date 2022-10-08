using Activity4;

Trainer misty = new Trainer("Misty");

Pokemon pikachu = new Pokemon("Pikachu", Activity4.Type.Electric, 12);
Pokemon charmander = new Pokemon("Charmander", Activity4.Type.Fire, 15);
Pokemon mewtwo = new Pokemon("MewTwo", Activity4.Type.Psychic, 122);

misty.AddPokemon(pikachu);
misty.AddPokemon(charmander);
misty.AddPokemon(mewtwo);

charmander.EvolutionScence();
