using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> pins = new List<GameObject>();
    public List<GameObject> bowlingBall = new List<GameObject>();
    private SpawnManager spawnManager;
    
    void Start()
    {
        pins.AddRange(GameObject.FindGameObjectsWithTag("Pins"));
        bowlingBall.AddRange(GameObject.FindGameObjectsWithTag("BowlingBalls"));
        spawnManager = GetComponent<SpawnManager>();
    }

    void Update()
    {
        if(bowlingBall.Count < 4)
        {
            StartCoroutine(DelayPinsRemoval());
        }

        pins.AddRange(GameObject.FindGameObjectsWithTag("Pins"));
        bowlingBall.AddRange(GameObject.FindGameObjectsWithTag("BowlingBalls"));
    }

    private IEnumerator DelayPinsRemoval()
    {
        yield return new WaitForSeconds(2);

        foreach (GameObject go in pins)
        {
            Destroy(go);
            //StartCoroutine(DelaySpawning());
        }
    }

    private void SpawnBallsAndPins()
    {
        spawnManager.SpawnNewPins();
        spawnManager.SpawnNewBalls();

    }

    private IEnumerator DelaySpawning()
    {
        yield return new WaitForSeconds(5);
        SpawnBallsAndPins();
    }
}
