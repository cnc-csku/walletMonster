using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : Special{
    public Fireball(){
        this.name = "Fireball";
        this.name = "Fire! Magic!";
        type = new Fire();
        this.PP = 20;
        this.power = 40;
        this.priority = 0;
    }
}
