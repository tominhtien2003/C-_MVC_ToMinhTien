using UnityEngine;

public class DetectObjectFromMouse : MonoBehaviour
{
    private void Update()
    {
        DetectObjectByLeftMouse();
    }
    private void DetectObjectByLeftMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
            }
        }      
    }
}
