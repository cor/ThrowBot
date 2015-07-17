using UnityEngine;
using System.Collections;

public class PlaceHitmarker : MonoBehaviour {

	public GameObject hitmarker;


	public bool destroyBulletAfterHitmarker = true;
	private bool placedHitmarker = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		if (!placedHitmarker) {
			if (col.gameObject.name == "Floor") {
				Instantiate(hitmarker, transform.position, Quaternion.identity);
				placedHitmarker = true;
				if (destroyBulletAfterHitmarker) {
					DestroyBullet();
				}
			}
		}
	}

	void DestroyBullet() {
		// Destroy all components except for tail render
		Destroy(GetComponent<MeshRenderer>());
		Destroy(GetComponent<SphereCollider>());
		Destroy(GetComponent<Rigidbody>());

		// When the tail is gone, destroy the gameObject
		Destroy(gameObject, 7);
	}

}
