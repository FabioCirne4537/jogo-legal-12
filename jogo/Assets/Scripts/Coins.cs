using UnityEngine;

public class Coins : MonoBehaviour
{
    private int points;
    public GameManager gameManager;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.CompareTag("Player"))
        {
            PlayerAudio som = colisao.GetComponent<PlayerAudio>();
            som.PlaySFX(som.coinSound);
            gameManager.Addpontos(10);
            Destroy(gameObject);
            //Debug.Log("Você pegou a moeda.");
        }
    }


}
