import { useEffect, useState } from "react";




function App() {

  const [tickets, setTickets] = useState([
    { descriere: 'Tipsolicitare1', emailSolicitant: 'Nepreluat' },
    { descriere: 'Tipsolicitare2', emailSolicitant: 'In desfasurare' },
    { descriere: 'Tipsolicitare3', emailSolicitant: 'Finalizat' },
    { descriere: 'Tipsolicitare4', emailSolicitant: 'Finalizat' },
  ]);


  useEffect(()=>{
    fetch('http://localhost:5001/api/tickets')
      .then(repsonse => repsonse.json())
      .then(data => setTickets(data))
  },[])

  function addTicket(){
    setTickets(prevState => [...prevState, {descriere:'Tipsolicitare' + (prevState.length + 1),emailSolicitant:'Finalizat'}])
  }

  return (
    <div >
      <h1>Aplicatie Ticheting</h1>

      <ul>

        {tickets.map((item,index) => (
          <li key={index}>
            {item.descriere} - {item.emailSolicitant}
          </li>

        ))}
      </ul>
      <button onClick={addTicket}>AddTicket</button>
    </div>
  );
}

export default App;
