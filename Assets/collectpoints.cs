using UnityEngine;

public class collectpoints : MonoBehaviour
{
    public trackpoints pointsystem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter(Collider other)
    {
      

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "throwable")
        {
            Destroy(collision.gameObject);
            pointsystem.IncreasePoints();
            pointsystem.PrintPoints();                                 
        }
    }
}
-