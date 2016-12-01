using UnityEngine;
using System.Collections;

public class ItemDestroyer : MonoBehaviour {
	public GameObject unitychan;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (unitychan.GetComponent<Transform> ().position.z - 10 > this.transform.position.z) {
			Destroy (this.gameObject);
		}
	}
}
