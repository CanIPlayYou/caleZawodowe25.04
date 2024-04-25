import logo from './logo.svg';
import './App.css';

const daneSklep =[{
  imgName: "img/gruszka.jpg",
  name: "Gruszka",
  opis: "Eko gruszka",
  stan: 10,
  cena: 7.80,
  naStanie: true,
},
{imgName: "img/koper.jpg",
  name: "Koper",
  opis: "Eko koper",
  stan: 231,
  cena: 1.80,
  naStanie: true,
},
{imgName: "img/marchew.jpg",
  name: "Marchew",
  opis: "Eko marchew",
  stan: 2321,
  cena: 2.30,
  naStanie: true,
},
{imgName: "img/morela.jpg",
  name: "Morela",
  opis: "Eko morela",
  stan: 0,
  cena: 2.80,
  naStanie: false,
},
{imgName: "img/papaja.jpg",
  name: "Papaja",
  opis: "Eko papaja",
  stan: 25,
  cena: 5.80,
  naStanie: true,
},
{imgName: "img/papryka.jpg",
  name: "Papryka",
  opis: "Eko papryka",
  stan: 122,
  cena: 3.80,
  naStanie: true,
},
{imgName: "img/ziemniak.jpg",
  name: "Ziemniak",
  opis: "Eko ziemniak",
  stan: 2555,
  cena: 3.23,
  naStanie: true,
},

]

function App() {
  return (
    <div className='goraLewa'>

      <h1>Internetowy sklep z eko-warzywami</h1>

    <div className='goraPrawa'>
      <ol>
        <li>Warzywa</li>
        <li>Owoce</li>
        <li>Soki</li>
      </ol>


    <div id='glowny'>
        <Item/>

    <div className='stopka'>
        <GodzinaOtwarcia/>


    </div></div></div></div>

    
  );
}

function ItemList(props){
  console.log(props);

  return(

    <div className="data">

      <img src={props.itemObj.imgName} alt={props.itemObj.name}/>
      <h5>{props.itemObj.name}</h5>

      <div className='info'>
        <p>Opis: {props.itemObj.opis}</p>
        <p>Stan: {props.itemObj.stan}</p>
        <h2>Cena: {props.itemObj.cena} zł</h2>
      </div>
    </div>

  );

};

function Item(){

  const dane = daneSklep;
  const allItems = dane.length;

  return(
    <div className='items'>

      { allItems > 0 ? (
        dane.map((item)=>(
           <ItemList itemObj={item} key={item.name}/>
          ))
        ):(<p>Brak towaru</p>)
      }
    
    </div>
  );
};

function GodzinaOtwarcia(){

  var hours = new Date().getHours();

  return(
    <div>
      { hours < 18 ? (
        <h2>Sklep otwarty od 8.00 do 18.00</h2>
      ):(<h2>Sklep zamknięty</h2>) }
    </div>
  );

};

export default App;