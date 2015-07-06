using UnityEngine;
using System.Collections;

public class VehicleSpawnScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		transform.position = Random.insideUnitSphere * 5;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
