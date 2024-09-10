using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    private TimersCountdown timers;
    public void Start()
    {
        gameObject.GetComponent<Button>().interactable = false;
        timers = GameObject.Find("GameManager").GetComponent<TimersCountdown>();
    }
    public void Update()
    {
        if (timers.totalCountdownTime < 0)
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }
    public void ButtonClick()   
   {
        if(GameObject.Find("GameManager").GetComponent<Match>().Card1 == null )
        {
            transform.GetChild(0).gameObject.GetComponent<Image>().enabled=true;
            GameObject.Find("GameManager").GetComponent<Match>().Card1 = transform.GetChild(0).gameObject;
        }
        else if (GameObject.Find("GameManager").GetComponent<Match>().Card2 == null  && GameObject.Find("GameManager").GetComponent<Match>().Card1!= transform.GetChild(0).gameObject)
        {
            transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
            GameObject.Find("GameManager").GetComponent<Match>().Card2 = transform.GetChild(0).gameObject;
        }
        FindObjectOfType<AudioManager>().Play("Click");
    }
}
