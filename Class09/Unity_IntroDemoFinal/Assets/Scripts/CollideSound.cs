using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSound : MonoBehaviour
{
    public AudioClip clip1;
    private AudioSource source;
    
    
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collide");
            source.PlayOneShot(clip1);
        }
    }
}
