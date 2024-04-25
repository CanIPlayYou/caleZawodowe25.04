import './App.css';

const daneFilmu =[{
  imgFilmu: "img/alien.jpg",
  nazwaFilmu: "Alien4",
  nrFilmu: "18",
  rodzajFilmu: "Polecane",
},
{
  imgFilmu: "img/et.jpg",
  nazwaFilmu: "E.T.",
  nrFilmu: "11",
  rodzajFilmu: "Fantastyczne",
},
{
  imgFilmu: "img/fantasy.jpg",
  nazwaFilmu: "Fantasy2",
  nrFilmu: "14",
  rodzajFilmu: "Fantastyczne",
},
{
  imgFilmu: "img/hobbit.jpg",
  nazwaFilmu: "Hobbit",
  nrFilmu: "13",
  rodzajFilmu: "Fantastyczne",
},
{
  imgFilmu: "img/koralowa_wyspa.jpg",
  nazwaFilmu: "Koralowa Wyspa",
  nrFilmu: "22",
  rodzajFilmu: "Polecane",
},
{
  imgFilmu: "img/krokodyl.jpg",
  nazwaFilmu: "Krokodyl",
  nrFilmu: "23",
  rodzajFilmu: "Polecane",
},
{
  imgFilmu: "img/star-wars.jpg",
  nazwaFilmu: "Star Wars 2",
  nrFilmu: "17",
  rodzajFilmu: "Fantastyczne",
},
{
  imgFilmu: "img/steampunk.jpg",
  nazwaFilmu: "SteamPunk",
  nrFilmu: "25",
  rodzajFilmu: "Polecane",
},
]

function App() {
  return (
    <div className='mainDiv'>
      <div className='navBar'>
        <h1>Internetowa wypożyczalnia filmów</h1>
      </div>

      <div className='naglowekFilmow'>
        <h4>Polecamy</h4>
      </div>

      <div className='wysFilmyDiv'>

      <Film></Film>

      </div>

      <div className='naglowekFilmow'>
        <h4>Filmy fantastyczne</h4>
      </div>

      <div className='wysFilmyDiv'>

      <Film></Film>

      </div>

      <div className='stopka'>

        <h1 id='h1Stopka'><Otwarcie></Otwarcie></h1>
        <h2>Ilość filmów w bazie: {daneFilmu.length}</h2>

      </div>

    </div>
  );
}

function FilmList(props){
  console.log(props);

  return(

    <div>

      <h5 className='nazwaFilm'>{props.filmm.nazwaFilmu}</h5>
      <p>{props.filmm.nrFilmu}</p>
      <img src={props.filmm.imgFilmu} alt={props.filmm.name}/>
      
    </div>

  );

};

function Film(){

  const daneF = daneFilmu;
  const Filmy = daneF.length;

  return(
    <div className="test">

      { Filmy > 0 ? (
        daneF.map((item)=>(
           <FilmList filmm={item} key={item.imgFilmu}/>
          ))
        ):(<p>Brak filmów</p>)
      }
    
    </div>
  );
};

function Otwarcie(){

  var h = new Date().getHours();

  return(
    <div>
      { h < 12 ? (
        <h2>Otwarte od 8.00 do 12.00</h2>
      ):(<h2>Zamknięte</h2>) }
    </div>
  );

};



export default App;