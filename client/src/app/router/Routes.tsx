import { Navigate, createBrowserRouter } from "react-router-dom";
import App from "../layout/App";
import HomePage from '../../features/home/HomePage'
import AdministrarePage from "../../features/administrare/AdministrarePage";
import SolicitariAdPage from "../../features/solicitariAD/SolicitariAdPage";
import TicketeleMelePage from "../../features/ticketeleMele/TicketeleMelePage";
import VizualizareTicketePrimite from "../../features/vizualizareTicketePrimite/VizualizareTicketePrimite";
import TicketDetails from "../../features/vizualizareTicketePrimite/TicketDetails";
import ErrorsPage from "../../features/errors/ErrorsPage";
import ServerError from "../../features/errors/ServerError";
import NotFound from "../../features/errors/NotFound";

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
            { path: 'vizualizareTicketePrimite/:id', element: <TicketDetails /> },
            { path: 'errors', element: <ErrorsPage /> },
            { path: 'server-error', element: <ServerError /> },
            { path: 'not-found', element: <NotFound /> },
            { path: '*', element: <Navigate replace to ='not-found'/> },
            
        ]

    }
])