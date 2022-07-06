using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Litten : Monster
{
    public Litten(int lvl){
        //Name
        this.id = 2;
        this.name = "Litten";
        //Type
        this.type = new Fire();
        //Levels
        this.lvl = lvl;
        //Stats
        this.baseHp = 45;
        this.baseAtk = 65;
        this.baseDef = 40;
        this.baseSpAtk = 60;
        this.baseSpDef = 40;
        this.baseSpd = 70;
        //Move
        this.move = new Move[4] {new Ember(), new Fireball(), new Tackle(), new Voice()};

        //Update data to match lvl
        this.lvl = lvl;
        lvlUp();
        maxExpCal();
        this.hpLeft = hp;
    }
}
