using UnityEngine;
using UnityEngine.UI;

public class gameOverScript : MonoBehaviour {

	public Text gameOverText;
	
	// Update is called once per frame
	void Update () {
		if(GameObject.FindGameObjectsWithTag("Player").Length == 0) {
			gameOverText.text = "GAME OVER";

		} else {
			gameOverText.text = "";
		}
	}
}
