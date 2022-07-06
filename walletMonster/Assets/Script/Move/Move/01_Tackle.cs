using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tackle : Physical{
    public Tackle(){
        this.name = "Tackle";
        this.detail = "Charge at your enemy!";
        type = new Normal();
        this.PP = 20;
        this.power = 40;
        this.priority = 0;
    }
}
