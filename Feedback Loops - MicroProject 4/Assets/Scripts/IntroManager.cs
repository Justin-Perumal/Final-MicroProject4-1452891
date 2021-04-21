using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    public GameObject GameExplanation;
    public GameObject BlessCursePanel;
    public GameObject ElderText;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(StartGame());
        StartCoroutine(IntroText());
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quitting");
        }
    }

    IEnumerator IntroText()
    {
        yield return new WaitForSeconds(7f);

        ElderText.GetComponent<TextMeshProUGUI>().text = "Well you're in luck, theres a bunch of people around here just itching for a fight!";

        StartCoroutine(FightingText());
    }

    IEnumerator FightingText()
    {
        yield return new WaitForSeconds(7f);

        ElderText.GetComponent<TextMeshProUGUI>().text = "I could explain with some story or whatever, but I'll use this convenient panel of slides instead :)";

        StartCoroutine(Explanation());
    }

    IEnumerator Explanation()
    {
        yield return new WaitForSeconds(7f);

        GameExplanation.SetActive(true);
    }

    public void BlessingsDialogue()
    {
        ElderText.GetComponent<TextMeshProUGUI>().text = "Now you know the basics. There's one more thing before you leave.";

        StartCoroutine(Blessings());
    }

    IEnumerator Blessings()
    {
        yield return new WaitForSeconds(5f);

        ElderText.GetComponent<TextMeshProUGUI>().text = "As you defeat enemies. You acquire experience points. These points can be traded with me to get special blessings.";

        StartCoroutine(TradeBlessings());
    }

    IEnumerator TradeBlessings()
    {
        yield return new WaitForSeconds(7f);

        ElderText.GetComponent<TextMeshProUGUI>().text = "These blessings will permanently strengthen you or improve your abilities!";

        StartCoroutine(Curses());
    }

    IEnumerator Curses()
    {
        yield return new WaitForSeconds(7f);

        ElderText.GetComponent<TextMeshProUGUI>().text = "However, should you fall in battle. I can bring you back, but you will be affected by some curse!";

        StartCoroutine(CurseExplanation());
    }

    IEnumerator CurseExplanation()
    {
        yield return new WaitForSeconds(7f);

        ElderText.GetComponent<TextMeshProUGUI>().text = "These curses will weaken you or cause your attacks to be less effective! Might lose XP too... So try not to die, Ok?";

        StartCoroutine(BlessAndCurse());
    }

    IEnumerator BlessAndCurse()
    {
        yield return new WaitForSeconds(7f);

        ElderText.GetComponent<TextMeshProUGUI>().text = "Oh look some more convenient panels!";

        StartCoroutine(BlessAndCurseExplanation());
    }

    IEnumerator BlessAndCurseExplanation()
    {
        yield return new WaitForSeconds(5f);

        BlessCursePanel.SetActive(true);
    }

    public void EndIntro()
    {
        ElderText.GetComponent<TextMeshProUGUI>().text = "Thats enough from me, if you ever forget, come see me in the forest!";

        StartCoroutine(EndIntroChase());
    }

    IEnumerator EndIntroChase()
    {
        yield return new WaitForSeconds(5f);

        ElderText.GetComponent<TextMeshProUGUI>().text = "Now go on with ya. Go beat some Grunts or something!";

        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("BattleSelect");
    }
}
