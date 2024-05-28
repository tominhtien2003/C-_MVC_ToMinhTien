using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float shootSpeed;

    private Vector3 direc;
    private void Update()
    {
        transform.Translate(direc * shootSpeed * Time.deltaTime);
    }

    public void SetDirec(Vector3 direc)
    {
        this.direc = direc;
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject); 
    }
}
