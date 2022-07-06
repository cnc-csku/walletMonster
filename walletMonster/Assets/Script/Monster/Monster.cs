using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Monster : MonsterBase
{
    //Condition
    public bool isDead;
    public int hpLeft;
    public int status;

    //Buff DeBuff
    public float hpMod = 1;
    public float atkMod = 1;
    public float defMod = 1;
    public float spAtkMod = 1;
    public float spDefMod = 1;
    public float spdMod = 1;

    //Level up
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

    //Update stats to match lvl
    protected int lvlUp(){
        this.hp    = Convert.ToInt32(Math.Floor(0.01 * (2*baseHp   *lvl)) + lvl +10);
        this.atk   = Convert.ToInt32(Math.Floor(0.01 * (2*baseAtk  *lvl)) + 5);
        this.def   = Convert.ToInt32(Math.Floor(0.01 * (2*baseDef  *lvl)) + 5);
        this.spAtk = Convert.ToInt32(Math.Floor(0.01 * (2*baseSpAtk*lvl)) + 5);
        this.spDef = Convert.ToInt32(Math.Floor(0.01 * (2*baseSpDef*lvl)) + 5);
        this.spd   = Convert.ToInt32(Math.Floor(0.01 * (2*baseSpd  *lvl)) + 5);
        return 1;
    }

    //Calculate max exp
    protected int maxExpCal(){
        this.maxExp = Convert.ToInt32(baseMaxExp*pow(maxExpMod, lvl-1));
        return 1;
    }

    //Move use
    public void moveUse(int id, Monster target){
        move[id].moveUse(this, target);
    }

    //Take damage
    public void takeDmg(Move move, Monster attacker, int category){
        Debug.Log(String.Format("{0}",move.type.name));
        double damage = 0;
        if (category==0){ //0 == Physical
            damage = ((2*attacker.lvl/5)*move.power*attacker.atk/this.def/50)+2;
        }
        else if (category==1){ //1 == Special
            damage = ((2*attacker.lvl/5)*move.power*attacker.spAtk/this.spDef/50)+2;
        }
        
        if (move.type.typeEffective[this.type.id] == 2){
            Debug.Log("Super effective");
            damage *= 2;
        }
        else if (move.type.typeEffective[this.type.id] == 0.5){
            Debug.Log("Not very effective");
            damage *= 0.5;
        }
        else if (move.type.typeEffective[this.type.id] == 1){
            Debug.Log("Normal");
        }
        if (attacker.type.id == move.type.id){
            damage *= 1.5;
        }
        this.hpLeft -= Convert.ToInt32(damage);
    }
    
    //To get pow(a,b)
    private double pow(double a, int b){
        double ans = 1;
        for(int i=0; i<b; i++){
            ans*=a;
        }
        return ans;
    }
}
