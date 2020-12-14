using UnityEngine;
using UnityEngine.UI;

public class aimScript : MonoBehaviour {

	public Image aimImage;
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectsWithTag("Player").Length == 0) {
			aimImage.enabled = false;
		}
	}
}
