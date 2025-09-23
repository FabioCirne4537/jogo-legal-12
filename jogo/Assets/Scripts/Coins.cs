using UnityEngine;

public class Coins : MonoBehaviour
{
    private int points;
    
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
            points = points + 10;
            Debug.Log("Você pegou a moeda.");
        }
    }


}
