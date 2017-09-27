using System.Runtime.InteropServices;
using NUnit.Framework;

namespace ticTacToeKata{
    
    [TestFixture]
    public class BoardShould{

        private Board board;
        private Player1 player1;
        private Player2 player2;
        [SetUp]
        public void SetUp(){
            board = new Board();
            player1 = new Player1();
            player2 = new Player2();
        }

        [Test]
        public void Return_O_when_player1_play(){
            board.PutToken(new Cell(player1.PutToken(),new Position(0,0)));
            Assert.AreEqual(board.GetResult(player2),"next_player");
        }

        [Test]
        public void Return_X_when_player2_play(){
            board.PutToken(new Cell(player2.PutToken(),new Position(0,0)));
            Assert.AreEqual(board.GetResult(player2),"next_player");
        }

        [Test]
        public void Return_player1_win_with_verticals(){
            board.PutToken(new Cell(player1.PutToken(),new Position(0,0)));
            board.PutToken(new Cell(player1.PutToken(), new Position(1, 0)));
            board.PutToken(new Cell(player1.PutToken(), new Position(2, 0)));
            
            Assert.AreEqual(board.GetResult(player1),"Player1 win!");
        }
        
        [Test]
        public void Return_player1_win_with_horizontals(){
            board.PutToken(new Cell(player1.PutToken(),new Position(0,0)));
            board.PutToken(new Cell(player1.PutToken(), new Position(0, 1)));
            board.PutToken(new Cell(player1.PutToken(), new Position(0, 2)));
            
            Assert.AreEqual(board.GetResult(player1),"Player1 win!");
        }
        
        [Test]
        public void Return_player1_win_with_diagonals(){
            board.PutToken(new Cell(player1.PutToken(),new Position(0,0)));
            board.PutToken(new Cell(player1.PutToken(), new Position(1, 1)));
            board.PutToken(new Cell(player1.PutToken(), new Position(2, 2)));
            
            Assert.AreEqual(board.GetResult(player1),"Player1 win!");
        }
        
    }
}