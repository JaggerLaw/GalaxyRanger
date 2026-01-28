using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] ParticleSystem[] lasers;
    [SerializeField] RectTransform crosshair;

    [SerializeField] Transform targetPoint;
    [SerializeField] float targetDistance = 100f;
    bool isFiring = false;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        ProcessFiring();
        MoveCrosshair();
        MoveTargetPoint();
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

    void MoveTargetPoint()
    {
        Vector3 targetPointPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetDistance);
        targetPoint.position = Camera.main.ScreenToWorldPoint(targetPointPosition);
    }
}