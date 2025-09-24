using Cysharp.Threading.Tasks;
using EditorAttributes;
using UnityEngine;
using Zenject;

public class TestSounds : MonoBehaviour
{
    public AudioClip Sound;
    public AudioClip Music;

    [Inject] private AudioService _audioService;

    [Button]
    public void PlaySoundButton()
    {
        PlaySoundAsync().Forget();
    }

    [Button]
    public void PlayMusicButton()
    {
        PlayMusicAsync().Forget();
    }

    public async UniTask PlaySoundAsync()
    {
        _audioService.PlaySound(Sound);
    }

    public async UniTask PlayMusicAsync()
    {
        _audioService.PlayMusic(Music);
    }
}
