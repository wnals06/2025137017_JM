using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("게임 시작!");
        // 예: SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        Debug.Log("게임 종료!");
        Application.Quit();
    }
}
