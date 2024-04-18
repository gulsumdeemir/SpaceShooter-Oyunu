using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    //collider sınırından çıkıp çıkmadığının kontrolünü yapıyorum.
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);

    }
  
}
