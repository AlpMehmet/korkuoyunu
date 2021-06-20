using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevriyeGezenZombiAI : MonoBehaviour

{
    //ikinci bölümdeki zomviinin davranış şekli bu scriptle sağlanıyor
    public float dusman_hiz, dusman_mesafe;
    public bool yurume;
    public bool saldiri; 
    Vector3 poz; //3 boyutlu uzay ortamında konumu veya vektörleri ifade etmek için kullanılır. 
    public GameObject oyuncu; //fpscontroller için
    public GameObject dusman; //zombie için
    public int DurumKontrol;
    public AudioSource ArkaPlanMusic; //arka plan müziği
    //Unity içinden scripte sürükle bırak yaptığımız 4 obje var
    void Update()
    {
        dusman_hiz = 1;
        poz = new Vector3(oyuncu.transform.position.x, transform.transform.position.y, oyuncu.transform.position.z); //oyuncunun pozisyonunu alıyoruz 
        dusman_mesafe = Vector3.Distance(transform.position, oyuncu.transform.position); //oyuncunun düşmana mesafesini alıyoruz
        if (dusman_mesafe < 10 && dusman_mesafe > 5) //düşmanla aramızda ki mesafe 10-5 arasındaysa zombinin yürümesini true yapıyoruz
        {
            yurume = true;
            saldiri = false;
        }
        if (dusman_mesafe < 3) //düşmanla oyuncu arasındaki mesafe 3 ten küçükse saldiriyi true yapıyoruz 
        {
            yurume = false;
            saldiri = true;
        }
        if (dusman_mesafe > 10)  //düşmanla oyuncu arasındaki mesafe 10 dan büyükse zombi bişey yapmıyor
        {
            yurume = false;
            saldiri = false;
        }
        if (yurume) //yürüme true ise burayı yapar
        {
            transform.position = Vector3.MoveTowards(transform.position, oyuncu.transform.position, dusman_hiz * Time.deltaTime); //zombinin pozisyonu oyuncunun olduğu yöne doğru değişmeye başlıyor ve değişme hızınıda ayarlıyoruz
            dusman_hiz = 3;
            transform.LookAt(poz);  //zombi oyuncunun pozisyonuna bakıyor
            GetComponent<Animation>().Play("walk 1");//yürüme animasyonu çalışıyor
        }
        if (saldiri)//saldırı true ise burayı yapar
        {
            transform.LookAt(poz); //zombi oyuncunun pozisyonuna bakıyor
            GetComponent<Animation>().Play("attack 1"); //saldırı animasyonu çalışıyor
   
        }
        if (yurume == false && saldiri == false) //yürümüyor ve saldırmıyorsa burayı yapar
        {
            GetComponent<Animation>().Play("idle 1"); //idle animasyonu çalışıyor.
        }
    }


   
}