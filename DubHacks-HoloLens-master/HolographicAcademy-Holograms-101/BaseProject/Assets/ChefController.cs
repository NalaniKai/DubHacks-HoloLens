using UnityEngine;
using System.Collections;

public class ChefController : MonoBehaviour {
    AudioSource audioSource = null;
    AudioClip baker = null;

	// Use this for initialization
	void Start () {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.spatialize = true;
        audioSource.spatialBlend = 1.0f;
        audioSource.dopplerLevel = 0.0f;
        audioSource.rolloffMode = AudioRolloffMode.Custom;
        foreach (Renderer r in gameObject.transform.GetComponentsInChildren<Renderer>())
        {
            r.enabled = false;
        }
        baker = Resources.Load<AudioClip>("test");
        audioSource.clip = baker;
        audioSource.Play();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
