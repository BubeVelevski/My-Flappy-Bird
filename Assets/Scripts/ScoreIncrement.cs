using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncrement : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.UpdateScore();
        }
    }
}
