using UnityEngine;

public class LookAtYAxis : MonoBehaviour
{
    [SerializeField] private Transform objCube1;
    private void Update()
    {
        Vector3 targetPos = new Vector3(objCube1.position.x, transform.position.y, objCube1.position.z);
        transform.LookAt(targetPos);
        //transform.LookAt(objCube1, Vector3.up);
    }
}
