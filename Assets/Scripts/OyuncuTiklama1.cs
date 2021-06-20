using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuTiklama1 : MonoBehaviour
{
    //oyuncu tıkladığında oyuncuyla hedeflediği target arasındaki etkileşimi anlamak için kullandığımız script diğer scriptlerde bunu çağırıp bilgiyi alıyoruz
    public static float DistanceFromTarget;//objenin ibzle olan uzaklığı için değişken
    public float ToTarget; //hedef için değişken


    void Update()
    {
        RaycastHit Hit; //Raycast ile istediğimiz doğrultuda ve uzunlukta görünmez düz bir çizgi cizdiririz ve bu çizgiyle temasta bulunan birşey olursa istediğimiz olayları yaptırabiliriz.
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit)) //çarpışmayı kontrol ediyoruz
        {
            ToTarget = Hit.distance; //ışınımız çarpıştığındaki mesafeyi totarget değişkenine döndürüyoruz
            DistanceFromTarget = ToTarget; 
        }
    }
}

