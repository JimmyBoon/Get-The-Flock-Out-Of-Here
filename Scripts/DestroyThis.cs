using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThis : MonoBehaviour
{
    [SerializeField] float destroyAfterSeconds = 1f;
    
    void Start()
    {
        Destroy(gameObject,destroyAfterSeconds);
    }


}
