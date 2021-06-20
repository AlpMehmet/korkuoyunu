using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashManu2 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Gecis());
    }
    
   IEnumerator Gecis()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
    }
}
