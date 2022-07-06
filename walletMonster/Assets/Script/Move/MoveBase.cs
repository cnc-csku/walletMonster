using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Move
{
    public string name;
    public string detail;
    public int PP;
    public int power;
    public Type type;
    public int priority;

    public virtual void moveUse(Monster attacker, Monster target){
        this.PP -= 1;
    }
}

public class Physical : Move
{
    public override void moveUse(Monster attacker, Monster target){
        this.PP -= 1;
        target.takeDmg(this, attacker, 0);
    }
}

public class Special : Move
{
    public override void moveUse(Monster attacker, Monster target){
        this.PP -= 1;
        target.takeDmg(this, attacker, 1);
    }
}

public class Status : Move
{
    public override void moveUse(Monster attacker, Monster target){
        this.PP -= 1;
    }
}