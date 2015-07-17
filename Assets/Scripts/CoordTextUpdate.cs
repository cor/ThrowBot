using UnityEngine;
using System.Collections;

public class CoordTextUpdate : MonoBehaviour {

	public TextMesh textMesh;
	[MultilineAttribute] public string prependString;

	// Use this for initialization
	void Start () {
		textMesh.text = prependString + "x:" + transform.position.x + " z:" + transform.position.z;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
