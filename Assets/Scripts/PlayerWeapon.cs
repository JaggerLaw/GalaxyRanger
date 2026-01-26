using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] ParticleSystem[] lasers;
    [SerializeField] RectTransform crosshair;
    bool isFiring = false;

    void Update()
    {
        ProcessFiring();
        MoveCrosshair();
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

    void MoveCrosshair()
    {
        crosshair.position = Input.mousePosition;
        // crosshair.position = Mouse.current.position;

    }
}