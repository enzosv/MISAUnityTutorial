using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	void FixedUpdate () {
        //if object is no longer in camera
        if (!renderer.isVisible)
        {
            Destroy(gameObject);
        }
	}
}
