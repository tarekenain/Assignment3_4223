using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Pause pause;
    public GameObject pinPrefab;

    private AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
            sound.Play();
        }
    }



    void SpawnPin()
    {
        if (Pause.isPaused == false)
        {
            Instantiate(pinPrefab, transform.position, transform.rotation); 
        }
    }

}
