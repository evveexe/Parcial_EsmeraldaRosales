using UnityEngine;

public class Target : MonoBehaviour
{
    void OnMouseDown()
    {
        Object.FindAnyObjectByType<GameManager>().Contador();

        Debug.Log("Si pico");

        Destroy(gameObject);
    }
}