using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Type
{
    public string name;
    public int id;
    public double[] typeEffective;
}

public class Normal : Type // normal type id 0
{
    public Normal(){
        this.name = "normal";
        this.id = 0;
        this.typeEffective = new double[4] {1, 1, 1, 1};
    }
}

public class Grass : Type //grass type id 1
{
    public Grass(){
        this.name = "grass";
        this.id = 1;
        this.typeEffective = new double[4] {1, 1, 2, 0.5};
    }
}

public class Water : Type // water type id 2
{
    public Water(){
        this.name = "water";
        this.id = 2;
        this.typeEffective = new double[4] {1, 0.5, 1, 2};
    }
}

public class Fire : Type // fire type id 3
{
    public Fire(){
        this.name = "fire";
        this.id = 3;
        this.typeEffective = new double[4] {1, 2, 0.5, 1};
    }
}
