using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MonsterBase
{
    //Name
    public int id;
    public string name;
    //Type
    public Type type;
    //Levels
    public int lvl;
    protected int maxLvl = 100;
    public int exp = 0;
    protected int baseMaxExp = 100;
    protected double maxExpMod = 1.06;
    protected int maxExp;
    //Stats
    public int hp;
    public int atk;
    public int def;
    public int spAtk;
    public int spDef;
    public int spd;
    protected int baseHp;
    protected int baseAtk;
    protected int baseDef;
    protected int baseSpAtk;
    protected int baseSpDef;
    protected int baseSpd;
    //Skill
    public Move[] move;
}
