using UnityEngine;
using UnityEngine.Audio;

public class SoundToggle : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    private float _maxVolume = 0;
    private float _minVolume = -80;

    public void ToggleMusic(bool isDisabled)
    {
        if (isDisabled)
            _audioMixerGroup.audioMixer.SetFloat("MasterVolume", _minVolume);
        else
            _audioMixerGroup.audioMixer.SetFloat("MasterVolume", _maxVolume);
    }
}
