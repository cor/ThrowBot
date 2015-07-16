using UnityEngine;
using System.Collections;

public class TurretController : MonoBehaviour {

	public GameObject turretBase;
	public GameObject cannonBase;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");

		rotateTurretBase(horizontalInput);
		rotateTurretCannon(verticalInput);

	}

	void rotateTurretBase(float degrees) {
		turretBase.transform.Rotate(new Vector3(0, degrees, 0));
	}

	void rotateTurretCannon(float degrees) {
		cannonBase.transform.Rotate(new Vector3(0, degrees, 0));
	}
}
