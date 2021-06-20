using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinazorAI : MonoBehaviour
{
    //mantık devriye gezen zombinin scriptindeki mantıkla aynı
    public float dusman_hiz, dusman_mesafe;
    public bool yurume;
    public bool saldiri;
    Vector3 poz;
    public GameObject oyuncu;
    public GameObject dusman;
    public int dinazorCani = 30;
    public int DurumKontrol;

    void Update()
    {
        dusman_hiz = 1;
        poz = new Vector3(oyuncu.transform.position.x, transform.transform.position.y, oyuncu.transform.position.z);
        dusman_mesafe = Vector3.Distance(transform.position, oyuncu.transform.position);
        if (dusman_mesafe < 8 && dusman_mesafe > 5)
        {
            yurume = true;
            saldiri = false;
        }
        if (dusman_mesafe < 5)
        {
            yurume = false;
            saldiri = true;
        }
        if (dusman_mesafe > 8)
        {
            yurume = false;
            saldiri = false;
        }
        if (yurume)
        {
            transform.position = Vector3.MoveTowards(transform.position, oyuncu.transform.position, dusman_hiz * Time.deltaTime);
            dusman_hiz = 3;
            transform.LookAt(poz);
            GetComponent<Animation>().Play("Walk");
        }
        if (saldiri)
        {
            transform.LookAt(poz);
            GetComponent<Animation>().Play("Basic Attack");

        }
        if (yurume == false && saldiri == false)
        {
            
        }
    }
}
