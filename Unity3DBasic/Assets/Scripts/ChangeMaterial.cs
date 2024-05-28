using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    [SerializeField] private Material[] materials;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }
    private void Start()
    {
        InvokeRepeating("ChangeMaterialFollowTime", 1f, 3f);
    }
    private void ChangeMaterialFollowTime()
    {
        int index = Random.Range(0, materials.Length);

        _renderer.material = materials[index];
    }
}
