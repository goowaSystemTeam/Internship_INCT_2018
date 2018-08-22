using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour {

	public float interval;
	public string nextScene;

	// Use this for initialization
	void Start () {
		ChangeScene ();
		//Invoke ("ChangeScene", interval);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChangeScene()
	{
		FadeManager.Instance.LoadScene (nextScene, interval);
		//SceneManager.LoadScene (nextScene);
	}
}
