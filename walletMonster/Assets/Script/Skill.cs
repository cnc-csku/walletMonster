using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Skill
{
    public string name;
    public int PP;
    public int power;
    public Type type;

    public virtual void moveUse(Monster attacker, Monster target){
        this.PP -= 1;
    }
}

public class Physical : Skill
{
    public override void moveUse(Monster attacker, Monster target){
        this.PP -= 1;
        target.takePhyDmg(this, attacker);
    }
}

public class Special : Skill
{
    public override void moveUse(Monster attacker, Monster target){
        this.PP -= 1;
    }
}

public class Status : Skill
{
    public override void moveUse(Monster attacker, Monster target){
        this.PP -= 1;
    }
}

public class Protect : Status{
    
}

public class Leaf_Cutter : Physical{
    public Leaf_Cutter(){
        type = new Grass();
        this.PP = 20;
        this.power = 50;
    }
}

public class Leaf_Blade : Physical{
    public Leaf_Blade(){
        type = new Grass();
        this.PP = 10;
        this.power = 80;
    }
}

public class Magical_Leaf : Special{
    public Magical_Leaf(){
        type = new Grass();
        this.PP = 20;
        this.power = 50;
    }
}

public class Solar_Power : Special{
    public Solar_Power(){
        type = new Grass();
        this.PP = 10;
        this.power = 80;
    }
}