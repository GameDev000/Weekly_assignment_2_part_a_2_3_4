using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 CenterPoint = new Vector3(0, 0, 0);
    public float SpeedRotation = 90f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CenterPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, SpeedRotation* Time.deltaTime); //Time.deltaTime= s between frame
        
    }
}
