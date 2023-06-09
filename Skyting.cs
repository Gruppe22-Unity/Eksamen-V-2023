using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyting : MonoBehaviour
{

    public GameObject projectile;

    public Transform projectilespawn;

    public float nextFire = 1.0f;
    public float currentTime = 0.0f;

    // Start blir kalt før første frame update 
    void Start()
    {
        projectilespawn = this.gameObject.transform;

    }

    // Update blir kalt en gang per frame 
    void Update()
    {
        skyting();

    }

    public void skyting()
    {
        currentTime += Time.deltaTime;

        if (Input.GetButton("Fire1") && currentTime > nextFire)
        {
            nextFire += currentTime;

            Instantiate(projectile, projectilespawn.position, Quaternion.identity);

            nextFire -= currentTime;
            currentTime = 0.0f;

        }
    }
}
