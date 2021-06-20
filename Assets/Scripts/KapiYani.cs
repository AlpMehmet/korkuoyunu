using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KapiYani : MonoBehaviour
{
    public float TheDistance; //kapıya olan uzaklık için bir dğeişken
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheDoor; //kapı objesi için
    public AudioSource CreakSound; //kpaı açma ses için
    public GameObject ExtraCross; //kırmızı cross için

    void Update()
    {
        TheDistance = OyuncuTiklama1.DistanceFromTarget; //kapıyat olan uzaklığı aldık
    }

    void OnMouseOver() //mouse kapı üzerindeyse
    {
        if (TheDistance <= 2) //uzaklığımız ikiden küçükse
        {
            ExtraCross.SetActive(true);  //kızmızı cross aktif oldu
            ActionDisplay.SetActive(true); //action keyi yaıldı
            ActionText.SetActive(true);//bastığımızda olacak olay yazıldı
        }
        if (Input.GetButtonDown("Action")) //action keyine tıklamışsak eğer yani e tuşuna 
        {
            if (TheDistance <= 2) //uzaklığımız 2 den küçükse
            {
                this.GetComponent<BoxCollider>().enabled = false; //kapının içine oluşturduğumuz triggerın aktifliğini kapadık
                ActionDisplay.SetActive(false); //action keyi kapandı
                ActionText.SetActive(false); //olay yazısı kapandı
                TheDoor.GetComponent<Animation>().Play("KapiAcma"); //kapi açma animasyonu oynadı
                CreakSound.Play(); //kapı açma müziği oynadı
            }
        }
    }

    void OnMouseExit() //mouse kapı üzerinde değilse burası olur
    {
        ExtraCross.SetActive(false); 
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}