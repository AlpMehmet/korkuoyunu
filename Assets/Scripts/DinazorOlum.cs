using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinazorOlum : MonoBehaviour
{    //mantık devriye gezen zombinin scriptindeki mantıkla aynı

    public int dinazorCani = 20;
    public GameObject dusman;
    public int DurumKontrol;

    void HasarZombi(int HasarMiktar)
    {
        dinazorCani -= HasarMiktar;
    }




    void Update()
    {
        if (dinazorCani <= 0 && DurumKontrol == 0)
        {
            this.GetComponent<DinazorAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            DurumKontrol = 2;
            dusman.GetComponent<Animation>().Play("Die");

        }
    }
}
