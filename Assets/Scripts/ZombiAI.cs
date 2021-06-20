using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiAI : MonoBehaviour
{
    public GameObject oyuncu; //fpsconttoller
    public GameObject dusman; // zombi için
    public float dusmanHizi = 0.03f;
    public bool attackTrigger = false;
    public bool isAttacking = false;
    public AudioSource hurtSound1; //zombi oyuncuya saldırdığında çıkan ses
    public AudioSource hurtSound2; //zombi oyuncuya saldırdığında çıkan ses 2 
    public AudioSource hurtSound3;  //zombi oyuncuya saldırdığında çıkan ses 3
    public int hurtGen;
    public GameObject gos; //kırmızı ekran için

    void Update()
    {
        transform.LookAt(oyuncu.transform); //oyuncuya zombi bakıyor
        if (attackTrigger == false) //zombi saldırı yapmıyorken burası yapılır
        {
            dusmanHizi = 0.03f; //zombinin hızını ayarladık
            dusman.GetComponent<Animation>().Play("walk 1"); //zombinin yürüme animasyonu çalıiitı
            transform.position = Vector3.MoveTowards(transform.position, oyuncu.transform.position, dusmanHizi); //zombinin bize doğru haraketi başladı
        }
        if (attackTrigger == true && isAttacking == false) //zombi saldırı yapıyorken burası çalışır
        {
            dusmanHizi = 0; //zombi yürümesi durması için hızını 0 yaptık
            dusman.GetComponent<Animation>().Play("attack 1"); //zombi saldırı animasyonu başladı
            StartCoroutine(InflictDamage());
        }

    }

    void OnTriggerEnter() //oyuncu üzerindeki silindiri algılarsa burası çalışıyor
    {
        attackTrigger = true; //saldırıyı aktf yaptık
    }

    void OnTriggerExit() //oyuncunun üzerindeki silindirin algılanması bırakılırsa burası çalışır
    {
        attackTrigger = false; //saldırının aktifliğini kapadık 
    }


    IEnumerator InflictDamage() //corotune tanımladık
    {
        isAttacking = true; //saldırıyı aktif yapıyoruz
        if (hurtGen == 1) //hurtgen 1 ise burası çalışır
        {
            hurtSound1.Play(); //1. hasar alma sesi oynar
        }
        if (hurtGen == 2) //hurtgen 2 ise burası çalışır
        {
            hurtSound2.Play(); //2. hasar alma sesi oynar
        }
        if (hurtGen == 3) //hurtgen 3 ise burası çalışır
        {
            hurtSound3.Play(); //3. hasar alma sesi oynar
        }
        gos.SetActive(true); //kırmızı ekran açılıyor
        yield return new WaitForSeconds(0.3f);
        gos.SetActive(false); //kırmızı ekran bitiyor
        yield return new WaitForSeconds(1.1f);
        hurtGen = Random.Range(1,4); //hurtgen randoım üretiliyor 
       
        GlobalHealth.currentHealth -= 5; //oyuncunun canı her vuruşta 5 azalıyor
        yield return new WaitForSeconds(0.9f);
        isAttacking = false;  //saldırının aktifliğini kapıyoruz
    }

}