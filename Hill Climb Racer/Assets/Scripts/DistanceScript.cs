using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceScript : MonoBehaviour
{
    public Text TimeBox;
    public float timeStart;
    public int m = 0;

    private void Start()
    {
        TimeBox.text = timeStart.ToString("F1") + " Sec";

    }
    void Update()
    {
        timeStart += Time.deltaTime;
        TimeBox.text = timeStart.ToString("F1") + " Sec";
    }
}
