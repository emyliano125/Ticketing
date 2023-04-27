import { Delete } from "@mui/icons-material";
import { Button, Card, CardContent, Grid, IconButton, Paper, Table, TableBody, TableCell, TableContainer, TableHead, TableRow } from "@mui/material";
import moment from "moment";
import { Ticket } from "../../app/models/ticket";
import InfoIcon from '@mui/icons-material/Info';
import { blue } from "@mui/material/colors";
import { Link } from "react-router-dom";



interface Props {
    tickets: Ticket[];

}
const headerColor = blue[500];

export default function TicketList({ tickets }: Props) {

    return (
        <Card sx={{ minWidth: 275, marginBottom: "50px", mr: 5, ml: 5 }}>

            <TableContainer component={Paper}>
                <Table>
                    <TableHead>
                        <TableRow
                            sx={{
                                bgcolor: 'primary.light'
                            }}>
                            <TableCell align="center" sx={{ color: "black" }}>Numar Ticket</TableCell>
                            <TableCell align="center" sx={{ color: "black" }}>Tip Solicitare</TableCell>
                            <TableCell align="center" sx={{ color: "black" }}>Solicitant/Expeditor</TableCell>
                            <TableCell align="center" sx={{ color: "black" }}>Data deschidere ticket </TableCell>
                            <TableCell align="center" sx={{ color: "black" }}> Status</TableCell>
                            <TableCell align="center" sx={{ color: "black" }}> Optiuni</TableCell>
                        </TableRow>
                    </TableHead>
                    <TableBody>
                        {tickets.map(ticket => (
                            <TableRow 
                                key={ticket.id} sx={{
                                    '&:last-child td, &:last-child th': { border: 0 },
                                    "&:hover": {
                                        backgroundColor: "grey.300"
                                    }
                                }}>
                                <TableCell align="center">{ticket.id} </TableCell>
                                <TableCell align="center">{ticket.solicitare.denumire} </TableCell>
                                <TableCell align="center">{ticket.emailSolicitant}</TableCell>
                                <TableCell align="center">{moment(ticket.dataDeschidereTicket).format('LL')}</TableCell>
                                <TableCell align="center"><Button variant="outlined" color={ticket.statusId===2 ? "warning" : ticket.statusId===3 ? "success" : ticket.statusId===4 ? "error" :"info"} sx={{ minWidth: 130 }}>{ticket.status.denumire}</Button></TableCell>
                                <TableCell align="center">
                                    <IconButton aria-label="delete">
                                        <Delete color="error" />
                                    </IconButton>
                                    <IconButton component={Link} to={`/vizualizareTicketePrimite/${ticket.id}`} aria-label="info">
                                        <InfoIcon color="primary" />
                                    </IconButton>
                                </TableCell>
                            </TableRow>
                        ))}
                    </TableBody>
                </Table>
            </TableContainer>

        </Card >
    )
}