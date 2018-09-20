using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyThis : MonoBehaviour {

	void Awake () {
        Destroy(this.gameObject, 6);
	}
}
