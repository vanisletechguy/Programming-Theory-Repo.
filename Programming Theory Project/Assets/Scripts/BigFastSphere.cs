using UnityEngine;

public class BigFastSphere : Sphere
{
    void Start()
    {
        speed = 10.0f;
        SetSize();
    }

    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Move(direction);
    }

    public override void SetSize()
    {
        size = 2.0f;
        transform.localScale = Vector3.one * size;
    }
}
