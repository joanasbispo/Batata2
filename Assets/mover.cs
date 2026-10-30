using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class mover : MonoBehaviour
{
    public Rigidbody Bolinha;
    public TMP_Text textoVidas;
    public TMP_Text textoMoedas;

public AudioSource audioSource;
    public AudioClip somMoeda;
    public AudioClip somBarreira;


    void Update()
    {
        Bolinha.AddForce(0, 0, 1);

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            Bolinha.AddForce(-4, 0, 0);
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            Bolinha.AddForce(4, 0, 0);
        }
        // Se a bola cair da plataforma, reinicia o jogo
        if (transform.position.y < -5f)
        {
            FindAnyObjectByType<controlador>().reiniciar();
        }
    }

    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("mau"))
        {
            textoVidas.text = (int.Parse(textoVidas.text) - 1).ToString();
            audioSource.PlayOneShot(somBarreira);
        }
        // Se a vida for igual ou menor a 0, reinicia o jogo
            if (int.Parse(textoVidas.text) <= 0)
            {
                FindAnyObjectByType<controlador>().reiniciar();
            }
    }

    private void OnTriggerEnter(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("bom"))
        {
            textoMoedas.text = (int.Parse(textoMoedas.text) + 10).ToString();
            audioSource.PlayOneShot(somMoeda);
            Destroy(colisao.gameObject);
        }
    }
}