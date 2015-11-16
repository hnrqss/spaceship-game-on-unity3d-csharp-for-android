using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {

	public static int life;
    // Use this for initialization
	void Start () {
        life = 5;
	}
	
	// Update is called once per frame
	void Update () {
        if (life == 0)
        {
            Application.LoadLevel("Sair");
        }
    }
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 180, 20), "Life: " + life);
    }
   

}
