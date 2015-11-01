using UnityEngine;
using System.Collections;

public class RockRoll : MonoBehaviour {

    float velocidade;
    // Use this for initialization
	void Start () {
        velocidade = 200;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(velocidade*Time.deltaTime,velocidade*Time.deltaTime,velocidade*Time.deltaTime);
	}
}
