import logo from './logo.svg';
import './App.css';
import { useState } from 'react';

const info =[{
  title: "Co robi useState?",
  text: "1jgoawwogiawigaiwhgiahwghapwigha"
},
{
  title: "Co robi useState?",
  text: "2jgoawwogiawigaiwhgiahwghapwigha"
},
{
  title: "Co robi useState?",
  text: "3jgoawwogiawigaiwhgiahwghapwigha"
}

]

function App() {
  return (
    <div>
      <Box data={info}/>
    </div>
  );
}

function Box({data}){
  return(
    <div>
      {
        data.map((el, i)=><BoxItem title={el.title} text={el.text} num={i} key={el.title}/>)
      }
    </div>
  );
}

function BoxItem({num, title, text}){
  const [isOpen, setOpen] = useState(false)

  function Click(){
    setOpen(isOpen => !isOpen)
  }

  return( <div className=''>
      <p>{num}</p>
      <p onClick={Click}>{title}</p>
      <p>{isOpen ? "-" : "+"}</p>

      {isOpen && <div>{text}</div>}

    </div>
  );
}

export default App;
