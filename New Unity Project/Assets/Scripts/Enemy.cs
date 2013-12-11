using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    Transform trans;
    float delta;
    float speed;
	void Start () 
    {
        trans = transform;
        speed = 4;
	}
	
	void FixedUpdate () 
    {
        delta = Time.deltaTime;
        Move();
	}

    void Move()
    {
        trans.Translate(Vector3.down * delta * speed);
        if (trans.position.y < -5)
        {
            SetPosition();
        }
    }

    void SetPosition()
    {
        trans.position = new Vector3(Random.Range(-4.75f, 4.75f), 4, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        SetPosition();
        Destroy(other.gameObject);
        switch (other.tag)
        {
            case "Player":
                Time.timeScale = 0;
                break;
        }
    }

}
