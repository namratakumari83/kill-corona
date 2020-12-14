using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour {

	public Text scoreText;

	// Update is called once per frame
	void Update () {
		int score = (6 - GameObject.FindGameObjectsWithTag("Player").Length) * 50;

		scoreText.text = "Score : " + score.ToString();
	}
}
