using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class son : MonoBehaviour
{
    public AudioSource DoorBang;
    void OnTriggerEnter()
    {
        DoorBang.Play(); //kapı açma sesi oynadı
        GetComponent<BoxCollider>().enabled = false;
       
        SceneManager.LoadScene(5);
    }
    //Bu scriptin olması gereken yer aslında menu klasörünün içi oyunun bitişi olan son ekranına geçiyor
    
}
