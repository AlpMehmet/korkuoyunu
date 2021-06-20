using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuFonksiyon : MonoBehaviour
{
    // Bu script button olayları için yazılmış olan script. Yani bir butona tıklandığında onun olayında buradaki classlardan biri seçili ve o classın içi çalışıyor.
   public void YeniOyunBt()  //yeni oyun buttonuna tıklandığında bu class çalışıyor, buttonun olayında bu class seçili
    {
        SceneManager.LoadScene(2);  
    }
    public void Cikis() // Çıkış adlı bir buton oluşturmuştum ancak araştırmama rağmen bulduğum kodlar çalışmadı o yüzden buttonu sildim bu classın o yüzden işlevi yok
    { 
        Application.Quit(); //Çalışmıyor
        
    }
}
