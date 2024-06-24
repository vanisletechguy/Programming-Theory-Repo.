using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject regularSpherePrefab;
    public GameObject bigFastSpherePrefab;

    private Sphere regularSphere;
    private Sphere bigFastSphere;

    public GameObject TitleScreen;

    void Start()
    {
        regularSphere = Instantiate(regularSpherePrefab, new Vector3(-2, 0, 0), Quaternion.identity).GetComponent<RegularSphere>();
        bigFastSphere = Instantiate(bigFastSpherePrefab, new Vector3(2, 0, 0), Quaternion.identity).GetComponent<BigFastSphere>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            regularSphere.Move(Vector3.forward);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            bigFastSphere.Move(Vector3.forward);
        }
    }

    public void hideTitleScreen() {
        TitleScreen.SetActive(false);
    }
}
