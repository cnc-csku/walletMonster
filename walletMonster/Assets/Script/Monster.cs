using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Monster
{
    //Name
    public int id;
    public string name;
    //Type
    public Type type = ;
    //Levels
    public int lvl;
    private int maxLvl = 100;
    public int exp = 0;
    private int baseMaxExp = 100;
    private double maxExpMod = 1.06;
    private int maxExp;
    //Stats
    public int hp;
    public int atk;
    public int spAtk;
    public int def;
    public int spDef;
    public int spd;
    private int baseHp = 10, hpUp = 2;
    private int baseAtk = 15, atkUp = 3;
    private int baseSpAtk = 8, spAtkUp = 1;
    private int baseDef = 5, defUp = 2;
    private int baseSpDef = 5, spDefUp = 1;
    private int baseSpd = 15, spdUp = 3;
    //Condition
    public bool isDead;
    public int hpLeft;
    public int status;
    //Buff debuff
    public float hpMod = 1;
    public float atkMod = 1;
    public float spAtkMod = 1;
    public float defMod = 1;
    public float spDefMod = 1;
    public float spdMod = 1;
    //Skill
    public int[] skill;
    public int[] skillPP;

    private double pow(double a, int b){
        double ans = 1;
        for(int i=0; i<b; i++){
            ans*=a;
        }
        return ans;
    }

    public Monster(int lvl){
        this.lvl = lvl;
        lvlUp();
        maxExpCal();
    }

    public int expGained(int exp){
        this.exp += exp;
        while (this.exp >= maxExp){
            if (lvl >= maxLvl) break;
            this.exp -= maxExp;
            lvl++;
            lvlUp();
            maxExpCal();
        }
        if (lvl >= maxLvl){
            lvl = maxLvl;
            this.exp = maxExp;
            lvlUp();
        }
        return 1;
    }
    
    private int maxExpCal(){
        this.maxExp = Convert.ToInt32(baseMaxExp*pow(maxExpMod, lvl-1));
        return 1;
    }

    private int lvlUp(){
        this.hp = baseHp+(hpUp*(lvl-1));
        this.atk = baseAtk+(atkUp*(lvl-1));
        this.spAtk = baseSpAtk+(spAtkUp*(lvl-1));
        this.def = baseDef+(defUp*(lvl-1));
        this.spDef = baseSpDef+(spDefUp*(lvl-1));
        this.spd = baseSpd+(spdUp*(lvl-1));
        return 1;
    }
}
