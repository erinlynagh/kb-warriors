using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickStage : MonoBehaviour
{
    private void OnMouseUp()
    {
        SceneManager.LoadScene("GameScreen");
    }
}
