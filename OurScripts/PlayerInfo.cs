﻿using System.Collections.Generic;
using UnityEngine;
public class PlayerInfo {
    
    public static int selectedSpecies = 0;
    public static int playerCreaturesCount = 6;
    public static int selectedOption = -1;
    // Options:
    // 0: Our creature
    // 1: Other species creature (enemy species)
    public static Persona creaturePersona0, creaturePersona1, creaturePersona2;
    
    public static int selectedCreature = -1;
    public static int selectedMenuCreature = -1;
    public static int selectedMenuEnemy = -1;
    public static int selectedMenuEnemySpecies = -1;
}
