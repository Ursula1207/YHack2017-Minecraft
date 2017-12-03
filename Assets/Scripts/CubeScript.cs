using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

	public GameObject miningEffect;
	public float health = 100f;
	private bool dead = false;

	// Use this for initialization
	void Start () {
		miningEffect.GetComponent<ParticleSystemRenderer> ().sharedMaterial = gameObject.GetComponent<MeshRenderer> ().material;
	}

	void Awake () {

	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate () {
		if (dead) {
			gameObject.transform.Rotate (new Vector3 (15f, 30f, 45f) * Time.deltaTime);
		}
	}

	void OnMouseUp() {
		GameObject effect = Instantiate (miningEffect);
		effect.transform.position = transform.position;
		Destroy (effect, 2f);
		if (health <= 0f) {
			gameObject.transform.localScale = new Vector3 (0.25f, 0.25f, 0.25f);
			gameObject.transform.GetComponent<Rigidbody> ().velocity =
				new Vector3 (Random.Range(-1f, 1f), Random.Range(0f, 2f), Random.Range(-1f, 1f));
			dead = true;
		} else {
			health -= 25f;
		}

	}

	void OnCollisionEnter (Collision collision) {
		if (dead) {
			gameObject.transform.position += new Vector3 (0f, 0.15f, 0f);
			gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			gameObject.GetComponent<Rigidbody> ().useGravity = false;
		}
	}

	void OnMouseEnter() {
		Camera.main.GetComponent<MovementScript> ().isRotating = false;
	}

	void OnMouseExit() {
		Camera.main.GetComponent<MovementScript> ().isRotating = true;
	}
}
