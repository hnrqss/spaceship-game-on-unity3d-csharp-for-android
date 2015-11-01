using UnityEngine;
using System.Collections;

public class AsteroidController : MonoBehaviour
{
    //inicia em y = 7
    //termina em y = -7
    // Use this for initialization
    // x = -3.20 e 3.20
    float velocidade;
    //public GameObject asteroid;
    // float currentTime;
    float inicioZ;
    float inicioY;
    Vector3 posicao;
    void Start()
    {
        inicioZ = 0;
        inicioY = 7;
        velocidade = -7;
        // currentTime = 1.2f;
        posicao = new Vector3(0, 0, 0);
        posicao.z = inicioZ;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, velocidade * Time.deltaTime, 0);
        if (transform.position.y <= -7)
        {
            Life.life--;
            posicao.x = Random.Range(-2.75f, 2.75f);
            posicao.y = inicioY;
            transform.position = posicao;
            
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") )
        {
            posicao.x = Random.Range(-2.75f, 2.75f);
            posicao.y = inicioY;
            transform.position = posicao;
            Life.life--;
            
        }
        if (other.CompareTag("Bullet"))
        {
            posicao.x = Random.Range(-2.75f, 2.75f);
            posicao.y = inicioY;
            transform.position = posicao;
            Score.score += 10;
        }
    }
    
}
