using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;
    [SerializeField] private string _parameterName;

    private float _decibelMultiplier = 20f;
    private float _minLinearVolume = 0.0001f;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDestroy()
    {
        if (_slider != null)
            _slider.onValueChanged.RemoveListener(ChangeVolume);        
    }

    public void ChangeVolume(float volume)
    {
        if (volume == 0)
            volume = _minLinearVolume;

        _audioMixerGroup.audioMixer.SetFloat(_parameterName, Mathf.Log10(volume) * _decibelMultiplier);
    }
}
