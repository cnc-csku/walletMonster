using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ember : Physical{
    public Ember(){
        this.name = "Ember";
        this.detail = "A basic fire attack";
        type = new Fire();
        this.PP = 20;
        this.power = 40;
        this.priority = 0;
    }
}
