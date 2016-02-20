using UnityEngine;
using System.Collections;

public class BoardState : MonoBehaviour {

    private GameObject[,] _board = new GameObject[10, 8];
    public GameObject[] leftBorder = new GameObject[9];
    public GameObject[] rightBorder = new GameObject[9];
    public GameObject[] botBorder = new GameObject[8];

    void Start()
    {
        for(int i = 0; i < 9; i++)
        {
            _board[i, 0] = leftBorder[i];
            _board[i, 7] = rightBorder[i];
        }

        for(int i = 0; i < 8; i++)
        {
            _board[9, i] = botBorder[i];
        }

        Debug.Log(vacantLocations());

        leftBorder = null;
        rightBorder = null;
        botBorder = null;
    }

    int vacantLocations()
    {
        int count = 0;

        for (int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 8; j++)
            {
                if (_board[i, j] == null) count++;
            }
        }

        return count;
    }


}
