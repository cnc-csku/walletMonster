using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sprigatito : Monster
{
    public Sprigatito(int lvl){
        //Name
        this.id = 1;
        this.name = "Sprigatito";
        //Type
        this.type = new Grass();
        //Levels
        this.lvl = lvl;
        //Stats
        this.baseHp = 45;
        this.baseAtk = 49;
        this.baseDef = 49;
        this.baseSpAtk = 65;
        this.baseSpDef = 65;
        this.baseSpd = 45;
        //Move
        this.move = new Move[4] {new Leaf_Cutter(), new Magical_Leaf(), new Tackle(), new Voice()};

        //Update data to match lvl
        this.lvl = lvl;
        lvlUp();
        maxExpCal();
        this.hpLeft = hp;
    }
}
