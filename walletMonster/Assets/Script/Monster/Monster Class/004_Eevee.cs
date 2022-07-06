using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Eevee : Monster
{
    public Eevee(int lvl){
        //Name
        this.id = 4;
        this.name = "Eevee";
        //Type
        this.type = new Normal();
        //Levels
        this.lvl = lvl;
        //Stats
        this.baseHp = 55;
        this.baseAtk = 55;
        this.baseDef = 50;
        this.baseSpAtk = 45;
        this.baseSpDef = 65;
        this.baseSpd = 55;
        //Move
        this.move = new Move[4] {new Tackle(), new Voice(), new Tackle(), new Voice()};

        //Update data to match lvl
        this.lvl = lvl;
        lvlUp();
        maxExpCal();
        this.hpLeft = hp;
    }
}
