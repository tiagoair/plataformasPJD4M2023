using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void LoadLevel(string levelName)
    {
        GameManager.Instance.LoadScene(levelName);
    }
}
