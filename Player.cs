
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Kontrollerer hvor fort spilleren beveger seg
    public float moveSpeed = 10.0f; //default speed, kan endres etter ønske

    public Rigidbody2D player;

    // Bruk dette for initialisering
    void Start()
    {
        player = this.GetComponent<Rigidbody2D>();
    }

    // Update er kalt en gang per frame
    void FixedUpdate()
    {
        MovePlayer();
    }
    // Denne funksjonen gjør at spilleren kan bevege seg
    public void MovePlayer()
    {
        // Bevegelse
        player.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;

    }
}
