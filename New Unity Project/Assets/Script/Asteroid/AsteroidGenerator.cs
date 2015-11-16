using UnityEngine;
using System.Collections;

public class AsteroidGenerator : MonoBehaviour {

    // Use this for initialization
    public Transform asteroid;
    Vector3 position;
    float random;
    float elapsedTime;
    void Start () {
        elapsedTime = 0.90f;
	}
	
	// Update is called once per frame
	void Update () {
        elapsedTime -= Time.deltaTime;
        if (elapsedTime <= 0)
        {
            random = Random.Range(-2.75f, 2.75f);
            position = new Vector3(random,5.71f,0);
            Instantiate(asteroid, position, transform.rotation);
            elapsedTime = 0.9f;
        }
	}
}
