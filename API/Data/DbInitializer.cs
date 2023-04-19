using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if(context.Tickets.Any()) return;

            var tickets = new List<Ticket>
            {
                new Ticket                  		
                {
                    idTipSolicitare = 1,
                    idUnitateExpeditoare = 1,
                    idUserExpeditor = 1,
                    emailSolicitant = "nume_prenume@politia.local",
                    tlfnInteriorSolicitant = "010101",
                    tlfMobilSolicitant = "1111111111",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Probleme logare",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },
                 new Ticket    
                {
                    idTipSolicitare = 2,
                    idUnitateExpeditoare = 2,
                    idUserExpeditor = 2,
                    emailSolicitant = "nume_prenume2@politia.local",
                    tlfnInteriorSolicitant = "010102",
                    tlfMobilSolicitant = "2222222222",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Probleme server",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },
                 new Ticket    
                 {
                    idTipSolicitare = 3,
                    idUnitateExpeditoare = 3,
                    idUserExpeditor = 3,
                    emailSolicitant = "nume_prenume3@politia.local",
                    tlfnInteriorSolicitant = "010103",
                    tlfMobilSolicitant = "3333333333",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Probleme tetra",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },
                 new Ticket    
                 {
                    idTipSolicitare = 4,
                    idUnitateExpeditoare = 4,
                    idUserExpeditor = 4,
                    emailSolicitant = "nume_prenume4@politia.local",
                    tlfnInteriorSolicitant = "010104",
                    tlfMobilSolicitant = "444444444",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Probleme aplicatie",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },
                 new Ticket    
                 {
                    idTipSolicitare = 5,
                    idUnitateExpeditoare = 5,
                    idUserExpeditor = 5,
                    emailSolicitant = "nume_prenume5@politia.local",
                    tlfnInteriorSolicitant = "010105",
                    tlfMobilSolicitant = "5555555555",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Probleme retea",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },
                 new Ticket    
                 {
                    idTipSolicitare = 6,
                    idUnitateExpeditoare = 6,
                    idUserExpeditor = 6,
                    emailSolicitant = "nume_prenume6@politia.local",
                    tlfnInteriorSolicitant = "010106",
                    tlfMobilSolicitant = "6666666666",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Probleme imprimanta",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },
                 new Ticket    
                 {
                    idTipSolicitare = 1,
                    idUnitateExpeditoare = 7,
                    idUserExpeditor = 7,
                    emailSolicitant = "nume_prenume7@politia.local",
                    tlfnInteriorSolicitant = "010107",
                    tlfMobilSolicitant = "7777777777",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Probleme logare",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },
                 new Ticket    
                 {
                    idTipSolicitare = 2,
                    idUnitateExpeditoare = 8,
                    idUserExpeditor = 8,
                    emailSolicitant = "nume_prenume8@politia.local",
                    tlfnInteriorSolicitant = "010108",
                    tlfMobilSolicitant = "8888888888",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Probleme Server Picat",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },
                 new Ticket    
                 {
                    idTipSolicitare = 3,
                    idUnitateExpeditoare = 9,
                    idUserExpeditor = 9,
                    emailSolicitant = "nume_prenume9@politia.local",
                    tlfnInteriorSolicitant = "010109",
                    tlfMobilSolicitant = "9999999999",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Probleme statie tetra",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },
                 new Ticket    
                 {
                    idTipSolicitare = 4,
                    idUnitateExpeditoare = 10,
                    idUserExpeditor = 10,
                    emailSolicitant = "nume_prenume10@politia.local",
                    tlfnInteriorSolicitant = "0101010",
                    tlfMobilSolicitant = "1010101010",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Probleme aplicatie InterId",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },
                 new Ticket    
                 {
                    idTipSolicitare = 5,
                    idUnitateExpeditoare = 11,
                    idUserExpeditor = 11,
                    emailSolicitant = "nume_prenume11@politia.local",
                    tlfnInteriorSolicitant = "0101011",
                    tlfMobilSolicitant = "110110110",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Probleme conexune la internet",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },
                 new Ticket    
                 {
                    idTipSolicitare = 1,
                    idUnitateExpeditoare = 12,
                    idUserExpeditor = 12,
                    emailSolicitant = "nume_prenume12@politia.local",
                    tlfnInteriorSolicitant = "0101012",
                    tlfMobilSolicitant = "1201201201",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Probleme BAZA de date",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },
                 new Ticket    
                 {
                    idTipSolicitare = 2,
                    idUnitateExpeditoare = 13,
                    idUserExpeditor = 13,
                    emailSolicitant = "nume_prenume13@politia.local",
                    tlfnInteriorSolicitant = "0101013",
                    tlfMobilSolicitant = "1301301301",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Resetare parola Local",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },
                 new Ticket    
                 {
                    idTipSolicitare = 3,
                    idUnitateExpeditoare = 14,
                    idUserExpeditor = 14,
                    emailSolicitant = "nume_prenume14@politia.local",
                    tlfnInteriorSolicitant = "0101014",
                    tlfMobilSolicitant = "1401401401",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Probleme  tetra Arad",
                    idStatus = 1,
                    idLucratorAsignat = 0,
                    idServiciuAsignat = 0,
                    Valid = true,
                },      
            };

            foreach(var item in tickets)
            {
                context.Tickets.Add(item);
            }

            context.SaveChanges();
        }
    }
}