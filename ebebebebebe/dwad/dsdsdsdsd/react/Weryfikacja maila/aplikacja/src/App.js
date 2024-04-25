import logo from './logo.svg';
import './App.css';
import { useState } from 'react';

function App() {
  const [email, setEmail] = useState();
  return (
    <div>
      <input name='emailInput' id="emailInput" type='text' onBlur={SprawdzMail}></input>
      <input name='passInput' id='passInput' type='password' onBlur={SprawdzHaslo}></input>
    </div>
  );
}

function SprawdzHaslo(event){
  var haslo = event.target.value;

  if(haslo.length > 10){
    console.log("powyzej 10")
  }else{
    console.log("ponizej 10")
  }
}

function SprawdzMail(event){
  let res = /@/;
  var email = event.target.value;

  if(res.test(email)){
    console.log("email poprawyn :>")
  }else{
    console.log("Email niepoprawny!")
  }
}

export default App;
