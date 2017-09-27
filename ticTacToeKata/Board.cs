using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ticTacToeKata{
    
    public class Board{

        private Dictionary<Position, string> board;
        public Board(){
            board = new Dictionary<Position, string>();
        }

        public void PutToken(Cell cell){
            board.Add(cell.Position,cell.Token);
        }

        public string GetResult(Players player){
            
            if (Verticals_wins(player)) return player.Win();
            if (Horizontals_wins(player)) return player.Win();
            if (Diagonals_wins(player)) return player.Win();
            return "next_player";
        }

        private bool Diagonals_wins(Players player){
            if (Have_three_on_diagonal_X0Y0_to_X2Y2(player)) return true;
            if (Have_three_on_diagonal_Y0X2_to_Y2_X0(player)) return true;
            return false;
        }

        private bool Horizontals_wins(Players player){
            if (Have_three_tokens_on_Y0_horizontal_position(player)) return true;
            if (Have_three_tokens_on_Y1_horizontal_position(player)) return true;
            if (Have_three_tokens_on_Y2_horizontal_position(player)) return true;
            return false;
        }

        private bool Verticals_wins(Players player){
            if (Have_three_tokens_on_X0_vertical_position(player)) return true;
            if (Have_three_tokens_on_X1_vertical_position(player)) return true;
            if (Have_three_tokens_on_X2_vertical_position(player)) return true;
            return false;
        }

        private bool Have_three_on_diagonal_Y0X2_to_Y2_X0(Players player){
            return board.Count(Tokens_on_position_Y0X2(player)) +
                   board.Count(Tokens_on_position_X1Y1(player)) +
                   board.Count(Tokens_on_position_Y2X0(player)) == 3;
        }

        private bool Have_three_on_diagonal_X0Y0_to_X2Y2(Players player){
            return board.Count(Tokens_on_position_X0Y0(player)) +
                   board.Count(Tokens_on_position_X1Y1(player)) +
                   board.Count(Token_on_position_X2Y2(player)) == 3;
        }

        private bool Have_three_tokens_on_Y2_horizontal_position(Players player){
            return board.Count(Tokens_on_position_Y2(player)) == 3;
        }

        private bool Have_three_tokens_on_Y1_horizontal_position(Players player){
            return board.Count(Tokens_on_positionY1(player)) == 3;
        }

        private bool Have_three_tokens_on_Y0_horizontal_position(Players player){
            return board.Count(Tokens_on_position_Y0(player)) == 3;
        }

        private bool Have_three_tokens_on_X2_vertical_position(Players player){
            return board.Count(Tokens_on_position_X2(player)) == 3;
        }

        private bool Have_three_tokens_on_X1_vertical_position(Players player){
            return board.Count(Tokens_on_position_X1(player)) == 3;
        }

        private bool Have_three_tokens_on_X0_vertical_position(Players player){
            return board.Count(Tokens_on_position_X0(player)) == 3;
        }

        private static Func<KeyValuePair<Position, string>, bool> Tokens_on_position_Y2X0(Players player){
            return token => (token.Value == player.PutToken() && token.Key.Y == 2 && token.Key.X == 0);
        }

        private static Func<KeyValuePair<Position, string>, bool> Tokens_on_position_Y0X2(Players player){
            return token => (token.Value == player.PutToken() && token.Key.Y == 0 && token.Key.X == 2);
        }

        private static Func<KeyValuePair<Position, string>, bool> Token_on_position_X2Y2(Players player){
            return token => (token.Value == player.PutToken() && token.Key.Y == 2 && token.Key.X == 2);
        }

        private static Func<KeyValuePair<Position, string>, bool> Tokens_on_position_X1Y1(Players player){
            return token => (token.Value == player.PutToken() && token.Key.Y == 1 && token.Key.X == 1);
        }

        private static Func<KeyValuePair<Position, string>, bool> Tokens_on_position_X0Y0(Players player){
            return token => (token.Value == player.PutToken() && token.Key.Y == 0 && token.Key.X == 0);
        }

        private static Func<KeyValuePair<Position, string>, bool> Tokens_on_position_Y2(Players player){
            return token => (token.Value == player.PutToken() && token.Key.Y == 2);
        }

        private static Func<KeyValuePair<Position, string>, bool> Tokens_on_positionY1(Players player){
            return token => (token.Value == player.PutToken() && token.Key.Y == 1);
        }

        private static Func<KeyValuePair<Position, string>, bool> Tokens_on_position_Y0(Players player){
            return token => (token.Value == player.PutToken() && token.Key.Y == 0);
        }

        private static Func<KeyValuePair<Position, string>, bool> Tokens_on_position_X2(Players player){
            return token => (token.Value == player.PutToken() && token.Key.X == 2);
        }

        private static Func<KeyValuePair<Position, string>, bool> Tokens_on_position_X1(Players player){
            return token => (token.Value == player.PutToken() && token.Key.X == 1);
        }

        private static Func<KeyValuePair<Position, string>, bool> Tokens_on_position_X0(Players player){
            return token => (token.Value == player.PutToken() && token.Key.X == 0);
        }
    }
}