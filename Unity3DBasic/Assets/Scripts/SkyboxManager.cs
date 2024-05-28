using UnityEngine;

public class SkyboxManager : MonoBehaviour
{
    private const string CHANGESKYBOX = "ChangeSkybox";

    [SerializeField] private Material[] skyboxs;
    private void OnEnable()
    {
        InvokeRepeating(CHANGESKYBOX, 3f, 3f);

        PlayerPrefs.SetString("Test", "Saved at level 0");
    }
    /// <summary>
    /// Change Skybox follow time
    /// </summary>
    private void ChangeSkybox()
    {
        int indexPosition = Random.Range(0,skyboxs.Length);

        RenderSettings.skybox = skyboxs[indexPosition];
    }
}
