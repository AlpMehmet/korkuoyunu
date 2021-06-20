using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiOlum : MonoBehaviour
{
    //Bİrinci bölümdeki zombi ölümü için 
    public int ZombiCani = 20; //zombi canı ayarlandı
    public GameObject Dusman; //zombie objesi
    public int DurumKontrol;
    public AudioSource JumpMusic; 
    public AudioSource ArkaPlanMusic;


    void HasarZombi(int HasarMiktar)
    {
        ZombiCani -= HasarMiktar; //zombicanını azalttık
    }




    void Update()
    {
        if (ZombiCani <= 0 && DurumKontrol == 0) //eğer zombi canı 0 ise bunu yapar
            
        {
            this.GetComponent<ZombiAI>().enabled = false; //zombiniaı scriptini devre dışı bıraktık
            this.GetComponent<BoxCollider>().enabled = false; //zombinin boxunu false yaptık
            DurumKontrol = 2;
            Dusman.GetComponent<Animation>().Stop("walk 1"); //yürüme animasyonu durdu
            Dusman.GetComponent<Animation>().Play("fallingback 1"); //zombi ölme animasyonu çalıştı

            JumpMusic.Stop();
            ArkaPlanMusic.Play();
        }
    }
} 