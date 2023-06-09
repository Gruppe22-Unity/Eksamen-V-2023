using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FyrSkudd : MonoBehaviour
{
    public Rigidbody2D projectile;

    public float moveSpeed = 10.0f;

    // Start er kalt før den første frame updaten
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update er kalt en gang per frame
    void Update()
    {
        projectile.velocity = new Vector2(0, 1) * moveSpeed;
    }
}
