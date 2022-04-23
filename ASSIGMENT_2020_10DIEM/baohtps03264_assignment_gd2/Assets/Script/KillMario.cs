
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KillMario : MonoBehaviour
{
    [SerializeField]
    private GameObject restartPanel;
    [SerializeField]
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("Main Camera").GetComponent<AudioSource>().Pause();
            GameObject.Find("OngCong").GetComponent<AudioSource>().Play();
            other.gameObject.SetActive(false);
            
            restartPanel.SetActive(true);
        }



    }

    
}