using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroyer : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("h");
        if (collision.CompareTag("Projectile"))
        {
            print("entered");
        Destroy(collision.gameObject);
        }
            
    }
}
