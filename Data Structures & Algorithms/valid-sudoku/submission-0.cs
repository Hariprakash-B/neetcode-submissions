public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int row = board.Length;
        int column = board[0].Length;
        for(int i=0; i< row; i++){
            List<char> tempRow = new List<char>();
            List<char> tempColumn = new List<char>();
            for(int j=0; j < column; j++){
                if(tempRow.Contains(board[i][j])){
                    return false;
                }
                else{
                    if(board[i][j] != '.'){
                        tempRow.Add(board[i][j]);
                    }
                }

                if(tempColumn.Contains(board[j][i])){
                    return false;
                }
                else{
                    if(board[j][i] != '.'){
                        tempColumn.Add(board[j][i]);
                    }
                }
            }
        }
        for(int i=0; i<9;i++){
            List<char> tempbox = new List<char>();
            for(int row1=0; row1<3 ; row1++){
                for(int col=0; col<3;col++){
                    int rowBox = (i/3)*3+row1;
                    int colBox = (i%3)*3+col;
                    if(tempbox.Contains(board[rowBox][colBox])){
                        return false;
                    }
                    else{
                        if(board[rowBox][colBox] != '.'){
                            tempbox.Add(board[rowBox][colBox]);
                        }
                    }
                }
            }
        }
        return true;
    }
}
