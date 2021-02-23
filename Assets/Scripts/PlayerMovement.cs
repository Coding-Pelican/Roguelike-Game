using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Vector2Int position;

    GameManager manager;

    private void Start() {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
}
