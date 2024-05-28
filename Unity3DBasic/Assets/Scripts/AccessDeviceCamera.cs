using UnityEngine;

public class AccessDeviceCamera : MonoBehaviour
{
    private static WebCamTexture camDevice;
    private void Start()
    {
        if (camDevice == null)
        {
            camDevice = new WebCamTexture();
        }
        GetComponent<Renderer>().material.mainTexture = camDevice;
        if (!camDevice.isPlaying )
        {
            camDevice.Play();
        }
    }
}
