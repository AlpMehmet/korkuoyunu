using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevriyeGezenOlum : MonoBehaviour
{
    //ikinci bölümdeki zombi ölümleri için çalışan script
    public int ZombiCani = 20; //zombi canını ayarladık
    public GameObject Dusman; //zombie objesi için
    public int DurumKontrol;  
    public AudioSource ArkaPlanMusic; //arka plan müziği için
    //Unity içinden scripte sürükle bırak yaptığımız 3 obje var

    void HasarZombi(int HasarMiktar) //zombiye hasar verme kısmı için class oluşturduk //hasarmiktarı global olarak alıyoruz
    {
        ZombiCani -= HasarMiktar; //her vuruşta zombinin canı 5 azaldı
    }




    void Update()
    {
        if (ZombiCani <= 0 && DurumKontrol == 0) //zombinin canı 0 olmuşsa buraya gidiyor
        {
            this.GetComponent<DevriyeGezenZombiAI>().enabled = false; //DevriyeGezenZombiAI scriptinin aktifliğini kapıyoruz
            this.GetComponent<BoxCollider>().enabled = false;  //zombinin boxının(zombiedusman) aktifliğini kapıyoruz
            DurumKontrol = 2;
            Dusman.GetComponent<Animation>().Stop("walk 1"); //yürüme animasyonu duruyor
            Dusman.GetComponent<Animation>().Play("fallingback 1"); //ölme animasyonu çalışıyor
            ArkaPlanMusic.Play(); //arka plan müziği oynuyor
        }
    }
} 