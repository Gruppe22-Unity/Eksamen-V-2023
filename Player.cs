using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float movementSpeed = 5f;

    // Start er kalt f�r den f�rste frame update
    void Start()
    {
        
    }

    // Update er kalt p� en gang per frame
    void Update()
    {
        // Bruker unity sin input klasse
        float horizontalInput = Input.GetAxis("Horizontal"); 
        float verticalInput = Input.GetAxis("Vertical");

        // Endre spillerens posisjon basert p� input og hastighet
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * movementSpeed * Time.deltaTime;
        transform.position += movement;

    }
}
