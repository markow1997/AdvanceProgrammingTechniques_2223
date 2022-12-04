#include <iostream>
#include <vector>

using namespace std;

class Solution {
public:
    void printBoard(vector<vector<int>>& board) {
        for (int i = 0; i < board.size(); i++) {
            for (int j = 0; j < board[i].size(); j++)
                cout << board[i][j];
            cout << '\n';
        }
    }

    void gameOfLife(vector<vector<int>>& board) {
        int* newStates = new int[board.size() * board[0].size()];
        printBoard(board);

        for (int i = 0; i < board.size(); i++)
        {
            for (int j = 0; j < board[i].size(); j++)
            {
                int aliveNeighbours = 0;

                if (i > 0 && j > 0) if (board[i - 1][j - 1] == 1)   aliveNeighbours++;
                if (i > 0)          if (board[i - 1][j] == 1)       aliveNeighbours++;
                if (j > 0)          if (board[i][j - 1] == 1)       aliveNeighbours++;

                if (i < board.size() - 1 && j < board[i].size() - 1) if (board[i + 1][j + 1] == 1)  aliveNeighbours++;
                if (i < board.size() - 1)       if (board[i + 1][j] == 1)                           aliveNeighbours++;
                if (j < board[i].size() - 1)    if (board[i][j + 1] == 1)                           aliveNeighbours++;

                if (i > 0 && j < board[i].size() - 1)   if (board[i - 1][j + 1] == 1)  aliveNeighbours++;
                if (i < board.size() - 1 && j > 0)      if (board[i + 1][j - 1] == 1)  aliveNeighbours++;


                if (board[i][j] == 1) {
                    if (aliveNeighbours < 2)
                        newStates[i + j * board.size()] = 0;
                    else if (aliveNeighbours > 3)
                        newStates[i + j * board.size()] = 0;
                    else
                        newStates[i + j * board.size()] = 1;
                }
                else
                    if (aliveNeighbours == 3) 
                        newStates[i + j * board.size()] = 1;
                    else
                        newStates[i + j * board.size()] = 0;
            }
        }

        for (int i = 0; i < board.size(); i++)
            for (int j = 0; j < board[i].size(); j++)
                board[i][j] = newStates[i + j * board.size()];
    }
};


// ------ MAIN ------
int main()
{
    Solution solution;
    vector<vector<int>> board = { {0, 1, 0} , {0, 0, 1}, {1, 1, 1}, {0, 0, 0} };

    solution.gameOfLife(board);
}
