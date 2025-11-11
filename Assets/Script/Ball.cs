using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 CenterPoint = new Vector3(0, 0, 0);
    public float Max = 5f;
    public float Min = 4f;
    private bool isGrowing = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CenterPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.x>= Max)
            isGrowing = false;
        if(transform.localScale.x<= Min)
            isGrowing = true; 

        float direction = isGrowing? 1f: -1f;       
        transform.localScale += new Vector3(1, 1, 1) * direction * 2f * Time.deltaTime;
    }
}
