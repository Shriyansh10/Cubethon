using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour {

    public Transform player;
    public Text Score;
    public float sc;
	// Update is called once per frame
	void Update ()
    {
        sc= player.position.z + 49.15f;
        Score.text = sc.ToString("0");
    }
}
