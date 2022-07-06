using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Popplio : Monster
{
    public Popplio(int lvl){
        //Name
        this.id = 3;
        this.name = "Popplio";
        //Type
        this.type = new Water();
        //Levels
        this.lvl = lvl;
        //Stats
        this.baseHp = 50;
        this.baseAtk = 54;
        this.baseDef = 54;
        this.baseSpAtk = 66;
        this.baseSpDef = 56;
        this.baseSpd = 40;
        //Move
        this.move = new Move[4] {new Splash(), new Bubble(), new Tackle(), new Voice()};

        //Update data to match lvl
        this.lvl = lvl;
        lvlUp();
        maxExpCal();
        this.hpLeft = hp;
    }
}
