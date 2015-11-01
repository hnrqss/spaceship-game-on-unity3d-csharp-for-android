using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour
{

    // Use this for initialization
    //limite até onde a nave pode andar x -2.57 esquerda e 2.57 direita
    float velocidade;
    void Start()
    {
        velocidade = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= -2.54f)
        {
            if (Input.GetKey("left"))
            {
                transform.Translate(velocidade * Time.deltaTime * -1.0f, 0, 0);
            }
        }
        if (transform.position.x <= 2.54)
        {
            if (Input.GetKey("right"))
            {
                transform.Translate(velocidade * Time.deltaTime * 1.0f, 0, 0);
            }
        }

    }
}