using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    [SerializeField]
    [Tooltip("You should specify the sound effect Prefab!!!")]
    GameObject soundEffectPrefab;
    

    [SerializeField] AudioClip attack;
    [SerializeField] AudioClip damage;
    [SerializeField] AudioClip music;

    private AudioSource audio;

    public enum SoundType
    {
        //NONE = -1, // negative numbers are an option for enums
        ATTACK = 0,
        DAMAGE = 1,
        MUSIC = 3
    }
    public static void PlaySound(SoundType s)
    {
        instance.privPlaySound(s);
    }
    private void Awake()
    {
        DontDestroyOnLoad(this); // AudioManager will carry over between levels
        instance = this;
        audio = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update

    private void privPlaySound(SoundType s)
    {
        //audio.Stop();
        //audio.clip = attack;
        //audio.Play();

        AudioClip clip = null;

        switch(s)
        {
            case SoundType.ATTACK: audio.PlayOneShot(attack); break;
            case SoundType.DAMAGE: audio.PlayOneShot(damage); break;
            case SoundType.MUSIC: audio.PlayOneShot(music); break;
        }
        GameObject soundEffectObject = Instantiate(soundEffectPrefab);
        SoundEffect soundEffect = soundEffectObject.GetComponent<SoundEffect>();
        soundEffect.Init(clip);
        soundEffect.Play();
        //soundEffect.SetVolume();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) privPlaySound(SoundType.MUSIC);
        if (Input.GetKeyDown(KeyCode.S)) privPlaySound(SoundType.ATTACK);
    }
}
