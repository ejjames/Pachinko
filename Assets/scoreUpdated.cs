using UnityEngine;
using UnityEngine.UI;


public class scoreUpdated : MonoBehaviour
{
	public Text scoreText;
	public static int scoreCount; 
	 void Start ()
    {
		scoreCount = 0;
    }
	void Update () {
		scoreText.text = scoreCount.ToString();
	}
	
}