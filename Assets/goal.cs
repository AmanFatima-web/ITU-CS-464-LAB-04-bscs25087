using UnityEngine;

public class Goal : MonoBehaviour
{
    private Renderer goalRenderer;

    void Start()
    {
        goalRenderer = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            goalRenderer.material.color = Color.green;
            Debug.Log("GAME COMPLETE!");
        }
    }
}