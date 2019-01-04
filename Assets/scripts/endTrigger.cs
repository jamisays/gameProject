using UnityEngine;

public class endTrigger : MonoBehaviour {

    public gameManager gamemanager;

	void OnTriggerEnter()
    {
        gamemanager.CompleteLevel();
    }
}
