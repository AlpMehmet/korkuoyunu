using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalCephane : MonoBehaviour
{
   //cephane miktarını yazdırmak için kullandığımız script
    public static int mermiSayisi; 
    public GameObject mermiEkran; // mermi ekran objesi için
    public int sahipOlunanMermi; 
    void Update()
    {
        sahipOlunanMermi = mermiSayisi; 
        mermiEkran.GetComponent<Text>().text = "" + mermiSayisi; //mermiekran içinde oluşturduğum texte mermisayısını yazıyorum
    }
}
