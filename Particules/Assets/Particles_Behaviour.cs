using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles_Behaviour : MonoBehaviour
{

    public GameObject FireParticles;
    public GameObject RainParticles;

    public bool Fire = true;
    public bool Rain = false;



	void Start ()
    {
        FireParticles.SetActive(Fire);
        RainParticles.SetActive(Rain);
    }
	


	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(waiter());
        }
        FireParticles.SetActive(Fire);
        RainParticles.SetActive(Rain);
    }

    IEnumerator waiter()
    {
        Rain = !Rain;
        yield return new WaitForSeconds(1);
        Fire = !Fire;
    }
}
