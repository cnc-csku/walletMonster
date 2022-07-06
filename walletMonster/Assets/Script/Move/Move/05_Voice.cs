using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voice : Special
{
    public Voice(){
        this.name = "Voice";
        this.detail = "Screem Ahhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh!";
        type = new Normal();
        this.PP = 20;
        this.power = 40;
        this.priority = 0;
    }
}
