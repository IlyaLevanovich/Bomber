using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.gameObject.GetComponent<EnemyMovement>();
        if (enemy != null)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }
}
