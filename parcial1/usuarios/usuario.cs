using parcial1.salones;
using parcial1.reservas;
    

namespace parcial1.usuarios
{
    public class usuario
    {
        #region Properties

            public string Nombre { get; set; }

            public string CC { get; set; }

        #endregion Properties

        #region Metodos

            public bool EnterMenu(string CCAcess)
            {
                bool responde = false;
                if(CC == CCAcess)
                {
                    responde= true;
                }
                return responde;
            }
            
        #endregion Metodos
    }

    public class profesor: usuario
    {
        #region properties
        public string Materia { get; set; }

        private reserva reservas;
        

        #endregion properties


        #region getters & setters
        private reserva Reservas
        {
            get { return Reservas; }
            set
            {
                if (Reservas == null)
                {
                    Reservas = value;
                }
            }
        }

        #endregion getters & setters
    }

    public class admin: usuario
    {
        #region Properties


        #endregion Properties
    }

}