using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BowlingBalls"))
        {
            Destroy(other.gameObject);
            gameManager.bowlingBall.Remove(other.gameObject);
        }
    }
}
