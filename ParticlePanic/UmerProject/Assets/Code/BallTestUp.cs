using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTestUp : MonoBehaviour {
    float moveSpeed = 0.1f;

    void Update()
    {
        transform.Translate(new Vector3(0, -moveSpeed, 0));
    }
}
