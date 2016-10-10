using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public GameObject Immigrant;
    public float interval = 3.0f;
    private float distanceAleatoire;
    private Vector3 positionSpawn;



	// Use this for initialization
	void Start () {

        InvokeRepeating("SpawnMob", interval, interval);
	}
	

	void SpawnMob () {

        distanceAleatoire = Random.Range(-10, 10);
        positionSpawn = new Vector3(transform.position.x + distanceAleatoire, transform.position.y, transform.position.z);
        Instantiate(Immigrant, positionSpawn, Quaternion.identity);
	}
}
