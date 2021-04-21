using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpInformation : MonoBehaviour
{
    public GameObject InfoPanel;

    public void ShowPanel()
    {
        InfoPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        InfoPanel.SetActive(false);
    }
}
