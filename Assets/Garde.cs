using UnityEngine;
using System.Collections;

public class Garde : MonoBehaviour {

    private GameObject mob;
    public GameObject proj;
    public GameObject gun;
    public int power = 500;

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name == "ImmigrantCol")
        {
            mob = col.gameObject.transform.parent.gameObject;
            Fire();

        }

    }


    void Update()
    {
        if (mob != null)
        {
            transform.LookAt(mob.transform.position);
        }
    }


    void Fire()
    {
        GameObject balle = (GameObject)Instantiate(proj, gun.transform.position, Quaternion.identity);
        balle.gameObject.name = "Projectile";
        balle.GetComponent<Rigidbody>().AddForce(transform.forward * power);
    }
	

}
