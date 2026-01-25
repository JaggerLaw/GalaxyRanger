using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] ParticleSystem laser;
    bool isFiring = false;

    void Start()
    {

    }

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
        var laserEmissionMod = laser.GetComponent<ParticleSystem>().emission;

        laserEmissionMod.enabled = isFiring;

    }

}