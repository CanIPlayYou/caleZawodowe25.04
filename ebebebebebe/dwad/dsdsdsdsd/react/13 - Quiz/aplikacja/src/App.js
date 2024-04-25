import logo from './logo.svg';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Button } from 'react-bootstrap';
import { Modal } from 'react-bootstrap';
import { useState } from 'react';
import { Form } from 'react-bootstrap';

function App() {
  return (
    <div className='Main'>
      <div className='NavBar'>
        <WindowView/>
      </div>

      <div className='InMainWindow'>
        <ModalWindow/>
      </div>
    </div>
  );
}

function WindowView(){
  return(
    <h1>Quiz</h1>
  );
}

function ModalWindow(){
  const [show, setShow] = useState(false);

  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);

  return (
    <>
      <Button variant="secondary" onClick={handleShow}>
        Rozpocznij quiz
      </Button>

      <Modal show={show} onHide={handleClose}>
        <Modal.Header closeButton>
          <Modal.Title>Nazwa gracza</Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <Form>
            <Form.Group
              className="mb-3"
              controlId="exampleForm.ControlTextarea1"
            >
              <Form.Label>Wprowadź swoją nazwe: </Form.Label>
              <Form.Control as="input"/>
            </Form.Group>
          </Form>
        </Modal.Body>
        <Modal.Footer>
          <Button variant="secondary" onClick={handleClose}>
            Zamknij
          </Button>
          <Button variant="primary" onClick={handleClose}>
            Zatwierdź
          </Button>
        </Modal.Footer>
      </Modal>
    </>
  );
}

export default App;
