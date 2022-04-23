using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Treasure : MonoBehaviour
{
    public int Levelload = 4;
    public gamemaster gm;

    // Start is called before the first frame update
     void Start () {
        gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<gamemaster>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (gm.key != 0){
                 SceneManager.LoadScene(Levelload);
        
            }else
            {
                gm.Inputtext.text = ("You need key to open");
            }
        }
    }
 
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.Inputtext.text = ("");
        }
    }
 
}