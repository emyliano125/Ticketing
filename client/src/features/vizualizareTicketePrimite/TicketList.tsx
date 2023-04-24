import { Delete } from "@mui/icons-material";
import { Card, CardContent, Grid, IconButton, Paper, Table, TableBody, TableCell, TableContainer, TableHead, TableRow } from "@mui/material";
import moment from "moment";
import { Ticket } from "../../app/models/ticket";
import InfoIcon from '@mui/icons-material/Info';
import { blue } from "@mui/material/colors";



interface Props {
    tickets: Ticket[];
    
}
const headerColor = blue[500];

export default function TicketList({tickets}: Props){
    return(
        <Card sx={{ minWidth: 275, marginBottom:"50px" }}>
           
        <TableContainer component={Paper}>
        <Table>
            <TableHead>
                <TableRow sx={{bgcolor:'primary.light'}}>
                    <TableCell align="center" sx={{color:"black"}}>Numar Ticket</TableCell>
                    <TableCell align="center" sx={{color:"black"}}>Tip Solicitare</TableCell>
                    <TableCell align="center" sx={{color:"black"}}>Solicitant/Expeditor</TableCell>
                    <TableCell align="center" sx={{color:"black"}}>Data deschidere ticket </TableCell>
                    <TableCell align="center" sx={{color:"black"}}> Status</TableCell>
                    <TableCell align="center" sx={{color:"black"}}> Optiuni</TableCell>
                </TableRow>
            </TableHead>
            <TableBody>
                {tickets.map(ticket => (
                    <TableRow
                        key={ticket.id} sx={{'&:last-child td, &:last-child th': { border: 0 }}}>                             
                         <TableCell align="center">{ticket.id} </TableCell>
                        <TableCell align="center">{ticket.idTipSolicitare} </TableCell>
                        <TableCell align="center">{ticket.emailSolicitant}</TableCell>
                        <TableCell align="center">{moment(ticket.dataDeschidereTicket).format('LL')}</TableCell>
                        <TableCell align="center">{ticket.idStatus}</TableCell>
                        <TableCell align="center">
                            <IconButton aria-label="delete">
                                <Delete color="error"/>                                   
                            </IconButton>
                            <IconButton  aria-label="info">
                                <InfoIcon color="primary" />                                   
                            </IconButton>
                        </TableCell>
                    </TableRow>
                ))}
            </TableBody>
        </Table>
    </TableContainer>
    
    </Card>
    )
}