using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;
    [SerializeField] private string _parameterName;

    public void ChangeVolume(float volume)
    {
        _audioMixerGroup.audioMixer.SetFloat(_parameterName, Mathf.Log10(volume) * 20);
    }
}
