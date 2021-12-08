using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class Bomb : MonoBehaviour
{
    [SerializeField] Collider2D _collider;

    private void Start()
    {
        StartCoroutine(Activate());
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<Animator>().SetTrigger("Boom");
        Destroy(other.gameObject);
        Destroy(gameObject, 0.5f);
        if (other.GetComponent<Movement>())
            SceneManager.LoadScene(0);
    }

    private IEnumerator Activate()
    {
        yield return new WaitForSeconds(1);
        _collider.enabled = true;
    }
}
