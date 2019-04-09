using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickStage : MonoBehaviour
{
    private string[] stages = { "GameScreen", "BonusScreen", "GoodEventScreen", "BadEventScreen" };
    private void OnMouseUp()
    {
        SceneManager.LoadScene(stages[Random.Range(0,stages.Length)]);
    }
}
