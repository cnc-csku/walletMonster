using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Monster[] monster = new Monster[6];

    void Start (){
        monster[0] = new Monster(5);
    }

    void Update(){
        if (Input.GetButtonDown("Debug Next")){
            monster[0].expGained(100000);
        }
    }
    
}
