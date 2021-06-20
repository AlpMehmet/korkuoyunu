using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinazorOlum_TERROR : MonoBehaviour
{    //mantık devriye gezen zombinin scriptindeki mantıkla aynı

    public int dinazorCani = 30;
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
            this.GetComponent<DinazorAI_TERROR>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            DurumKontrol = 2;
            dusman.GetComponent<Animation>().Play("Die");

        }
    }
}
