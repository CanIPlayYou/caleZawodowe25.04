import logo from './logo.svg';
import './App.css';
import User from './User'

function App() {

  let aktywnyy = "Aktywny";
  let nieaktywny = "Nieaktywny";

  const user = {
    imie: 'Ala',
    rola: 'Tester',
    aktywny: true,
  }

  const setUser = () => {
    console.log('Klik');
    const imie = document.getElementById('name').value;
    const rola = document.getElementById('rola').value;
    const aktywny = document.getElementById('aktywny').checked;
  }

  return (
    <div>
      <label>Imię: </label>
      <input type='text' id='imie'/>

      <label>Rola: </label>
      <input type='text' id='rola'/>

      <label>Aktywny: </label>
      <input type='checkbox' id='aktywny'/>  

      <User imie={user.imie} rola={user.rola} buttonClick={()=>setUser()}>{user.aktywny? aktywnyy : nieaktywny}</User>
    </div>
  );
}

export default App;
