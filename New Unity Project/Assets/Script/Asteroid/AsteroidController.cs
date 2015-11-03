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
    int meta;
    
    void Start()
    {
        meta = 0;
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
            
            posicao.x = Random.Range(-2.75f, 2.75f);
            posicao.y = inicioY;
            transform.position = posicao;
            if (meta == 4)
            {
                Life.life--;
            }
            
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
            /* metas do jogo
             * 80 velocidade da pedra aumenta +1
             * 160 velocidade aumenta +1
             * 300 pontos velocidade +1
             * 500 pontos e 5 de life
             */
            if (Score.score == 80)
            {
                velocidade -= 1;
                meta++;
                Debug.Log(velocidade);
            }
            if (Score.score == 160)
            {
                velocidade -= 1.5f;
                meta++;
                Debug.Log(velocidade);
            }
            if (Score.score == 300)
            {
                velocidade -= 2f;
                meta++;
                Debug.Log(velocidade);
            }
            if (Score.score == 500 && Life.life == 5)
            {
                velocidade -= 3;
                meta++;
                Debug.Log(velocidade);
            }
        }
    }
    
}
