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
        
        monster[0] = new Sprigatito(100);
        monster[1] = new Litten(100);
        monster[2] = new Popplio(100);
        monster[3] = new Eevee(100);
    }

    void Update(){
        if (Input.GetButtonDown("Debug Next")){
            monster[0].moveUse(1, monster[1]);
        }
    }
    
}
