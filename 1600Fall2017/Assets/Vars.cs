using UnityEngine;
public class Vars : MonoBehaviour {
	public float health = 100;
	void OnTriggerEnter()
	{
		health += 20;
	}
}