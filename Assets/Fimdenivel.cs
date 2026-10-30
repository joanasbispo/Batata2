using UnityEngine;

public class Fimdenivel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Nível terminado!");
        }
    }
}
