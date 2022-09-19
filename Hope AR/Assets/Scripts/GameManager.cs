using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Character Canvas")]
    public GameObject[] characterCanvas;

    public void OnClickDisableCanvas()
    {
        foreach (GameObject canvas in characterCanvas)
            canvas.SetActive(false);
    }

    public void OnClickEnableCanvas()
    {
        foreach (GameObject canvas in characterCanvas)
            canvas.SetActive(true);
    }
    
    public void OnClickQuitGame()
    {
        Application.Quit();
    }
}
