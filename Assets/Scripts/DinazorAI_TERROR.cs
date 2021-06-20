using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinazorAI_TERROR : MonoBehaviour
{
    //mantık devriye gezen zombinin scriptindeki mantıkla aynı
    public float dusman_hiz, dusman_mesafe;
    public bool uyu;
    public bool saldiri, saldiri2;
    public bool yurume;
    Vector3 poz;
    public GameObject oyuncu;
    public GameObject dusman;
    public int dinazorCani = 30, kacKezVurdu = 0;
    public int DurumKontrol;
   

    void Update()
    {

        dusman_hiz = 1;
        poz = new Vector3(oyuncu.transform.position.x, transform.transform.position.y, oyuncu.transform.position.z);
        dusman_mesafe = Vector3.Distance(transform.position, oyuncu.transform.position);
        if (dusman_mesafe < 10 && dusman_mesafe > 0)
        {
            uyu = false;
            yurume = true;
            saldiri = false;
            saldiri2 = false;
        }
        if (dusman_mesafe < 5)
        {
            uyu = false;
            saldiri = true;
            saldiri2 = false;
            yurume = false;
        }
        if (dusman_mesafe < 8 && dusman_mesafe > 5)
        {
            uyu = false;
            saldiri = false;
            saldiri2 = true;
            yurume = false;
        }
        if (dusman_mesafe > 15)
        {
            uyu = true;
            yurume = false;
            saldiri = false;
            saldiri2 = false;
        }
        if (yurume)
        {
            transform.position = Vector3.MoveTowards(transform.position, oyuncu.transform.position, dusman_hiz * Time.deltaTime);
            dusman_hiz = 3;
            transform.LookAt(poz);
            GetComponent<Animation>().Play("Walk");
        }
        if (uyu)
        {
            GetComponent<Animation>().Play("Sleep");
        }
        if (saldiri)
        {
            transform.LookAt(poz);
            GetComponent<Animation>().Play("Claw Attack");
     
        }
        if (saldiri2)
        {
            transform.LookAt(poz);
            GetComponent<Animation>().Play("Basic Attack");
     

        }
       
        if (uyu == false && saldiri == false)
        {
            
        }
    }
}
