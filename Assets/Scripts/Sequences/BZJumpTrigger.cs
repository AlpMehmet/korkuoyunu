using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BZJumpTrigger : MonoBehaviour
{//ilk bölümdeki kapıya yaklaştığımızda bu script çalışıyor.
    public AudioSource DoorBang; //kapı açılma sesi için
    public AudioSource DoorJumpMusic; //jump müzik için
    public GameObject TheZombie; //zombie için
    public GameObject TheDoor; //zombinin açtığı kapı için
    public AudioSource ArkaPlanMusic;  // arka plan müzik için
    //Unity içinden scripte sürükle bırak yaptığımız 5 obje var


    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;  //trigger tekrar tekrar tetiklenmesin diye box colliderı false yapıyoruz
        TheDoor.GetComponent<Animation>().Play("KapiAcmaJump"); //jump kapıya oluşturduğum KapiAcmaJump animasyonunu çalıştırdım
        DoorBang.Play(); //kapı açma müziği oynadığı
        TheZombie.SetActive(true); //zombieyi aktif yaptık
        StartCoroutine(PlayJumpMusic()); 
    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f); //beklettik biraz
        ArkaPlanMusic.Stop();  //kapı açma müziğini bitirdik
        DoorJumpMusic.Play(); //jump müziğini onattık
    }



}