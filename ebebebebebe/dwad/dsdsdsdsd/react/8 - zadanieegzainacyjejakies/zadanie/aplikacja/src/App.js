import logo from './logo.svg';
import './App.css';
import 'bootstrap/dist/css/bootstrap.css';
import { useState } from 'react';

function App() {
  return (
    <form>

      <FormStarter />

    </form>
  );
} 

function FormStarter(){
  const [title, setTitle] = useState("")
  const [typeOfFilm, setTypeOfFilm] = useState(0)

  

  return <div>

      <TitleInput title={title} onSetTitle={setTitle} />

      <SelectInput typeFilm={typeOfFilm} onSelect={setTypeOfFilm} />

      <Output title={title} typeFilm={typeOfFilm}/>

      <button type="button" className="btn btn-primary">Dodaj</button>

      

  </div>
}

function TitleInput({title, onSetTitle}){
  return(
    <div>
      <label htmlFor="labelForTytulFilmu">Tytuł filmu:</label>
      
      <input type='text' className='form-control' value={title} onChange={e => onSetTitle(e.target.value)}/>
    </div>
  );
}

function SelectInput({typeFilm, onSelect}){
  return(
    <div>
      <label htmlFor="labelForRodzajFilmu">Rodzaj</label>

      <select className="form-select" value={typeFilm} onChange={e => onSelect(Number(e.target.value))}>
        <option defaultValue></option>
        <option value="1">Komedia</option>
        <option value="2">Obyczajowy</option>
        <option value="3">Sensacyjny</option>
        <option value="4">Horror</option>

      </select>
    </div>
  );
}

function Output({title, typeFilm}){
  return console.log("tytuł: "+ title + " rodzaj: "+ typeFilm);
}

export default App;
