using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Curses : MonoBehaviour
{
    public string[] CurseList;
    public GameObject CurseText;
    public GameObject CurseExplanation;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("CurrentPlayerHP", PlayerPrefs.GetFloat("MaxPlayerHP"));

        int RandomCurse = Random.Range(0,CurseList.Length);
        CurseText.GetComponent<TextMeshProUGUI>().text = CurseList[RandomCurse];

        if(RandomCurse == 0)
        {
            CurseExplanation.GetComponent<TextMeshProUGUI>().text = "Your Max HP has been decreased by 10";
            PlayerPrefs.SetFloat("MaxPlayerHP",PlayerPrefs.GetFloat("MaxPlayerHP")-10);
        }

        if(RandomCurse == 1)
        {
            CurseExplanation.GetComponent<TextMeshProUGUI>().text = "Your damage has been reduced by 2";
            PlayerPrefs.SetFloat("PlayerDamage",PlayerPrefs.GetFloat("PlayerDamage")-2);
        }

        if(RandomCurse == 2)
        {
            CurseExplanation.GetComponent<TextMeshProUGUI>().text = "Your defensive capabilities have decreased";
            PlayerPrefs.SetFloat("DefenceModifier",PlayerPrefs.GetFloat("DefenceModifier")-2);
        }

        if(RandomCurse == 3)
        {
            CurseExplanation.GetComponent<TextMeshProUGUI>().text = "Your lifesteal capabilities have decreased by 4";
            PlayerPrefs.SetFloat("LifestealModifier",PlayerPrefs.GetFloat("LifestealModifier")-4);
        }

        if(RandomCurse == 4)
        {
            CurseExplanation.GetComponent<TextMeshProUGUI>().text = "Your cripple capabilities have decreased";
            PlayerPrefs.SetFloat("CrippleModifier",PlayerPrefs.GetFloat("CrippleModifier")-4);
        }

        if(RandomCurse == 5)
        {
            CurseExplanation.GetComponent<TextMeshProUGUI>().text = "Your healing amount has reduced by 4";
            PlayerPrefs.SetFloat("PlayerHealAmount",PlayerPrefs.GetFloat("PlayerHealAmount")-4);
        }

        if(RandomCurse == 6)
        {
            CurseExplanation.GetComponent<TextMeshProUGUI>().text = "Your poison damage of current HP has reduced by 9%";
            PlayerPrefs.SetFloat("PoisonModifier",PlayerPrefs.GetFloat("PoisonModifier")-0.09f);
        }

        if(RandomCurse == 7)
        {
            CurseExplanation.GetComponent<TextMeshProUGUI>().text = "Your experience gain has reduced by 1 XP for each enemy";
            PlayerPrefs.SetFloat("ExperienceModifier",PlayerPrefs.GetFloat("ExperienceModifier")-1);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quitting");
        }
    }
}
