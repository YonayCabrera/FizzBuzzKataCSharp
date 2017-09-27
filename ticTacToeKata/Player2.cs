namespace ticTacToeKata{
    public class Player2 : Players{
        public override string PutToken(){
            return "X";
        }

        public override string Win(){
            return "Player2 win!";
        }
    }
}