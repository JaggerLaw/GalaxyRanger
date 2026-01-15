using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 3f;

    Vector2 movement;

    void Update()
    {
        ProcessTranslation();
    }
    
    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
    private void ProcessTranslation()
    {
        float xOffSet = movement.x * controlSpeed * Time.deltaTime;
        float yOffSet = movement.y * controlSpeed * Time.deltaTime;

        transform.localPosition = new Vector3(transform.localPosition.x + xOffSet, transform.localPosition.y + yOffSet, 0f);
    }
}
