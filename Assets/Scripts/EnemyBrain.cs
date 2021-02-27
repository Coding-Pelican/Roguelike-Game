using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBrain : MonoBehaviour {
    public int id;
    public Vector2Int position;

    EnemyVisibility visibility;

    public void Initialize(int newID, Vector2Int newPosition) {
        id = newID;
        position = newPosition;

        visibility = GetComponent<EnemyVisibility>();
        visibility.Initialize();
    }
}