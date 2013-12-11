using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    int secondsToWait;
    GameObject enemy;
	void Start () {
        enemy = Resources.Load("Prefabs/Enemy") as GameObject;
        secondsToWait = 5;
        StartCoroutine("SpawnEnemy");
	}
	

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(secondsToWait);
        GameObject e = Instantiate(enemy) as GameObject;
        e.transform.position = new Vector3(Random.Range(-4.75f, 4.75f), 4, 0);
        StartCoroutine("SpawnEnemy");
    }
}
