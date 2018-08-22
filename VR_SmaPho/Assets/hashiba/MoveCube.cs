using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {

    private Vector3 pos;
	public int height;
    public float y_velo;
    
    void Start () {
        pos = transform.position;
	}

	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.position = new Vector3(pos.x, pos.y + Mathf.PingPong(Time.time, height), pos.z);
    }
}
