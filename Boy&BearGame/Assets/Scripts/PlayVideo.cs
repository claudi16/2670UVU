using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayVideo : MonoBehaviour {
	public MovieTexture movie;

	void Start(){
		GetComponent<RawImage>().texture = movie;
		movie.Play();
	}

}
