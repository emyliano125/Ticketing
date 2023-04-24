export interface Ticket{
    id: number
    idTipSolicitare: number
    idUnitateExpeditoare: number
    idUserExpeditor: number
    emailSolicitant: string
    tlfnInteriorSolicitant: string
    tlfMobilSolicitant: string
    dataDeschidereTicket: string
    descriere: string
    idStatus: number
    idLucratorAsignat: number
    idServiciuAsignat: number
    valid: boolean
}