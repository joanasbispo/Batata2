using UnityEngine;

public class  Seguir : MonoBehaviour
{
   public Transform jogador;
   public Vector3 distancia;
    // Update is called once per frame
    void Update()
    {
     transform.position = jogador.position + distancia;   
    }
}
        
    
