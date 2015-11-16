using UnityEngine;
using System.Collections;

public class AsteroidController : MonoBehaviour
{
    //inicia em y = 7
    //termina em y = -7
    // Use this for initialization
    // x = -3.20 e 3.20
    static float velocidade = 6;
    //public GameObject asteroid;
    // float currentTime;
    static int meta = 0;
    Vector3 posicao;
    // Update is called once per frame
    void start() {
        
    }
    void Update()
    {
        transform.Translate(0,-1.0f* velocidade * Time.deltaTime, 0);
        
       

        if (transform.position.y <= -7)
        {

            Destroy(gameObject);
            if (meta == 1)
                Life.life--;
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            /*posicao.x = Random.Range(-2.75f, 2.75f);
            posicao.y = inicioY;
            transform.position = posicao;*/
            Destroy(gameObject);
            Life.life--;

        }
        if (other.CompareTag("Bullet"))
        {
            /*posicao.x = Random.Range(-2.75f, 2.75f);
            posicao.y = inicioY;
            transform.position = posicao;*/
            Destroy(gameObject);
            Score.score += 10;
            /* metas do jogo
             * 80 velocidade da pedra aumenta +1
             * 160 velocidade aumenta +1
             * 300 pontos velocidade +1
             * 500 pontos e 5 de life
             */
            if (Score.score == 100)
                velocidade = 6.5f;
            if (Score.score == 250)
                velocidade = 7.5f;
            if (Score.score == 400)
            {
                velocidade = 9.0f;
                meta++;
            }
                
            

        }

    }
}
