using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCinematics : MonoBehaviour {

    public GameObject parte1;
    public GameObject parte2;
    public GameObject parte3;

	// Use this for initialization
	void Start () {
        StartCoroutine(changeCine());
        StartCoroutine(textFade());
	}

    IEnumerator textFade()
    {
        yield return new WaitForSeconds(7f);
        parte3.active = false;
    }

    IEnumerator changeCine()
    {
        yield return new WaitForSeconds(25f);
        parte1.active = false;
        parte2.active = true;
    }
}
