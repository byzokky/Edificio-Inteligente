using parcial1.salones;
using parcial1.reservas;
    

namespace parcial1.usuarios
{
    public class usuario
    {
        #region Properties

            public string Nombre { get; set; }

            public int CC { get; set; }

        #endregion Properties

        #region Metodos

            public bool EnterMenu(int CCAcess)
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

        public salon reservas { get; set; }
        

        #endregion properties


        #region getters & setters

        #endregion getters & setters
    }

    public class admin: usuario
    {
        #region Properties


        #endregion Properties
    }

}