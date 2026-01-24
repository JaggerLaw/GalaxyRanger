using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 25f;
    [SerializeField] float xClampRange = 20f;
    [SerializeField] float yClampRange = 15f;

    [SerializeField] float xRotRange = 20f;
    [SerializeField] float yRotRange = 0f;
    [SerializeField] float zRotRange = 20f;
    [SerializeField] float rotationSpeed = 5f;


    Vector2 movement;

    void Update()
    {
        ProcessTranslation();
        ProcessRotation();
    }
    
    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
    private void ProcessTranslation()
    {
        float xOffSet = movement.x * controlSpeed * Time.deltaTime;
        float rawXPos = transform.localPosition.x + xOffSet;
        float clampedXPos = Mathf.Clamp(rawXPos, -xClampRange, xClampRange);
        
        float yOffSet = movement.y * controlSpeed * Time.deltaTime;
        float rawYPos = transform.localPosition.y + yOffSet;
        float clampedYPos = Mathf.Clamp(rawYPos, -yClampRange, yClampRange);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, 0f);
    }

    void ProcessRotation()
    {
        float pitch = -xRotRange * movement.y;
        float roll = -zRotRange * movement.x;

        Quaternion targetRotation = Quaternion.Euler(pitch, yRotRange, roll);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, rotationSpeed * Time.deltaTime);

        
    }
}
