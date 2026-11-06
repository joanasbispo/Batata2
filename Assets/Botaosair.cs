using UnityEngine;

public class sair : MonoBehaviour
{
    public void fechar()
    {
        Debug.Log("O jogo fechou");
        Application.Quit();
    }
}