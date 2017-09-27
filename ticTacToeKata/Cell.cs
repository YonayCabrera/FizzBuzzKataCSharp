namespace ticTacToeKata{
    public class Cell{

        public Cell(string token, Position position){
            Token = token;
            Position = position;
        }
        
        public string Token{ get; private set; }
        public Position Position{ get; private set; }
    }
}