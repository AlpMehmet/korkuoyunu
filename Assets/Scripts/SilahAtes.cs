using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilahAtes : MonoBehaviour
{
    //silah ateşlediğimizde çalışan script(sol tık ile çalışan script)
    public GameObject TheGun; //silah objemiz
    public GameObject MuzzleFlash; //sialah ortaya çıktığında ateş eketi veren plane objemiz
    public AudioSource GunFire; //silah eteşlendiğinde oynayan ses dosyamoz
    public bool IsFiring = false;
    public float HedefUzakligi;
    public int HasarMiktar = 5;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && GlobalCephane.mermiSayisi >= 1) //mouse sol dık yapıyorsak ve mermi sayımız 1 den fazlaysa
        {
            if (IsFiring == false) //ve o anda ateş etme işlemi yapmıyorsak etmiyorsak (üst üste sol tık yapıldığında sürekli animasynonu keserek ateş etmemesi için)
            {
                GlobalCephane.mermiSayisi -= 1; //her ateş etmedi mermi sayısını 1 azaltıyotruz
                StartCoroutine(SilahAtesleniyor()); //ateş etme olayı başlar
            }
        }

    }

    IEnumerator SilahAtesleniyor()
    {
        RaycastHit Ates; //ışın oluşturduk
        IsFiring = true; //ateş etmeyi açtık
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out Ates)) //kontollünü yaptık
        {
            HedefUzakligi = Ates.distance; //uzaklığını aldık
            Ates.transform.SendMessage("HasarZombi", HasarMiktar, SendMessageOptions.DontRequireReceiver);  //ışınla birlikte hedef objeye ateş edilme bilgisini yolladık bu sayede hedef objenin içeresinde canını azaltabildik
        }
        TheGun.GetComponent<Animation>().Play("PistolGeriTepme");  //ateşten sonra geri yaptığım geri tepme animasyonu oynadı
        MuzzleFlash.SetActive(true); //flash gösterildi
        MuzzleFlash.GetComponent<Animation>().Play("AtesFire"); //ateş etme animasyonu oynadı 
        GunFire.Play(); //ses oynadı
        yield return new WaitForSeconds(0.5f);
        IsFiring = false; //ateş etmeyi kapadık yani burası bitene kadar sol tıklarda tekrar ateş edilmiyor
    } 
}