using UnityEngine;
using UnityEngine.EventSystems;

public class CountUp : MonoBehaviour
{
    private int count = 0;

    private void CountClick()
    {
        if (Input.GetMouseButtonDown(0) && EventSystem.current.IsPointerOverGameObject())
        {
            count += 10;
            Debug.Log(count);
        }
    }

    private void Update()
    {
        CountClick();
    }
}
