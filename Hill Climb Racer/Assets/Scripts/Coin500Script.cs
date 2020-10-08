using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin500Script : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreScript.scoreVal += 500;
        SoundScript.PlaySound("point");
        Destroy(gameObject);
    }
}
