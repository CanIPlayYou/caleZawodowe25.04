import logo from './logo.svg';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css'; 
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import { useState } from 'react';

function App() {
  const [board, setBoard] = useState(Array(9).fill(null));
  const [xIsNext, setXIsNext] = useState(true);
  const [winner, setWinner] = useState(null);
  const [player1Name, setPlayer1Name] = useState('');
  const [player2Name, setPlayer2Name] = useState('');

  const handleClick = (index) => {
    if (winner || board[index]) return;

    const newBoard = [...board];
    newBoard[index] = xIsNext ? 'X' : 'O';
    setBoard(newBoard);
    setXIsNext(!xIsNext);
    

    const newWinner = calculateWinner(newBoard);
    if (newWinner) {
      setWinner(newWinner);
    }
  };

  const renderSquare = (index) => {
    const checkmark = ".";
    return (  
      <button className="btns" onClick={() => handleClick(index)}>
        {board[index]}{checkmark}
      </button>
    );
  };

  const resetGame = () => {
    setBoard(Array(9).fill(null));
    setWinner(null);
    setXIsNext(true);
  };

  const calculateWinner = (squares) => {
    const lines = [ //Pola wygrywające
      [0, 1, 2],
      [3, 4, 5],
      [6, 7, 8],
      [0, 3, 6],
      [1, 4, 7],
      [2, 5, 8],
      [0, 4, 8],
      [2, 4, 6],
    ];

    for (let i = 0; i < lines.length; i++) { //Pętla przechodzi przez tablicę 'lines', która zawiera wszystkie możliwe kombinacje wygrywające w grze w kółko i krzyżyk.
      const [a, b, c] = lines[i]; //Rozbicie tablicy lines[i] do zmiennych a, b i c, które reprezentują indeksy w tablicy squares.
      if (squares[a] && squares[a] === squares[b] && squares[a] === squares[c]) { //Sprawdzamy, czy wartości w squares[a], squares[b] i squares[c] są takie same i nie są null.
        return squares[a]; //Jeśli wartości są takie same i nie są null, zwracamy wartość w squares[a], która jest zwycięzcą gry.
      }
    }

    return null;
  };

  const status = () => {
    if (winner) {
      return 'Wygrał: ' + (winner === 'X' ? player1Name : player2Name);
    } else {
      return 'Kolej gracza: ' + (xIsNext ? player1Name : player2Name);
    }
  };

  return (
    <div className='main'>
      <div className='NavBar'>
        <h1>Kółko i krzyżyk</h1>
      </div>

      <div className='playersInput'>
        <form>
          <div className='form-group'>
            <label htmlFor='player1Name'>Nazwa gracza X: </label>
            <input type='text' id='player1Name' name='player1Name' onChange={(e) => setPlayer1Name(e.target.value)}></input>

            <label htmlFor='player2Name'>Nazwa gracza O: </label>
            <input type='text' id='player2Name' name='player2Name' onChange={(e) => setPlayer2Name(e.target.value)}></input>
          </div>
        </form>
      </div>

      <div className='gameWindow'>
        <div className="status">{status()}</div>
        <div className='flex'>
          <div className="board-row">
            {renderSquare(0)}
            {renderSquare(1)}
            {renderSquare(2)}
          </div>
          <div className="board-row">
            {renderSquare(3)}
            {renderSquare(4)}
            {renderSquare(5)}
          </div>
          <div className="board-row">
            {renderSquare(6)}
            {renderSquare(7)}
            {renderSquare(8)}
          </div>
        </div>
        <button className='resetButton' onClick={resetGame}>Zacznij od nowa</button>
      </div>
    </div>
  );
}

export default App;