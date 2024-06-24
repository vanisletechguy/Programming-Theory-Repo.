using UnityEngine;

public abstract class Sphere : MonoBehaviour
{
    protected float speed;
    protected float size;

    // Encapsulated method for movement
    public void Move(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    // Abstract method to define size
    public abstract void SetSize();
}
