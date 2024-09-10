
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Randomize : MonoBehaviour
{
    private System.Random _random = new System.Random();
    public Sprite[] images;
    public Sprite temSprite;
    public GameObject[] animal;
    public int imageLeft;
    public int nextLevel;
    // Start is called before the first frame update
    void Start()
    {
        Shuffle(images);
        for (int n = animal.Length - 1; n >= 0; n--)
        {
            animal[n].GetComponent<Image>().sprite = images[n];
        }

        imageLeft = images.Length;

    }

    // Update is called once per frame    
    void Update()
    {
        if(imageLeft <= 0)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }

    public void Shuffle(Sprite[] imagesArray)
    {
        int p = imagesArray.Length;
        for (int n = p-1; n>0;n--)
        {
            int r = _random.Next(0, n);
            Sprite t = imagesArray[r];
            images[r] = imagesArray[n];
            imagesArray[n] = t;
        }
    }

}
