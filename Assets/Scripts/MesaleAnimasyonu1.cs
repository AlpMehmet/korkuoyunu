using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaleAnimasyonu1 : MonoBehaviour
{ //meşalenin animasyonlarının oynaması için çalışan script
    public int LightMode; //üretilen random sayıyı atmak için
    public GameObject MesaleIsıgı; //meselaışığı objesi

    void Update()
    {
        if (LightMode == 0)
        {
            StartCoroutine(AnimateLight());
        }

    }

    IEnumerator AnimateLight() 
    {
        //her seferinde oluiturduğum 4 animasyondan birisi çalışıyor 
        LightMode = Random.Range(1, 5);
        if (LightMode == 1)
        {
            MesaleIsıgı.GetComponent<Animation>().Play("MesaleAnim1");
        }
        else if (LightMode == 2)
        {
            MesaleIsıgı.GetComponent<Animation>().Play("MesaleAnim2");
        }
        else if (LightMode == 3)
        {
            MesaleIsıgı.GetComponent<Animation>().Play("MesaleAnim3");
        }
        else if (LightMode == 4)
        {
            MesaleIsıgı.GetComponent<Animation>().Play("MesaleAnim3");
        }
        yield return new WaitForSeconds(0.99f);
        LightMode = 0;

    }
}