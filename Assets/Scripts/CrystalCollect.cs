using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Types;
using Random = UnityEngine.Random;

public class CrystalCollect : MonoBehaviour
{

    public AudioClip[] Crystalcollect;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
            source.clip = Crystalcollect[Random.Range(0, Crystalcollect.Length)];
            source.Play();
        }
    }

}

