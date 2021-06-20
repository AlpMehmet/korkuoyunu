using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SilahiAl : MonoBehaviour
{ //masadan silahı almak istediğimizde çalışan script
    public float TheDistance; //oyunucun hedefteki objeyi almak için tıkladığında objeyle arasındaki mesafeyi ölçmek için oluşturduğumuz değişken
    public GameObject ActionDisplay; //action keyi için olan obje
    public GameObject ActionText; //text için olan obje
    public GameObject YapaySilah; //masa üzerindeki silah objesi için
    public GameObject Silah; //fpscontoller içindeki silah için
    public GameObject YolGostericiOk; //yolgösteren ok için
    public GameObject ExtraCross; //Kırmızı crosshair için
    public GameObject TheJumpTrigger; 

    void Update()
    {
        TheDistance = OyuncuTiklama1.DistanceFromTarget;  //oyuncu tıkladığında objeyle arasındaki mesafeyi ölçüp oluşturduğunuz değişkene attık
    }

    void OnMouseOver() //mouse objenin üzerindeyse (crosshair objeyi gösteriyorsa)
    {
        if (TheDistance <= 5) //oyuncunun mesafeye olan uzaklığı 5 ten küçükse burası çalışır
        {
            ExtraCross.SetActive(true); //kırmızı crosshairi aktif yaptık
            ActionDisplay.SetActive(true); 
   
        }
        if (Input.GetButtonDown("Action")) //action keyimiz yani e tuşuna basıldıysa burası çalışır
        {
            if (TheDistance <= 5) //oyuncunun mesafeye olan uzaklığı 5 ten küçükse burası çalışır
            {
                this.GetComponent<BoxCollider>().enabled = false; //silahı almak için silaha oluşturduğum triggerın aktifliğini kapıyoruz.
                ActionDisplay.SetActive(false); 
                YapaySilah.SetActive(false); //masa üzerindeki silahın aktifliğini kapadık
                Silah.SetActive(true); //elimizdeki silahı aktif yaptık (yani bu iki satırdan anlaşılacağı gibi aslında silahı elimize almıyoruz silah hep elimizdeydi)
                ExtraCross.SetActive(false); //kırmızı crosshairi kapadık
                YolGostericiOk.SetActive(false); //yolgösterici oku kapadık
                TheJumpTrigger.SetActive(true); 
            }
        }
    }

    void OnMouseExit() //mouse objenin üzerinde değilse
    {
        ExtraCross.SetActive(false); //kırmızı vrosshairi kapadık
        ActionDisplay.SetActive(false); 
    }
}