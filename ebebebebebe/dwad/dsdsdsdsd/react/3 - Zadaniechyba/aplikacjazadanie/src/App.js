import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div>
      <Box/>
      <Box/>
      <Box/>
    </div>
  );
};

function Box(){
  return (
    
    <div className="Foto">
        <Foto/>

    <div className="Opis">
        <Opis/>
        <LangList/>

    </div></div>

  );
};

function Foto(){
  return(
    <img className="imgFoto" src='img/img2.png'></img>
  );
};

function Opis(){
  return(
    <div>
      <h1>Technik programista</h1>
      <p>Programista komputerowy, programista, deweloper, potocznie koder – osoba pisząca programy komputerowe w języku programowania.
         Większość programistów zna co najmniej kilka języków programowania, lecz specjalizuje się tylko w jednym z nich.</p>
    </div>
  );
};

function LangList(){
  return(
    <div className="langList">

      <Lang lag="React" emoji="❤️" color="#0099FF"/>
      <Lang lag="C#" emoji="🦈" color="#009933"/>
      <Lang lag="Kotlin" emoji="📱" color="#660099"/>
      <Lang lag="JavaScript" emoji="📜" color="#FFCC33"/>

    </div>
  );
};

function Lang(props){
  return(
    <div className="lang" style={{backgroundColor:props.color}}>

      <span>{props.lag}</span>
      <span>{props.emoji}</span>

    </div>

  );
};



export default App;
