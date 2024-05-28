using UnityEngine;

public class GetAudioFromResources : MonoBehaviour
{
    private AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();  
    }
    private void Start()
    {
        audioSource.clip = Resources.Load<AudioClip>("Explosion_001");
        //audioSource.Play();
        audioSource.PlayDelayed(1f);
    }
}
