using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public static int score;
    // Use this for initialization
	void Start () {
        score = 0;
	}

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        GUI.Label(new Rect(10, 25, 80, 20), "Score: " +score);
    }
}
