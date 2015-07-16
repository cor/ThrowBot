using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform turretCameraPosition;
	public Transform pipeEnd;

	public float moveSpeed = 3;

	private float startTime;
	private float journeyLength;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPos = turretCameraPosition.position;
		Vector3 currentCameraPos = transform.position;


		transform.position = Vector3.Lerp (transform.position, targetPos, moveSpeed);
		transform.LookAt(pipeEnd.position);
	
	}
}
