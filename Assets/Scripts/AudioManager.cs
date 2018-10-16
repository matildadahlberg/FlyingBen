using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour {

    public Sound[] sounds;

	// Use this for initialization
	void Awake () {

        foreach (Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            
            s.source.volume = s.volume;
            s.source.loop = s.loop;

            DontDestroyOnLoad(transform.gameObject);

        }
		
	}

    void StopSound()
    {

        foreach (Sound a in sounds)
        {


            a.source = gameObject.AddComponent<AudioSource>();
            a.source.clip = a.clip;

            a.source.volume = a.volume;
            a.source.loop = a.loop;

            a.source.Stop();

            DontDestroyOnLoad(transform.gameObject);


        }


    }
    

    public void Play(string name){

        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound a = Array.Find(sounds, sound => sound.name == name);
        a.source.Stop();

    }
}
