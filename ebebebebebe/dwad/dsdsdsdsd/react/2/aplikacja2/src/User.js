const userView = (props) =>{
    return <div>
        <button onClick={props.setUser}>Zapisz</button>
        <h1>Imię: {props.imie} </h1>
        <h3>Rola: {props.rola} </h3>
        <p>Status: {props.children} </p>
    </div>
}

export default userView;