using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
public class Match : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public bool canCheck=true;
    public Sprite correctImage;
    public Sprite incorrectImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Card1 != null && Card2 != null && canCheck == true)
        {
            canCheck = false;
            PlayEffect();
            Invoke("MatchAnimals", 0.5f);

        }
    }

    void MatchAnimals()
    {
        if (Card1 != null && Card2 != null)
        {
            Card1.transform.GetChild(0).GetComponent<Image>().enabled = false;
            Card2.transform.GetChild(0).GetComponent<Image>().enabled = false;
            if (Card1.GetComponent<Image>().sprite == Card2.GetComponent<Image>().sprite)
            {
                Card1.GetComponent<Image>().enabled = true;
                Card2.GetComponent<Image>().enabled = true;
                gameObject.GetComponent<Randomize>().imageLeft = gameObject.GetComponent<Randomize>().imageLeft - 2;
                FindObjectOfType<AudioManager>().Play("Correct");
            }
            else
            {
                Card1.GetComponent<Image>().enabled = false;
                Card2.GetComponent<Image>().enabled = false;
                FindObjectOfType<AudioManager>().Play("Error");
            }

            Card1 = null;
            Card2 = null;
        }
        canCheck = true;
    }

    void PlayEffect()
    {
        if (Card1 != null && Card2 != null)
        {
            Card1.transform.GetChild(0).GetComponent<Image>().enabled = true;
            Card2.transform.GetChild(0).GetComponent<Image>().enabled = true;
            if (Card1.GetComponent<Image>().sprite == Card2.GetComponent<Image>().sprite)
            {
                Card1.transform.GetChild(0).GetComponent<Image>().sprite = correctImage;
                Card2.transform.GetChild(0).GetComponent<Image>().sprite = correctImage;
            }
            else
            {
                Card1.transform.GetChild(0).GetComponent<Image>().sprite = incorrectImage;
                Card2.transform.GetChild(0).GetComponent<Image>().sprite = incorrectImage;
            }
        }
     }

}
