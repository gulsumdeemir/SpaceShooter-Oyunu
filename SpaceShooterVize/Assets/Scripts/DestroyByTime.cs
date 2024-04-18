using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
    public float lifeTime;
   
    void Start()
    {
        Destroy(gameObject, lifeTime); //patlama efektinin bir süre sonra yok edilmesini sağlamak için
    }

  
}
