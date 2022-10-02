namespace DBHomeWorkMusicSalesShop.Interfaces
{
    public interface IMusicShopServices
    {
        void Run();
        void PirmasKlientoPrisijungimoMetodas();
        IEnumerable<dynamic> GautiKlientus();
        void PirkimoSistemosMetodas();
        void SalesHistoryData();
        void RusiavimoPasirinkimoMetodas();
        void RikiavimoMetoduMeniu();
        void KrepselioFormavimoMeniu();
        void PirkimoPasirinkimoKomandos(List<dynamic> rastuDainuSaras);
        void KrepselioRodymoMetodas();
        void PirkimoUzbaigimoKomandos();
        void SukurtiInvoiceMetodas();
        void GryzimoIMeniuMetodoKomanda();
        IEnumerable<dynamic> RastiDainaPagalIdMetodas();
        void RastiDainaPagalName();
        void RastiDainaPagalAlbumID();
        void RastiDainaPagalAlbumName();
        void RastiDainaPagalComposer();
        void RastiDainaPagalGenre();
        void RastiDainaPagalComposerIrAlbum();
        void RastiDainaPagalTrukme();
        void GautiKlientoAtaskaitasPagalKlientoID(int klientoId);
        void KlientoRegistracijosMetodas();
        void AdminAplinkosSecurityMetodas();
        void DarbuotojoAplinkosMetodas();
        void AdminAplinkosMetodas();
        void KeistiKlientųDuomenisMetodoMeniu();
        void RodytiPasirinktoKlientoDuomenisIrPrasytiSuvestiNaujus();
        void PakeistiDainosStatusą();
        void StatistikosDarbuotojamsMeniu();





    }
}