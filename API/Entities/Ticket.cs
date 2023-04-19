namespace API.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public int idTipSolicitare { get; set; }
        public int idUnitateExpeditoare { get; set; }

        public int idUserExpeditor { get; set; }

        public string emailSolicitant { get; set; }

        public string tlfnInteriorSolicitant { get; set; }

        public string tlfMobilSolicitant { get; set; }

        public DateTime dataDeschidereTicket { get; set; } = DateTime.Now;
        public string Descriere { get; set; }

        public int idStatus { get; set; }

        public int MyProperty { get; set; }

        public int idLucratorAsignat { get; set; }

        public int idServiciuAsignat { get; set; }

        public bool Valid { get; set; }
    }
}