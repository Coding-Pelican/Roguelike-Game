using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    DungeonGenerator dungeonGenerator;
    public PlayerMovement player;

    public bool isPlayerTurn;

    void Start() {
        dungeonGenerator = GetComponent<DungeonGenerator>();

        dungeonGenerator.InitializeDungeon();
        dungeonGenerator.GenerateDungeon();

        FoV.Initialize();

        FirstTurn();
    }

    public void FirstTurn() {
        isPlayerTurn = true;
    }

    public void FinishPlayersTurn() {
        isPlayerTurn = false;

        dungeonGenerator.DrawMap(true);

        EnemyTurn();
    }

    void EnemyTurn() {
        Debug.Log("Enemies' turn!");

        isPlayerTurn = true;
    }
}