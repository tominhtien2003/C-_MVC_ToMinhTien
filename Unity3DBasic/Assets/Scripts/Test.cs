using UnityEngine;

public class Test : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log(PlayerPrefs.GetString("Test"));
    }
}
