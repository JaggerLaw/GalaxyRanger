using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] ParticleSystem.EmissionModule laser;
    bool isFiring = false;

    void Start()
    {
        laser = GetComponent<ParticleSystem>().emission;
    }

    void Update()
    {
        ProcessFiring();
    }

    public void OnFireLaser(InputValue value)
    {
        isFiring = value.isPressed ? true : false;
    }

    void ProcessFiring()
    {
        if (isFiring)
        {
            laser.enabled = true;
            Debug.Log("Fire");
        }
        else
        {
            laser.enabled = false;
        }
    }

}