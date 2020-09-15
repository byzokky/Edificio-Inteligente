using System;
using parcial1.usuarios;
using parcial1.salones;

namespace parcial1.menu
{
    public class fachada
    {
        #region Properties

    public string opc { get; set; }
        
    #endregion Properties

    #region getters & setters
        
    #endregion getters & setters

    #region metodos
    public string menu(admin User1, profesor[] VecProf){
        while (true)
        {
        Console.WriteLine("BIENVENIDO AL EDIFICION INTELIGENTE DE AUTOGESTION");
        Console.WriteLine("===========================================");
        Console.WriteLine("INGRESAR SU CC");
        opc = Console.ReadLine();
        if (opc == User1.CC)
            {
                MenuAdmin();
            }
            for (int i = 0; i < 3; i++)
            {                   
                if (opc == VecProf[i].CC)
                {
                    MenuProf(VecProf[i]);
                }
            }
        }
    }
    
    public string MenuAdmin(){
        while (true)
        {
            Console.WriteLine("BIENVENIDO AL MENU DE ADMINISTRADOR");
            Console.WriteLine("===========================================");
            Console.WriteLine("1:Ver estado de los salones");
            Console.WriteLine("2:Ver reservas");
            Console.WriteLine("3:Manda a mantenimiento");
            Console.WriteLine("4:Cambiar temperatura");
            Console.WriteLine("5:Encender/Apagar la luz");
            opc = Console.ReadLine();
            if (opc == "1" || opc == "2" || opc == "3" || opc == "4" || opc == "5")
            {
                return opc;
            }
            Console.WriteLine("opcion" + opc + " es invalida");   
        }
    }

    public string MenuProf( profesor Prof){
        while (true)
        {
            Console.WriteLine("BIENVENIDO AL MENU DE PROFESOR" + Prof);  
            Console.WriteLine("===========================================");
            Console.WriteLine("1:Ver estado de los salones");
            Console.WriteLine("2:Ver reservas");
            Console.WriteLine("3:Manda a reservar");
            opc = Console.ReadLine();
            if (opc == "1" || opc == "2" || opc == "3")
            {
                return opc;
            }
            Console.WriteLine("opcion" + opc + " es invalida");       
        }
    }
        
    #endregion metodos

    }
}