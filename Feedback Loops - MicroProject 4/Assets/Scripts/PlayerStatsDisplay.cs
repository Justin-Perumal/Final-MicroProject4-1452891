using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStatsDisplay : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject MaxHP;
    public GameObject Damage;
    public GameObject HealAmount;
    public GameObject LifestealAmount;
    public GameObject PoisonDamage;
    public GameObject CrippleReduction;

    // Update is called once per frame
    void Update()
    {
        MaxHP.GetComponent<TextMeshProUGUI>().text = "Max HP: " + PlayerPrefs.GetFloat("MaxPlayerHP").ToString();
        Damage.GetComponent<TextMeshProUGUI>().text = "Damage: " + PlayerPrefs.GetFloat("PlayerDamage").ToString();
        HealAmount.GetComponent<TextMeshProUGUI>().text = "Heal Amount: " + PlayerPrefs.GetFloat("PlayerHealAmount").ToString();;
        LifestealAmount.GetComponent<TextMeshProUGUI>().text = "Lifesteal Amount: " + (PlayerPrefs.GetFloat("LifestealModifier")+1).ToString();
        PoisonDamage.GetComponent<TextMeshProUGUI>().text = "Poison Damage: " + (PlayerPrefs.GetFloat("PoisonModifier")+10).ToString() + "% of current HP";
        CrippleReduction.GetComponent<TextMeshProUGUI>().text = "Cripple Damage Reduction: " + (PlayerPrefs.GetFloat("CrippleModifier")+1).ToString(); 
    }
}
