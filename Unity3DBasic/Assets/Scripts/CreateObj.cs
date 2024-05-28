using UnityEngine;

public class CreateObj : MonoBehaviour
{
    GameObject obj;
    float speed = 50f;
    private void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.transform.position = transform.position;
        obj.transform.rotation = transform.rotation;
        obj.transform.localScale = Vector3.one;
        obj.GetComponent<Renderer>().material.color = Color.red;
        
    }
    private void Update()
    {
        obj.transform.Rotate(0, speed * Time.deltaTime, 0f);
    }
}
