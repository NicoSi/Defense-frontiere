using UnityEngine;
using System.Collections;

public class SimulatorManager : MonoBehaviour {


    public static int nbPassage = 0;
    public TextMesh textePassage;
    public GameObject particules;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        textePassage.text = nbPassage.ToString();

        if (nbPassage == 10)
        {
            //Instantiate(particules, GameObject.Find("Barrack").transform.position, Quaternion.identity);
            //Destroy(GameObject.Find("Barrack"));
        }

	}
}
