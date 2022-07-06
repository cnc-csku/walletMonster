using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : Physical{
    public Splash(){
        this.name = "Splash";
        this.detail = "Splash!!!";
        type = new Water();
        this.PP = 20;
        this.power = 40;
        this.priority = 0;
    }
}
