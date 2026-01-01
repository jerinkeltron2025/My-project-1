using TMPro;
using UnityEngine;

public class trackpoints : MonoBehaviour
{
    private int point = 0;
    public TextMeshProUGUI pointsText;

    public void PrintPoints()
    {
        Debug.Log(point);


        pointsText.text = point.ToString();
    }
    public void ResetPoints()
    {
        point = 0;
        PrintPoints();
    }

    public void IncreasePoints()
    {
        point = point + 1;
    }
}