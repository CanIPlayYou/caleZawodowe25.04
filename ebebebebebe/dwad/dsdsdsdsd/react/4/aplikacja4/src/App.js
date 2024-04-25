import React from "react";

const lang =[
    {
        skill:"HTML + Css",
        level:"Advanced",
        color:"#2663EA",
    },
    {
        skill:"JavaScript",
        level:"Advanced",
        color:"#2663EA",
    },
    {
        skill:"C#",
        level:"Advanced",
        color:"#2663EA",
    },
    {
        skill:"Kotlin",
        level:"Intermeditate",
        color:"#2663EA",
    },
    {
        skill:"React",
        level:"Beginner",
        color:"#2663EA",
    },
]


export default function App(){
    return(
        <div className="Box">
            <Image/>

            <div className="data">
                <Info/>
                <LangList/>

            </div>

        </div>
    );
}

function Image(){
    return <img className="image" src="imagess/gruszka.jpg" alt="gruszka"></img>
}

function Info(){
    return <div>
        <h1>Gruszka</h1>
        <p>gruszka to owoc ofwogaowhowh oghaowghoaw hgoiaw wghwoughaow gwaugaog gwgaowig igwhoagh gwhao</p>
    </div>
}

function LangList(){
    return <div className="lang-list">
        {
            lang.map(item =><Lag lang={item.skill} color={item.color} level={item.level}/>)
        }

    </div>
}

function Lag({lang, color, level}){
    return <div className="lang" style={{backgroundColor:color}}>
        <span>{lang}</span>
        <span>
            {level==="Advanced" && "❤️"}
            {level==="Intermeditate" && "👌"}
            {level==="Beginner" && "👍"}
        </span>

    </div>
}