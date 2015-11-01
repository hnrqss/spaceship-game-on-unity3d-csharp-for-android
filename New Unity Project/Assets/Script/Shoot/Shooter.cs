using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    // Use this for initialization
    public Transform bullet;
    void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("z"))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
	}
}
