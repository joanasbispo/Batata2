using UnityEngine;
using UnityEngine.SceneManagement;

public class Fimdenivel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("jogo2");
        }
    }
}