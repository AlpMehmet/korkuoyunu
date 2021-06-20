using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class A_CGecis : MonoBehaviour
{  //Bu script sayesinde birinci bölümden ikinci bölüme geçiliyor.
    public AudioSource DoorBang;
    void OnTriggerEnter()
    {
        DoorBang.Play();
        GetComponent<BoxCollider>().enabled = false;
       
        SceneManager.LoadScene(6);
        Application.Quit();
    }

    
}
