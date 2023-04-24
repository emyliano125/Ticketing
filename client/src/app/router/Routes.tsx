import { createBrowserRouter } from "react-router-dom";
import App from "../layout/App";
import HomePage from '../../features/home/HomePage'
import AdministrarePage from "../../features/administrare/AdministrarePage";
import SolicitariAdPage from "../../features/solicitariAD/SolicitariAdPage";
import TicketeleMelePage from "../../features/ticketeleMele/TicketeleMelePage";
import VizualizareTicketePrimite from "../../features/vizualizareTicketePrimite/VizualizareTicketePrimite";
import TicketDetails from "../../features/vizualizareTicketePrimite/TicketDetails";

export const router = createBrowserRouter([
    {
        path: '/',
        element: <App />,
        children: [
            { path: '', element: <HomePage /> },
            { path: 'administrare', element: <AdministrarePage /> },
            { path: 'solicitariAD', element: <SolicitariAdPage /> },
            { path: 'ticketeleMele', element: <TicketeleMelePage /> },
            { path: 'vizualizareTicketePrimite', element: <VizualizareTicketePrimite /> },
            { path: 'vizualizareTicketePrimite/id', element: <TicketDetails /> },
        ]

    }
])