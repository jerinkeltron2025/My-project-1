using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject TheObject;
    public void Spawnthrowables()
    {
        Instantiate( TheObject, transform);
    }
}
