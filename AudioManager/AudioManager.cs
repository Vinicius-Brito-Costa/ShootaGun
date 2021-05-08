using UnityEngine.Audio;
using System;
using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
	public static AudioManager instance;

	public AudioMixerGroup mixerGroup;

	public Sound[] sounds;

	void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.loop = s.loop;

			s.source.outputAudioMixerGroup = mixerGroup;
		}
	}

	public void Play(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}
		if(s.mixerGroup !=null)
		{
			s.source.outputAudioMixerGroup = s.mixerGroup;
		}
		s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
		s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

		s.source.Play();
	}

	public void StopPlaying (string sound)
 	{
  		Sound s = Array.Find(sounds, item => item.name == sound);
  		if (s == null)
  		{
   			Debug.LogWarning("Sound: " + name + " not found!");
   			return;
  		}

  		s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
  		s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

  		s.source.Stop ();
 	}

	public void volumePitch (string sound, float volume, float pitch)
 	{
  		Sound s = Array.Find(sounds, item => item.name == sound);
  		if (s == null)
  		{
   			Debug.LogWarning("Sound: " + name + " not found!");
   			return;
  		}

  		s.source.volume = volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
  		s.source.pitch = pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));
 	}

	public bool audioPlaying (string sound)
 	{
  		Sound s = Array.Find(sounds, item => item.name == sound);
  		if (s == null)
  		{
   			Debug.LogWarning("Sound: " + name + " not found!");
   			return false;
  		}
		return s.source.isPlaying;
 	}
	
	public float volumeCheck(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
  		if (s == null)
  		{
   			Debug.LogWarning("Sound: " + name + " not found!");
   			return 0;
  		}
		return s.source.volume;
	}

	public void playStopFades(string sound, bool fadeInOrOut, float time)
	{
		StartCoroutine(fadeInOut(sound, fadeInOrOut, time));
	}
	IEnumerator fadeInOut(string sound, bool fadeInOrOut, float time)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
  		if (s == null)
  		{
   			Debug.LogWarning("Sound: " + name + " not found!");
  		}
		
		if(fadeInOrOut)
		{
			if(s.mixerGroup !=null)
			{
				s.source.outputAudioMixerGroup = s.mixerGroup;
			}
			s.source.Play();
			s.source.volume = 0;
			while(s.source.volume < s.volume)
			{
				s.source.volume += (s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f))) * Time.deltaTime / time;
				yield return null;
			}
		}
		else
		{
			while(s.source.volume > 0)
			{
				s.source.volume -= (s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f))) * Time.deltaTime / time;
				yield return new WaitForEndOfFrame();
			}
			s.source.Stop();
			s.source.volume = s.volume;
		}
		s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));
		
	}
}
