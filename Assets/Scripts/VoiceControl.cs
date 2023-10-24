using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceControl : MonoBehaviour
{
	[SerializeField] AudioClip astreoidBurst;
	[SerializeField] AudioClip shipBurst;
	[SerializeField] AudioClip fire;
	AudioSource audioSource;
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	public void AstreoidBurst()
	{
		audioSource.PlayOneShot(astreoidBurst);
	}
	public void ShipBurst()
	{
		audioSource.PlayOneShot(shipBurst);
	}
	public void Fire()
	{
		audioSource.PlayOneShot(fire,0.4f);
	}
}
