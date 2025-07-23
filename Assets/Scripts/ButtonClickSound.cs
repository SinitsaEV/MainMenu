using UnityEngine;

public class ButtonClickSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void OnClick()
    {
        _audioSource.Play();
    }
}
