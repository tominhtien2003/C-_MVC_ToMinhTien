using UnityEngine;

public class SwitchBetweenCamera : MonoBehaviour
{
    public Camera cameraOne;
    public Camera cameraTwo;
    AudioListener cameraOneAudioListener;
    AudioListener cameraTwoAudioListener;
    private void Start()
    {
        cameraOneAudioListener = cameraOne.GetComponent<AudioListener>();
        cameraTwoAudioListener = cameraTwo.GetComponent<AudioListener>();
        CameraPositionChnage(PlayerPrefs.GetInt("CameraPosition"));
    }
    private void Update()
    {
        SwitchCamera();
    }
    public void CameraPositionM()
    {
        CameraChangeCounter();
    }
    private void SwitchCamera()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            CameraChangeCounter();
        }
    }
    private void CameraChangeCounter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++;
        CameraPositionChnage(cameraPositionCounter);
    }
    private void CameraPositionChnage(int camPosition)
    {
        if (camPosition > 1)
        {
            camPosition = 0;
        }
        PlayerPrefs.SetInt("CameraPosition", camPosition);
        if (camPosition == 0)
        {
            cameraOne.gameObject.SetActive(true);
            cameraOneAudioListener.enabled = true;

            cameraTwo.gameObject.SetActive(false);
            cameraTwoAudioListener.enabled = false;
        }
        if (camPosition ==1)
        {
            cameraOne.gameObject.SetActive(false);
            cameraOneAudioListener.enabled = false;

            cameraTwo.gameObject.SetActive(true);
            cameraTwoAudioListener.enabled = true;
        }
    }
}
