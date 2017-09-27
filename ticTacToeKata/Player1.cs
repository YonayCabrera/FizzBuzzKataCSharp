namespace ticTacToeKata{
    public class Player1 : Players{
        public override string PutToken(){
            return "O";
        }

        public override string Win(){
            return "Player1 win!";
        }
    }
}