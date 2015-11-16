using UnityEngine;
using System.Collections;

public class LifeBall : MonoBehaviour {

    // Use this for initialization
    float random;
    float velocidade = 8;
    
    void Start () {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(0,-1*velocidade*Time.deltaTime,0);
        if (transform.position.y <= -7)
        {
            Destroy(gameObject);
        }   
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            if (Life.life < 5)
            {
                Life.life++;
                Destroy(gameObject);
            }
        }
    }
}
