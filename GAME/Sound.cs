using System.Collections;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
public class Sound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public static Sound instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SFXPlay(string sfxName, AudioClip clip)
    {
        GameObject go = new GameObject(sfxName + "Sound");
        AudioSource audioSource = go.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();

        Destroy(go, clip.length);
    }
    public void SFZPlay(string sfxName, AudioClip die)
    {
        GameObject go = new GameObject(sfxName + "Sound");
        AudioSource audioSource = go.AddComponent<AudioSource>();
        audioSource.clip = die;
        audioSource.Play();

        Destroy(go, die.length);
    }
    public void SFVPlay(string sfvName, AudioClip finish)
    {
        GameObject go = new GameObject(sfvName + "Sound");
        AudioSource audioSource = go.AddComponent<AudioSource>();
        audioSource.clip = finish;
        audioSource.Play();

        Destroy(go, finish.length);
    }
    public void SFSPlay(string sfsName, AudioClip bg)
    {
        GameObject go = new GameObject(sfsName + "Sound");
        AudioSource audioSource = go.AddComponent<AudioSource>();
        audioSource.clip = bg;
        audioSource.Play();

        Destroy(go, bg.length);
    }
}

