using UnityEngine;
using System.Collections;

public class LifeGenerator : MonoBehaviour {

    // Use this for initialization
    public Transform lifeball;
    float velocidade = 1;
    Vector3 position;
    float elapsedTime = 10.0f;
    float random;
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Life.life <= 2)
        {
            elapsedTime -= Time.deltaTime;

            if (elapsedTime <= 0)
            {
                random = Random.Range(-2.75f, 2.75f);
                position = new Vector3(random, 7, 0);
                Instantiate(lifeball, position, transform.rotation);
                
                elapsedTime = 10;
            }
            
            
           

        }
            
	}
}
