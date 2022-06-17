using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform pinsTransform, ballsTransform;
    public GameObject pinsPrefab, ballsPrefab;

    public void SpawnNewPins()
    {
        Instantiate(pinsPrefab, pinsTransform.position, pinsTransform.rotation);
    }

    public void SpawnNewBalls()
    {
        Instantiate(ballsPrefab, ballsTransform.position, ballsTransform.rotation);
    }
}
