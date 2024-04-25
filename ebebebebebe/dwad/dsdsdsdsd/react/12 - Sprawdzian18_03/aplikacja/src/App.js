import logo from './logo.svg';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css'; 
import { Button } from 'bootstrap';

function App() {
  return (
    <div id="d1">
      <Formularz/>
    </div>
  );
}

function Formularz(){
  return(
    <div>
      <form>
        <div className='form-group'>
          <label htmlFor='imie' className='mt-3'>Imie: </label>
          <input type='text' id='imie' name='imie' className='form-control'/>

          <label htmlFor='nazwisko' className='mt-3'>Nazwisko: </label>
          <input type='text' id='nazwisko' name='nazwisko' className='form-control'/>

          <label htmlFor='selectFilm' className='mt-3'>Wybierz Film: </label>
          <select id='selectFilm' name='selectFilm' className='form-control'>
            <option>Film1</option>
            <option>Film2</option>
            <option>Film3</option>
            <option>Film4</option>
            <option>Film5</option>
          </select>

          <label htmlFor='iloscBiletow' className='mt-3'>Wpisz ilość biletów: </label>
          <input type='number' id='iloscBiletow' name='iloscBiletow' className='form-control'/>
          <input type='button' className='btn btn-secondary mt-3' value='Rezerwuj' onClick={WypiszDoKonsoli}></input>
        </div>
      </form>
    </div>
  );
}

function WypiszDoKonsoli(){
  var imie = document.getElementById("imie").value;
  var nazwisko = document.getElementById("nazwisko").value;
  var wybranyFilm = document.getElementById("selectFilm").value;
  var iloscBiletow = document.getElementById("iloscBiletow").value;

  console.log("Imie: "+ imie +", Nazwisko: "+ nazwisko +", Wybrany film: "+ wybranyFilm +", Ilość biletów: "+ iloscBiletow);
}

export default App;
