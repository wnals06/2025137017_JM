using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("���� ����!");
        // ��: SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        Debug.Log("���� ����!");
        Application.Quit();
    }
}
