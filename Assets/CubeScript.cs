using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

	public Material material;

	// Use this for initialization
	void Start () {
		//GetComponent<Material> ().SetTexture (;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUp() {
		Debug.Log ("OnMouseUp");
		GameObject o = Instantiate (gameObject);
		o.GetComponent<Rigidbody> ().position = new Vector3 (1f, 1f, 1f);
		o.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
	}
}
