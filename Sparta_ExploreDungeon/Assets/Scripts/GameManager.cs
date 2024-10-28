using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public Vector3 startTramsform;
    PlayerCondition playerCondition;
    private void Start()
    {
        startTramsform = playerPrefab.transform.position;
        playerCondition = playerPrefab.GetComponent<PlayerCondition>();
    }
    private void Update()
    {
        PlayerGoDown(- 100f);
    }
    void PlayerGoDown(float yPosition)
    {
        if (playerPrefab.transform.position.y < yPosition)
        {
            playerPrefab.transform.position = startTramsform;
            playerCondition.Damage(30f);
        }
    }
}
