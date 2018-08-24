using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour {

	[SerializeField]
	float timetoFade, interval; //フェード持続時間, フェード開始時間

	[SerializeField]
	string nextScene;
	
	// Use this for initialization
	void Start () {
		Invoke ("ChangeScene", interval);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChangeScene()
	{
		FadeManager.Instance.LoadScene (nextScene, timetoFade);
	}
}
