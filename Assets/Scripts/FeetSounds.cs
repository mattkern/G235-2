using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FeetSounds : MonoBehaviour
{

    public AudioClip[] feetWater;
    public AudioClip[] feetDirt;

    private AudioClip _footSound;
    private string _surface = "dirt";
    private AudioSource _source;


    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (_surface == "dirt")
            {
                _footSound = feetDirt[Random.Range(0, feetDirt.Length)];
            }
            if (_surface == "water")
            {
                _footSound = feetWater[Random.Range(0, feetWater.Length)];
            }
            _source.PlayOneShot(_footSound);
        }
    }

}