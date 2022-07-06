using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf_Cutter : Physical{
    public Leaf_Cutter(){
        this.name = "Leaf Cutter";
        this.detail = "Cuts the enemy with leaves.";
        type = new Grass();
        this.PP = 20;
        this.power = 40;
        this.priority = 0;
    }
}
