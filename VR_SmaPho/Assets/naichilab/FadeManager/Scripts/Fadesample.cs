  using UnityEngine; 
  using System.Collections; 
using System.Collections.Generic;
  

  public class Fadesample : MonoBehaviour 
 { 
	public string sceneName;
	public float timetoFade;

	public void Update ()
	{ 
		if(Input.GetKeyDown(KeyCode.Space))
		FadeManager.Instance.LoadScene (sceneName, timetoFade); 
	} 
}
