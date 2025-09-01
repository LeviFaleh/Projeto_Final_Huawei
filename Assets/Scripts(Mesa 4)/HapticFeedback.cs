using UnityEngine;

public class HapticFeedback : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip successClip;
    public AudioClip errorClip;

    public void Success()
    {
        audioSource.PlayOneShot(successClip);
        // Aqui você chama a vibração do controle VR
        Handheld.Vibrate(); 
    }

    public void Error()
    {
        audioSource.PlayOneShot(errorClip);
        Handheld.Vibrate();
    }
}
