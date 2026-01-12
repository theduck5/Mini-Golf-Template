using UnityEngine;

public class Circling : MonoBehaviour
{
    public float xSpeed, ySpeed, zSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xSpeed, ySpeed, zSpeed, Space.Self);
    }
}
