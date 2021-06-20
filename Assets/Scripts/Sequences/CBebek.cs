using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
public class CBebek : MonoBehaviour
{ //ikinci bölümdeki sandalye animasyonları ve arka plan müziği için çalışan script
    public GameObject OluSan; //ölü bebekli sandalye objesi
    public GameObject san; //sandalye objesi
    public AudioSource ArkaPlanMusic; // arka plan müzüği için
    //Unity içinden scripte sürükle bırak yaptığımız 3 obje var
    void OnTriggerEnter() 
    {
        ArkaPlanMusic.Stop(); //arka plan müziği trigger içinde kapanıyor
        this.GetComponent<BoxCollider>().enabled = false; //triggerı false yapıyoruz tekrar tekrar tetiklenmesin diye
        OluSan.GetComponent<Animation>().Play("Sandalye1"); // ilk sandalye animasyonu başladı
        san.GetComponent<Animation>().Play("Sandalye2"); //ikinci sandalye animasyonu başladı 
        StartCoroutine(ScenePlayer());
       
    }

    IEnumerator ScenePlayer()
    {
       
        yield return new WaitForSeconds(0.4f);
        ArkaPlanMusic.Play(); //arka plan müziği başlıyor
    } 

}