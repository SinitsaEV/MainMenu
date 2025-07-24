using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

[RequireComponent(typeof(Toggle))]
public class SoundToggle : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    private float _maxVolume = 0;
    private float _minVolume = -80;

    private string _masterVolumeParameter = "MasterVolume";

    private Toggle _toggle;

    private void Awake()
    {
        _toggle = GetComponent<Toggle>();
        _toggle.onValueChanged.AddListener(ToggleMusic);
    }

    private void OnDestroy()
    {
        _toggle.onValueChanged.RemoveListener(ToggleMusic);
    }

    public void ToggleMusic(bool isDisabled)
    {
        if (isDisabled)
            _audioMixerGroup.audioMixer.SetFloat(_masterVolumeParameter, _minVolume);
        else
            _audioMixerGroup.audioMixer.SetFloat(_masterVolumeParameter, _maxVolume);
    }
}
