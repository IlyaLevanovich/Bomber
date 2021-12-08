using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _bomb;

    public void Create()
    {
        Instantiate(_bomb, transform.position, Quaternion.identity);
    }
}
