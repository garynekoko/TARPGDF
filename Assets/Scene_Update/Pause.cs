using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    
    void Start()
    {
        this.gameObject.GetComponent<ParticleSystem>().Pause();
    }

   
    void Update()
    {
        
    }
}
