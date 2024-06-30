using UnityEngine;

public class OthelloGame : MonoBehaviour
{
    private const int BoardSize = 8;
    private int[,] board = new int[BoardSize, BoardSize];
    private bool isPlayerTurn = true;

    void Start()
    {
        InitializeBoard();
    }

    void Update()
    {
        if (isPlayerTurn)
        {
            PlayerMove();
        }
        else
        {
            ComputerMove();
        }
    }

    void InitializeBoard()
    {
        for (int i = 0; i < BoardSize; i++)
        {
            for (int j = 0; j < BoardSize; j++)
            {
                board[i, j] = 0;
            }
        }
        board[3, 3] = 1;
        board[3, 4] = 2;
        board[4, 3] = 2;
        board[4, 4] = 1;
    }

    void PlayerMove()
    {
        // プレイヤーの動きを処理するコードをここに追加
    }

    void ComputerMove()
    {
        // コンピュータの動きを処理するコードをここに追加
    }

    void OnGUI()
    {
        for (int i = 0; i < BoardSize; i++)
        {
            for (int j = 0; j < BoardSize; j++)
            {
                if (GUI.Button(new Rect(i * 50, j * 50, 50, 50), board[i, j].ToString()))
                {
                    if (isPlayerTurn)
                    {
                        // プレイヤーの動きを処理するコードをここに追加
                        isPlayerTurn = false;
                    }
                }
            }
        }
    }
}
