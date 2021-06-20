using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class AAcilis : MonoBehaviour
{ //ilk sahnede oyun başldığında bu script çalışıyor.
    public GameObject ThePlayer; //fpscontroller
    public GameObject FadeScreenIn; //siyah ekranı sağlayan
    public GameObject TextBox; //içinde yazıları yazdırdığımız text
    public AudioSource adim1; //oyuncunun konuştuğu ilk ses
    public AudioSource adim2;//oyuncunun konuştuğu ikinci ses
    //Unity içinden scripte sürükle bırak yaptığımız 5 obje var

    void Start()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;   //konuşma bitene kadar oyuncunun oynamamasını sağlıyoruz yani fpscontolleri false yapıyoruz
        StartCoroutine(ScenePlayer()); 

    } 
    IEnumerator ScenePlayer ()
    {
        
            yield return new WaitForSeconds(1.5f);
            FadeScreenIn.SetActive(false);
             adim1.Play();//ilk konuşma başladı
            TextBox.GetComponent<Text>().text = "Neredeyim ben?...";    //ilk konuşma için texti değiştirdik
            yield return new WaitForSeconds(2); //ilk konuşma bitene kadar yazıyı beklettik 
            TextBox.GetComponent<Text>().text = ""; //textin içini boşalttık 
            yield return new WaitForSeconds(0.5f); 
            TextBox.GetComponent<Text>().text = "Buradan çıkmam lazım."; //ikinci konuşma için text değişti
            adim2.Play(); //ikinci konuşma başladı
           yield return new WaitForSeconds(1.7f); //konuşma bitene kadar bekledik
           TextBox.GetComponent<Text>().text = "";//textin içini boşalttık 
        ThePlayer.GetComponent<FirstPersonController>().enabled = true; //konuşma bittiği için oyuncunun oynamasını sağlıyoruz yani fpscontolleri true yapıyoruz

        // yield: Coroutine’i bir frame bekletir. Yani kodun devamını bir sonraki frame’deki Update fonksiyonu çalıştıktan sonra işleme sokar.
        //yield WaitForSeconds(2): Belli bir saniye geçtikten sonra kodun çalıştırılmasına devam edilir.

    }


}
