using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public float PlayerDamage;
    public float MaxPlayerHP;
    public float CurrentPlayerHP; 
    public float PlayerHealAmount;
    void Start()
    {
        PlayerPrefs.SetFloat("PlayerDamage", 4);
        PlayerPrefs.SetFloat("MaxPlayerHP", 20);
        PlayerPrefs.SetFloat("CurrentPlayerHP", 20);
        PlayerPrefs.SetFloat("PlayerHealAmount", 3);
        PlayerPrefs.SetFloat("Experience",0);
        PlayerPrefs.SetFloat("DefenceModifier",0);
        PlayerPrefs.SetFloat("LifestealModifier",0);
        PlayerPrefs.SetFloat("PoisonModifier",0);
        PlayerPrefs.SetFloat("CrippleModifier",0);
        PlayerPrefs.SetFloat("ExperienceModifier",0);
    }
}
