using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pontos = 0;
    public int vidas = 5;


    public void Addpontos(int qtd)     //Pontos
    {
        pontos += qtd;

        if (pontos <= 0)
        {
            pontos = 0;
        }

        Debug.Log("Pontos: " + pontos);
    }

    public void PerderVidas(int vida)
    {
        vidas -= vida;
        Debug.Log("Vidas: " + vidas);
        GameObject player = GameObject.FindWithTag("Player");
        player.GetComponent<Player>().ReiniciarPosicao();

        if (vidas <= 0)
        {
            Time.timeScale = 0;
            Debug.Log("Game Over.");
        }
    }
}
