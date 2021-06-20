using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GlobalHealth : MonoBehaviour
{
    public static int currentHealth = 20; //oyuncunun gloabal canı
    public int internalHealth;  
     
    void Update()
    {
        internalHealth = currentHealth;
        if (currentHealth<=0) //eğer oyunucnun canı 0 olursa yenildin yazılı sahneye geçiş yapılıyor
        {
            SceneManager.LoadScene(4);  
        }
    }
}


