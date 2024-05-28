using UnityEngine;

public class ExcutionOrder : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        Debug.Log("Enable");
    }
    private void Start()
    {
        Debug.Log("Start");
    }
    private void Update()
    {
        Debug.Log("Update");
    }
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
    private void LateUpdate()
    {
        Debug.Log("LastUpdate");
    }
    private void OnGUI()
    {
        Debug.Log("OnGUI");
    }
}
