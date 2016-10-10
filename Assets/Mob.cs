using UnityEngine;
using System.Collections;

public class Mob : MonoBehaviour {

    private NavMeshAgent agent;

	// Use this for initialization
	void Start () {

        agent = GetComponent<NavMeshAgent>();
        NavMeshPath chemin= new NavMeshPath();
        //agent.CalculatePath(GameObject.Find("Barrack").transform.position, chemin);
        agent.destination = GameObject.Find("Barrack").transform.position;
            
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Barrack")
        {
            SimulatorManager.nbPassage++;
            Destroy(this.gameObject);
        }
        else if (col.gameObject.name == "Projectile")
        {
            Destroy(this.gameObject);
            Destroy(col.gameObject);
        }
    }
}
