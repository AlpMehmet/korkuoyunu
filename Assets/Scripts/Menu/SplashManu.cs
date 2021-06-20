using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashManu : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(MenudenAl()); //StartCoroutine ile çalıştırıldı
    }

    // Update is called once per frame
   IEnumerator MenudenAl() //Coroutine IEnumerator tanımlayıcısı ile tanımlanır ve StartCoroutine fonksiyonu ile çalıştırılır.
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(1);   // SceneManager kütüphanesi sayesinde sahneler arası geçebiliriyoruz.  
    }
}
/*Coroutine kullanma sebebimiz: Normal fonksiyonlar çağrıldığında fonksiyon tamamlanmadan diğer işlemlere geçilmez. Bir Coroutine oluşturarak Bağımsız 
bir işlev oluşturabilir. Ayrıca bir timer görevi de görebilir. Örneğin bir objeyi belirli aralıklar ile büyültebiliriz.*/


//Diğer splash menulerde aynı işlemi yapıyor.