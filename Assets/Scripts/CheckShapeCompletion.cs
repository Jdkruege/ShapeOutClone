using UnityEngine;
using System.Collections;

public class CheckShapeCompletion : MonoBehaviour {

    public bool left, right, top, bottom;
    private GameState _state;
    private BoardState _board;

	// Use this for initialization
	void Start () {
        //_state = GameObject.Find("Manager").GetComponent<GameState>();
        //_board = GameObject.Find("Manager").GetComponent<BoardState>();
	}

    void check()
    {
        Debug.Log("Yesh");
    }

}
