using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    [SerializeField] private Transform bulletHolder;

    [SerializeField] private Player player;

    private void Update()
    {
        Shoot();
    }
    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletObj = Instantiate(bulletPrefab, bulletHolder.position, Quaternion.identity);

            Vector3 direc = (bulletObj.transform.position - player.transform.position).normalized;

            direc.y = 0;

            bulletObj.GetComponent<Bullet>().SetDirec(direc);

            Destroy(bulletObj, 2f);
        }
    }
}
