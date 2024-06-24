using UnityEngine;

public class RegularSphere : Sphere
{
    void Start()
    {
        speed = 5.0f;
        SetSize();
    }

    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Move(direction);
    }

    public override void SetSize()
    {
        size = 1.0f;
        transform.localScale = Vector3.one * size;
    }
}
