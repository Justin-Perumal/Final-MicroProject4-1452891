using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleTransitions : MonoBehaviour
{
    public void BattleGrunt()
    {
        SceneManager.LoadScene("GruntBattle");
    }

    public void BattleBeserker()
    {
        SceneManager.LoadScene("BeserkerBattle");
    }

    public void BattleBoss()
    {
        SceneManager.LoadScene("BossBattle");
    }

    public void ReturnToForest()
    {
        SceneManager.LoadScene("Forest");
    }

    public void ReturnToBattleMap()
    {
        SceneManager.LoadScene("BattleSelect");
    }
}
