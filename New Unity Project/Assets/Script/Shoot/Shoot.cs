using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    // y = 7 bala sai da tela
    // Use this for initialization
    float velocidade;
    public GameObject exploson;
    GameObject cloneExplosion;
    void Start () {
        velocidade = 8;
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, velocidade * Time.deltaTime, 0);
        if (transform.position.y >= 7)
        {
            Destroy(gameObject);
        }
    }
    // se ele colidir com o asteroid destroi o objeto tiro na tela
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Asteroid"))
        {
            cloneExplosion = (GameObject)Instantiate(exploson,transform.position,transform.rotation);
            Destroy(gameObject);
            Destroy(cloneExplosion,1);

        }
    }
}
