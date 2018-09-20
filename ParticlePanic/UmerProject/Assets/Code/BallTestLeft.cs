using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTestLeft : MonoBehaviour {
    float moveSpeed = 0.1f;

    void Update()
    {
        transform.Translate(new Vector3(moveSpeed, 0, 0));
    }
}
