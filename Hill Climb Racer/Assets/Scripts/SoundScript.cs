using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static AudioClip CoinSound, FuelSound;
    static AudioSource audiosrc;
    // Start is called before the first frame update
    void Start()
    {
        CoinSound = Resources.Load<AudioClip>("point");
        FuelSound = Resources.Load<AudioClip>("fuel");
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "point":
                audiosrc.PlayOneShot(CoinSound);
                break;
            case "fuel":
                audiosrc.PlayOneShot(FuelSound);
                break;

        }
    }
}
