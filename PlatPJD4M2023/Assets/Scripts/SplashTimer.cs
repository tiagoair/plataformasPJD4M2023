using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashTimer : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
        GameManager.Instance.LoadScene("MainMenu");
    }
}
