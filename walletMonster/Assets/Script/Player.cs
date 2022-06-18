using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Monster[] monster = new Monster[6];
    Type fire = new Fire();
    Type grass = new Grass();
    Type water = new Water();

    void Start (){
        
        monster[0] = new Monster(100);
        monster[1] = new Monster(100);
    }

    void Update(){
        if (Input.GetButtonDown("Debug Next")){
            monster[0].skillUse(1, monster[1]);
        }
    }
    
}
