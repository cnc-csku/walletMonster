using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {FreeRoam, Battle}

public class GameCountroller : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField] BattleSystem battleSystem;
    [SerializeField] Camera worldCamera;

    GameState state;


    // Start is called before the first frame update
    private void Start()
    {
        playerController.onEncountered += StartBattle;    
    }

    void StartBattle()
    {
        state = GameState.Battle;
        battleSystem.gameObject.SetActive(true);
        worldCamera.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        if (state == GameState.FreeRoam)  {
            playerController.HandleUpdate();
        } else if (state == GameState.Battle) {
            // battleSystem.HandleUpdate();
            Debug.Log("start BattleState");
        }
    }
}
