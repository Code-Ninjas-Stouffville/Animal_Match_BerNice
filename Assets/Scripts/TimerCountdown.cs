using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimersCountdown : MonoBehaviour
{
    public TMP_Text lapTime;
    public TMP_Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;

    // Update is called once per frame
    void Update()
    {
        /*totalLapTime -= Time.deltaTime;
        totalCountdownTime -= Time.deltaTime;

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();*/

        if (totalCountdownTime > 0 ) 
        {
            totalCountdownTime -= Time.deltaTime; 
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
        }

        if (totalCountdownTime <= 0 ) 
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
        }

        if (totalLapTime < 0) 
        {
            print("Time is up!");
            SceneManager.LoadScene(5);
        }
    }
}
