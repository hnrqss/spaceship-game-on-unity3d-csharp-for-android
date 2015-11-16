using UnityEngine;
using System.Collections;

public class Pausar : MonoBehaviour {

    // Use this for initialization
    public GameObject teladePause;
    bool isPaused;

    // Update is called once per frame
    /*void Update()
    {

    } */
     
    public void pausarJogo()
    {
        //pause = true;
        //Time.timeScale = 0;

        if (Time.timeScale == 0)
        {
            isPaused = !isPaused;
            Time.timeScale = 1;
            teladePause.SetActive(true);

        }
        else
        {
            isPaused = !isPaused;
            Time.timeScale = 0;
            teladePause.SetActive(false);
        }
            
    }
}
