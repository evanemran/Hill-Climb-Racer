using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFuel : MonoBehaviour
{
    public CarController carController;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        carController.fuel = 1;
        SoundScript.PlaySound("fuel");
        Destroy(gameObject);
    }
}
