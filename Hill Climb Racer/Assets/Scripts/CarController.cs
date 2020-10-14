using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float fuel = 1;
    public float tscore = 0;
    public float fuelconsumption = 0.1f;
    public Rigidbody2D frontTire;
    public Rigidbody2D backTire;
    public Rigidbody2D carRigidbody;
    public float carTorque = 10;
    public UnityEngine.UI.Image image;
    public UnityEngine.UI.Text score;
    public FuelBarScript fuelBarScript;
    public float speed = 20;
    public float maxFuel = 1f;
    public float currentFuel;
    private float movement;
    // Start is called before the first frame update
    void Start()
    {
        currentFuel = maxFuel;
        fuelBarScript.setMaxFuel(maxFuel);
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        //image.fillAmount = currentFuel;
        
        
    }
    private void FixedUpdate()
    {
        if (currentFuel > 0)
        {
            backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            carRigidbody.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
            
        }


        currentFuel -= fuelconsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
        fuelBarScript.SetFuel(currentFuel);
    }
}
