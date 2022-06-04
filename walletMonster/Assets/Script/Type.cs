using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Type
{
    void Start(){
        TypeClass[] type = new TypeClass[3];

        type[0].name = "Grass";
        type[0].id = 1;
        type[0].typeOffensive = new double[] {1, 2, 0.5};
        type[0].typeDefensive = new double[] {1, 0.5, 2};

        type[1].name = "Water";
        type[1].id = 2;
        type[1].typeOffensive = new double[] {0.5, 1, 2};
        type[1].typeDefensive = new double[] {2, 1, 0.5};

        type[2].name = "Fire";
        type[2].id = 3;
        type[2].typeOffensive = new double[] {2, 0.5, 1};
        type[2].typeDefensive = new double[] {0.5, 2, 1};
    }
}

[System.Serializable]
public class TypeClass
{
    public int id;
    public string name;

    public double[] typeOffensive;
    public double[] typeDefensive;
}
