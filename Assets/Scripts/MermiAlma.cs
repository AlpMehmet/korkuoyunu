using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiAlma : MonoBehaviour
{ 
    public GameObject mermiEkranKutusu;  
    public GameObject mermi;
    void OnTriggerEnter(Collider other) 
    {
        mermiEkranKutusu.SetActive(true);
        GlobalCephane.mermiSayisi += 30; //globa cephane scriptindeki değişkenimizi arttırdık 
        mermi.SetActive(false);
    }
}
