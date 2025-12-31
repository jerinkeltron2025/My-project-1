using UnityEngine;

public class collectpoints : MonoBehaviour
{
    public trackpoints pointsystem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "throwable")
        {
            pointsystem.IncreasePoints();
        }

    }
}
