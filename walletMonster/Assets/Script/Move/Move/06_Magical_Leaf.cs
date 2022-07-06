using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magical_Leaf : Special{
    public Magical_Leaf(){
        this.name = "Magical Leaf";
        this.detail = "Strange leaf comming up!";
        type = new Grass();
        this.PP = 20;
        this.power = 40;
        this.priority = 0;
    }
}
