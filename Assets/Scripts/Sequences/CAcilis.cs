using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class CAcilis : MonoBehaviour
{
    //ikinci bölümün başlangıcında burası çalışıyor
    public GameObject oyuncu; //fpscontroller
    public GameObject FadeScreenIn2; //siyah ekran
    public GameObject TextBox2; //yazı yazdığımız text
    public AudioSource adim1_2; //ikinci bölümdeki ilk ses dosyası
    //Unity içinden scripte sürükle bırak yaptığımız 4 obje var

    void Start()
    {
        oyuncu.GetComponent<FirstPersonController>().enabled = false;   //konuşma bitene kadar oyuncunun oynamamasını sağlıyoruz yani fpscontolleri false yapıyoruz
        StartCoroutine(ScenePlayer());

    } 
    IEnumerator ScenePlayer ()
    {
        
            yield return new WaitForSeconds(1.5f);
              FadeScreenIn2.SetActive(false);  //siyah ekranı kapattık
        adim1_2.Play(); //ilk ses oynadı
        TextBox2.GetComponent<Text>().text = "Çok Korkuyorum..."; //ses için texti değiştirdik
            yield return new WaitForSeconds(2); // beklettik
        TextBox2.GetComponent<Text>().text = ""; //textin içini boşalttık
        
        oyuncu.GetComponent<FirstPersonController>().enabled = true;  //konuşma bittiği için oyuncunun oynamasını sağlıyoruz yani fpscontolleri true yapıyoruz


    }


}
