using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarriorClass : BaseCharacterClass {
    public BaseWarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "Barbarian class";
        Stamina = 14;
        Endurance = 14;
        Strength = 14;
        Intellect = 10;

    }
}
