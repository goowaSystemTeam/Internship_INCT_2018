using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharaControl : MonoBehaviour {

	[SerializeField]
	float vx, vy, vz, rx, ry, rz, sx, sy, sz;

	Vector3 vel = new Vector3();// (vx, vy, vz);
	Vector3 rot = new Vector3();// (rx, ry, rz);
	Vector3 sca = new Vector3();// (sx, sy, sz);


	// Use this for initialization
	void Start () {
		vel.x = vx; vel.y = vy; vel.z = vz;
		rot.x = rx; rot.y = ry; rot.z = rz;
		sca.x = sx; sca.y = sy; sca.z = sz;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += vel * Time.deltaTime;
		this.transform.Rotate (rot*Time.deltaTime);
		this.transform.localScale += sca * Time.deltaTime;
	}
}
