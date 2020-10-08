using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin25 : MonoBehaviour
{
    public int newscore = 0;
    public int oldscore;
    public string thescore;
    public Text textscore;
    public CarController carController;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreScript.scoreVal += 25;
        SoundScript.PlaySound("point");
        Destroy(gameObject);
    }
}
