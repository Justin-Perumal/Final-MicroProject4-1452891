using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlessingChoices : MonoBehaviour
{
    public GameObject[] Blessings;
    public GameObject Choice1, Choice2, Choice3;
    public Transform BlessPos1;
    public Transform BlessPos2;
    public Transform BlessPos3;

    void Start()
    {
        SetChoice1();
        SetChoice2();
        SetChoice3();

    }

    public void SetChoice1()
    {
        int BlessingChoice1 = Random.Range(0,Blessings.Length);
        Choice1 = Instantiate(Blessings[BlessingChoice1],BlessPos1);
        
        if(Choice1.CompareTag("AB"))
        {
            Choice1.GetComponent<Button>().onClick.AddListener(AttackBlessing);
        }
        if(Choice1.CompareTag("DB"))
        {
            Choice1.GetComponent<Button>().onClick.AddListener(DefenceBlessing);
        }
        if(Choice1.CompareTag("CB"))
        {
            Choice1.GetComponent<Button>().onClick.AddListener(CrippleBlessing);
        }
        if(Choice1.CompareTag("HB"))
        {
            Choice1.GetComponent<Button>().onClick.AddListener(HealBlessing);
        }
        if(Choice1.CompareTag("MHPB"))
        {
            Choice1.GetComponent<Button>().onClick.AddListener(MaxHPBlessing);
        }
        if(Choice1.CompareTag("PB"))
        {
            Choice1.GetComponent<Button>().onClick.AddListener(PoisonBlessing);
        }
        if(Choice1.CompareTag("LSB"))
        {
            Choice1.GetComponent<Button>().onClick.AddListener(LifestealBlessing);
        }
    }

    public void SetChoice2()
    {
        int BlessingChoice2 = Random.Range(0,Blessings.Length);
        Choice2 = Instantiate(Blessings[BlessingChoice2],BlessPos2);
        
        if(Choice2.CompareTag("AB"))
        {
            Choice2.GetComponent<Button>().onClick.AddListener(AttackBlessing);
        }
        if(Choice2.CompareTag("DB"))
        {
            Choice2.GetComponent<Button>().onClick.AddListener(DefenceBlessing);
        }
        if(Choice2.CompareTag("CB"))
        {
            Choice2.GetComponent<Button>().onClick.AddListener(CrippleBlessing);
        }
        if(Choice2.CompareTag("HB"))
        {
            Choice2.GetComponent<Button>().onClick.AddListener(HealBlessing);
        }
        if(Choice2.CompareTag("MHPB"))
        {
            Choice2.GetComponent<Button>().onClick.AddListener(MaxHPBlessing);
        }
        if(Choice2.CompareTag("PB"))
        {
            Choice2.GetComponent<Button>().onClick.AddListener(PoisonBlessing);
        }
        if(Choice2.CompareTag("LSB"))
        {
            Choice2.GetComponent<Button>().onClick.AddListener(LifestealBlessing);
        }
    }

    public void SetChoice3()
    {
        int BlessingChoice3 = Random.Range(0,Blessings.Length+1);
        Choice3 = Instantiate(Blessings[BlessingChoice3],BlessPos3);
        
        if(Choice3.CompareTag("AB"))
        {
            Choice3.GetComponent<Button>().onClick.AddListener(AttackBlessing);
        }
        if(Choice3.CompareTag("DB"))
        {
            Choice3.GetComponent<Button>().onClick.AddListener(DefenceBlessing);
        }
        if(Choice3.CompareTag("CB"))
        {
            Choice3.GetComponent<Button>().onClick.AddListener(CrippleBlessing);
        }
        if(Choice3.CompareTag("HB"))
        {
            Choice3.GetComponent<Button>().onClick.AddListener(HealBlessing);
        }
        if(Choice3.CompareTag("MHPB"))
        {
            Choice3.GetComponent<Button>().onClick.AddListener(MaxHPBlessing);
        }
        if(Choice3.CompareTag("PB"))
        {
            Choice3.GetComponent<Button>().onClick.AddListener(PoisonBlessing);
        }
        if(Choice3.CompareTag("LSB"))
        {
            Choice3.GetComponent<Button>().onClick.AddListener(LifestealBlessing);
        }
    }

    public void AttackBlessing()
    {
        if((PlayerPrefs.GetFloat("Experience")-2) >= 0)
        {
            PlayerPrefs.SetFloat("PlayerDamage",PlayerPrefs.GetFloat("PlayerDamage")+1);
            PlayerPrefs.SetFloat("Experience",PlayerPrefs.GetFloat("Experience") -2);
            Debug.Log("AttackBlessed");
        }
    }

    public void MaxHPBlessing()
    {
        if(PlayerPrefs.GetFloat("Experience")-8 >= 0)
        {
            PlayerPrefs.SetFloat("MaxPlayerHP",PlayerPrefs.GetFloat("MaxPlayerHP")+5);
            PlayerPrefs.SetFloat("Experience",PlayerPrefs.GetFloat("Experience") -8);
            Debug.Log("MaxHPBlessed");
        }
    }

    public void HealBlessing()
    {
        if(PlayerPrefs.GetFloat("Experience")-4 >= 0)
        {
            PlayerPrefs.SetFloat("Experience",PlayerPrefs.GetFloat("Experience") -4);
            PlayerPrefs.SetFloat("PlayerHealAmount",PlayerPrefs.GetFloat("PlayerHealAmount")+2);
            Debug.Log("HealBlessed");
        }
        
    }

    public void DefenceBlessing()
    {
        
        if(PlayerPrefs.GetFloat("Experience")-12 >= 0)
        {
            PlayerPrefs.SetFloat("Experience",PlayerPrefs.GetFloat("Experience") -12);
            PlayerPrefs.SetFloat("DefenceModifier",PlayerPrefs.GetFloat("DefenceModifier")+1);
            Debug.Log("DefenceBlessed");
        }
    }

    public void PoisonBlessing()
    {
        
        if(PlayerPrefs.GetFloat("Experience")-20 >= 0)
        {
            PlayerPrefs.SetFloat("Experience",PlayerPrefs.GetFloat("Experience") -20);
            PlayerPrefs.SetFloat("PoisonModifier",PlayerPrefs.GetFloat("PoisonModifier")+0.05f);
            Debug.Log("PoisonBlessed");
        }
    }

    public void LifestealBlessing()
    {
        if(PlayerPrefs.GetFloat("Experience")-16 >= 0)
        {
            PlayerPrefs.SetFloat("Experience",PlayerPrefs.GetFloat("Experience") - 16);
            PlayerPrefs.SetFloat("LifestealModifier",PlayerPrefs.GetFloat("LifestealModifier")+2);
            Debug.Log("LifestealBlessed");
        }
    }

    public void CrippleBlessing()
    {

        if(PlayerPrefs.GetFloat("Experience")-12 >= 0)
        {
            PlayerPrefs.SetFloat("Experience",PlayerPrefs.GetFloat("Experience") - 12);
            PlayerPrefs.SetFloat("CrippleModifier",PlayerPrefs.GetFloat("CrippleModifier")+2);
            Debug.Log("CrippleBlessed");
        }
    }
}


