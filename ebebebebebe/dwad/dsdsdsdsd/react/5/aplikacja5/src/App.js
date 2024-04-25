import logo from './logo.svg';
import './App.css';
import { useState } from 'react';

const wiadomosc = [
  "Naucz się React",
  "Aplikuj na stanowisko pracy",
  "Inwestuj swój nowy dochód"
]

function App() {

  const [krok, setKrok] = useState(1);

  const [isOpen, setIsOpen] = useState(true);


  function clickPrev(){
    if(krok>1){
      setKrok(krok-1);
    }

  }


  function clickNext(){
    if(krok<3){
      setKrok((s)=>s+1);
    }

  }


  return(
    <>

      <button className='close' onClick={()=>setIsOpen(!isOpen)}>&times;</button>
      <button className='close' onClick={()=>setIsOpen((is)=>!is)}>&times;</button>

      {isOpen && (
      <div className='steps'>
        

        <div className='numbers'>
          <div className={krok ==1 ? "active": ""}>1</div>
          <div className={krok ==2 ? "active": ""}>2</div>
          <div className={krok ==3 ? "active": ""}>3</div>
        </div>

        <p className='message'>Krok {krok}: {wiadomosc[krok-1]}</p>

        <div className='buttons'>
          <button onClick={clickPrev}>Prev</button>
          <button onClick={clickNext}>Next</button>
        </div>
      </div>
      )}

    </>)
}

function Button(){
  return <button></button>;
}

export default App;
