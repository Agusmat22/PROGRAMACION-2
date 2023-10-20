using Entidades;

namespace UnitTestingTorneo
{
    [TestClass]
    public class TestTingTorneo
    {
        

        [TestMethod]
        [DataRow("RiverPlate")]
        public void AlInvocar_CompararDosEquiposParaSaberSiSonIguales_ConElOperadorIgualIgual_DeberaRetornarTrue(string nombre)
        {
            //ARRAGE
            Torneo<Equipo> torneo = new Torneo<Equipo>("ChampionLeague");
            EquipoFutbol river = new EquipoFutbol(nombre, DateTime.Now);
            EquipoFutbol river2 = new EquipoFutbol(nombre, DateTime.Now);

            //ASSERT
            Assert.IsTrue(river == river2);


        }

        [TestMethod]
        [DataRow("RiverPlate")]
        public void AlInvocar_CompararDosEquiposParaSaberSiSonDistintos_ConElOperadorDistinto_DeberaRetornarTrue(string nombre)
        {
            //ARRAGE
            Torneo<Equipo> torneo = new Torneo<Equipo>("ChampionLeague");
            EquipoFutbol river = new EquipoFutbol(nombre, DateTime.Now);
            EquipoFutbol river2 = new EquipoFutbol("boca", DateTime.Now);

            //ASSERT
            Assert.IsTrue(river != river2);


        }

        [TestMethod]
        public void AlAgregaUnEquipoQueYaSeEncuentraDentroDelTorneo_NoLoAgregaraYRetornaFalse()
        {
            
            //ARRAGE
            Torneo<Equipo> torneo = new Torneo<Equipo>("ChampionLeague");

            EquipoFutbol river = new EquipoFutbol("boca", DateTime.Now);
            EquipoFutbol river2 = new EquipoFutbol("boca", DateTime.Now);

            bool valor = torneo + river2;
            //ASSERT

            Assert.IsFalse(torneo + river);

            
        }

        
    }
}