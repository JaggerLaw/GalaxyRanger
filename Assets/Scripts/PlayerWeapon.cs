using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] ParticleSystem[] lasers;
    bool isFiring = false;

    void Update()
    {
        ProcessFiring();
    }

    public void OnFireLaser(InputValue value)
    {
        isFiring = value.isPressed;
    }

    void ProcessFiring()
    {
        foreach (ParticleSystem laser in lasers)
        {
            var laserEmissionMod = laser.GetComponent<ParticleSystem>().emission;
            laserEmissionMod.enabled = isFiring;
        }
    }
}