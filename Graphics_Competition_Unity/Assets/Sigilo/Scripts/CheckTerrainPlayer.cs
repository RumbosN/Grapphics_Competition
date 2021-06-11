using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTerrainPlayer : MonoBehaviour
{
    public ParticleSystem PS_Mud;
    public AudioSource SplashSound;

    protected ParticleSystem.EmissionModule _emission;

    private void Start()
    {
        if (PS_Mud != null) 
        {
            _emission = PS_Mud.emission;

            //Just in case, by default is deactivated
            SplashSound.playOnAwake = false;
            _emission.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Check if player is on Mud
        if (other.CompareTag("Mud"))
        {
            //Sound
            SplashSound.Play();

            //Particles
            _emission.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Check if player is on Mud
        if (other.CompareTag("Mud"))
        {
            //Sound

            //Particles
            _emission.enabled = false;
        }
    }
}
