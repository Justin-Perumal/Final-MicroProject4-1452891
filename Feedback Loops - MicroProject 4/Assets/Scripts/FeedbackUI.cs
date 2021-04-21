using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FeedbackUI : MonoBehaviour
{
    public GameObject XPText;
    public GameObject HPText;

    // Update is called once per frame
    void Update()
    {
        XPText.GetComponent<TextMeshProUGUI>().text = "Current XP: " + PlayerPrefs.GetFloat("Experience").ToString();
        if(HPText != null)
        {
            HPText.GetComponent<TextMeshProUGUI>().text = "Current HP: " + PlayerPrefs.GetFloat("CurrentPlayerHP").ToString() + "/" + PlayerPrefs.GetFloat("MaxPlayerHP");
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quitting");
        }
    }
}
