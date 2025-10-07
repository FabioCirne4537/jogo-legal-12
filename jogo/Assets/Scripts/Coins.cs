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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.Addpontos(10);
            Destroy(gameObject);
            //Debug.Log("Você pegou a moeda.");
        }
    }


}
