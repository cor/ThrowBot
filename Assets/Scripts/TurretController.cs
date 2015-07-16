using UnityEngine;
using System.Collections;

public class TurretController : MonoBehaviour {

	public GameObject turretBase;
	public GameObject cannonBase;

	public GameObject bullet;

	public GameObject pipeStartPoint;
	public GameObject pipeEndPoint;

	public float cannonRotationLimmit = 60f;
	public float fireSpeed = 10f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");

		RotateTurretBase(horizontalInput);
		RotateTurretCannon(verticalInput);

		if (Input.GetKeyDown("space")) {
			FireBullet();
		}

	}

	void RotateTurretBase(float degrees) {
		turretBase.transform.Rotate(new Vector3(0, degrees, 0));
	}

	void RotateTurretCannon(float degrees) {

		cannonBase.transform.localEulerAngles = new Vector3(Mathf.Clamp((cannonBase.transform.localEulerAngles.x + degrees), 0, 60), 0, 90);

	}

	void FireBullet() {
		// get a new bullet by cloning the prefab
		GameObject bulletClone = (GameObject) Instantiate(bullet, pipeEndPoint.transform.position, transform.rotation);

		// get the angle of the pipe by substracting the start of the pipe by the end
		Vector3 shootVector = pipeEndPoint.transform.position - pipeStartPoint.transform.position;
		bulletClone.GetComponent<Rigidbody>().velocity = shootVector * fireSpeed;
	}
}
