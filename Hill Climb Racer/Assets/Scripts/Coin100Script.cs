using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin100Script : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreScript.scoreVal += 100;
        SoundScript.PlaySound("point");
        Destroy(gameObject);
    }
}
