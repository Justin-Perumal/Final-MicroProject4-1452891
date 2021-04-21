using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{
    public PlayerStatsHandler PSH;

    public Sprite[] CharacterSprites;
    public string UnitName;
    public float Damage;
    public float MaxHP;
    public float CurrentHP; 
    public float HealAmount;

    void Awake()
    {
        if(UnitName == "Player")
        {
            SetStats();
        }
    }

    void Update()
    {
        if(UnitName == "Beserker" && CurrentHP < (MaxHP/3))
        {
            Damage = 5;
        }
    }

    public void SetStats()
    {
        Damage = PlayerPrefs.GetFloat("PlayerDamage");
        MaxHP = PlayerPrefs.GetFloat("MaxPlayerHP");
        CurrentHP = PlayerPrefs.GetFloat("CurrentPlayerHP");
        HealAmount = PlayerPrefs.GetFloat("PlayerHealAmount");
    }
}
