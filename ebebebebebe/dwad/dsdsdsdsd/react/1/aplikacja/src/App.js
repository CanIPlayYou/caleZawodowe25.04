import logo from './logo.svg';
import './App.css';
import { useState } from 'react';

function App() {
    /*let a = 1;
    let b = 4;

    function add(a,b){
      return a+b;
    };

    return(<p>{a}+{b}={add(a,b)}</p>);*/


    /////////////////////////////////
    

    const [licznik, ustawLicznik] = useState(0);
    const [porada, zmienPorade] = useState(""); //importowanie danych z innego api

    async function klikniecie(){ //async jest potrzebnt do importowania danych z innego api czy jakos tak
      const res = await fetch('https://api.adviceslip.com/advice'); //importowanie danych z innego api
      const dane = await res.json(); //importowanie danych z innego api
      console.log(dane.slip.advice); //importowanie danych z innego api

      ustawLicznik(function(c){
        return c+1; //c++ nie dziala btw
      });

      //ustawLicznik((c)=>c++);
    };

    return(
      <div>
        <button onClick={klikniecie}>Start</button>
        <Info licznik = {licznik}/>

      </div>
      //zamiast info moze byc <h2>Licznik: <strong>{licznik}</strong></h2>, ale wrzucamy to do drugiego komponentu czyli funkcji Info na dole
    );
};

function Info(props){
  return(<h2>Licznik: <strong>{props.licznik}</strong></h2>);
}

export default App;
