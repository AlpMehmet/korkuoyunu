using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
public class BIlkTetikleme : MonoBehaviour
{
    public GameObject ThePlayer;//fpscontroller
    public GameObject TextBox;//içinde yazıları yazdırdığımız text
    public GameObject TheMarker; //yol gösterici ok için
    public AudioSource adim3;//oyuncunun konuştuğu üçüncü ses
    //Unity içinden scripte sürükle bırak yaptığımız 4 obje var
    void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false; //trigger tekrar tekrar tetiklenmesin diye box colliderı false yapıyoruz
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;   //konuşma bitene kadar oyuncunun oynamamasını sağlıyoruz yani fpscontolleri false yapıyoruz
        StartCoroutine(ScenePlayer()); 
       
    }

    IEnumerator ScenePlayer()
    {
        adim3.Play(); //üçüncü konuşma başladı 
        TextBox.GetComponent<Text>().text = "Galiba masanın üzerinde silah var.";  //üçüncü konuşma için texti değiştirdik
        yield return new WaitForSeconds(1.5f);//üçüncü konuşma bitene kadar yazıyı beklettik 
        TextBox.GetComponent<Text>().text = "";//textin içini boşalttık 
        ThePlayer.GetComponent<FirstPersonController>().enabled = true; //konuşma bittiği için oyuncunun oynamasını sağlıyoruz yani fpscontolleri true yapıyoruz
        TheMarker.SetActive(true); //yol gösterici oku aktif ettik

    }

}