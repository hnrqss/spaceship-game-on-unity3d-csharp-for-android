using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour {

    // Use this for initialization
    public Image lifeBar;
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

    }
    public void diminuirLife()
    {
        if (lifeBar.rectTransform.sizeDelta.x > 0)
        {
            lifeBar.rectTransform.sizeDelta -= new Vector2(50, 0);

        }
        else
            Debug.Log("zerou");
        
        
    }



}
