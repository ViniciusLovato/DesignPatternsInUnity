using UnityEngine;

public class PersistentObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject persistentGameObject;

    private static bool hasSpawned = false;

    private void Awake()
    {
        if (hasSpawned) return;
        
        SpawnPersistentObject();
    }

    private void SpawnPersistentObject()
    {
        GameObject persistentObject = Instantiate(persistentGameObject);
        DontDestroyOnLoad(persistentObject);
        
        hasSpawned = true;
    }
}
