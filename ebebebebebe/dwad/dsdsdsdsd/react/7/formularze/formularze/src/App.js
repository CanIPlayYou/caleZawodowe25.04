import logo from './logo.svg';
import './App.css';
import { useState } from 'react';

function App() {
  return (
    <div>

      <TipCalculator/>

    </div>
  );
}

function TipCalculator(){

  const [bill, setBill] = useState("")
  const [percent1, setPercent1] = useState(0)
  const [percent2, setPercent2] = useState(0)

  const tip = Math.ceil(bill * (percent1*percent2)/2/100);


  return <div> 
    
    <BillInput bill={bill} onSetBill={setBill} />
    
    <SelectProcent percentag={percent1} onSelect={setPercent1}>Czy podobała się obsługa? </SelectProcent>
    <SelectProcent percentag={percent2} onSelect={setPercent2}>Czy polecisz znajomym? </SelectProcent>

    {bill > 0 && (<>
    <Output bill={bill} tip={tip}></Output>
    </>)}
    
  </div>
}

function BillInput({bill, onSetBill}){
  return( <div>Ile wyniósł rachunków?

  <input
    type = "text"
    placeholder = "Wartość rachunku"
    value = {bill}

    onChange={e => onSetBill(Number(e.target.value))} //Odczyt z pola input
  />

  </div>
  );
}

function SelectProcent({children, percentag, onSelect}){
  return(
    <div>

      <label>{children}</label>

      <select value={percentag} onChange={e => onSelect(Number(e.target.value))}>

        <option value="0">Niezadowolony (0%)</option>
        <option value="5">Było dobrze (5%)</option>
        <option value="10">Było bardzo dobrze (10%)</option>
        <option value="20">Wspaniale (20%)</option>

      </select>

    </div>
  );
}

function Output({bill, tip}){
  return <h3>Płacisz: ${bill+tip} (${bill} + ${tip} napiwek)</h3>
}

export default App;
