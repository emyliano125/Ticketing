import { useEffect, useState } from "react";
import { Ticket } from "../../app/models/ticket"
import TicketList from "./TicketList";


export default function VizualizareTicketePrimite() {

    const [tickets, setTickets] = useState<Ticket[]>([]);


    useEffect(() => {
      fetch('http://localhost:5001/api/tickets')
        .then(repsonse => repsonse.json())
        .then(data => setTickets(data))
    }, [])
  
    // function addTicket() {
    //   setTickets(prevState => [...prevState,
    //   {
    //     id: prevState.length + 1,
    //     idTipSolicitare: prevState.length + 1,
    //     idUnitateExpeditoare: prevState.length + 1,
    //     idUserExpeditor: prevState.length + 1,
    //     emailSolicitant: 'Finalizat',
    //     tlfnInteriorSolicitant: '123455123',
    //     tlfMobilSolicitant: '1231231231231',
    //     dataDeschidereTicket: '02/03/2023',
    //     descriere: 'Tipsolicitare' + (prevState.length + 1),
    //     idStatus: 2,
    //     idLucratorAsignat: 0,
    //     idServiciuAsignat: 0,
    //     valid: true,
    //   }])
    // }
  

    return (
        <>
            <h1>Vizualizare tickete</h1>
           <TicketList tickets = {tickets} />
        </>





    )
}