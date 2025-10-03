using UnityEngine;


public class CircleController : MonoBehaviour
{
    public float rotateSpeed = 10f;
    public int rotateDirection = -1;
    public GameObject GameObject;
    public Transform center;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotateDirection *= -1;
            Debug.Log("Left click!");
        }

        transform.RotateAround(center.position, Vector3.forward, rotateSpeed * rotateDirection * Time.deltaTime);

    }
}
