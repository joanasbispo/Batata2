using UnityEngine;

public class mover : MonoBehaviour
{
    public Rigidbody Bolinha;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bolinha.linearVelocity = new Vector3(0, 0, 10f);
    }
}
