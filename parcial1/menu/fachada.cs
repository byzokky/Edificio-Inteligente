using System;
using parcial1.usuarios;
using parcial1.salones;

namespace parcial1.menu
{
    public class fachada
    {
        #region Properties

    public string opc { get; set; }

    public int hora { get; set; }
        
    #endregion Properties

    #region getters & setters
        
    #endregion getters & setters

    #region metodos
    public void menu(admin User1, profesor[] VecProf, salon[] VecSalon){
        while (true)
        {
            int OpcN;
            Console.WriteLine("BIENVENIDO AL EDIFICION INTELIGENTE DE AUTOGESTION");
            Console.WriteLine("===========================================");
            Console.WriteLine("INGRESAR SU CC");
            opc = Console.ReadLine();
            OpcN = int.Parse(opc);
            if (OpcN == User1.CC)
            {
                MenuAdmin(VecSalon, VecProf);
            }
            for (int i = 0; i < 3; i++)
            {                   
                if (OpcN == VecProf[i].CC)
                {
                    MenuProf(VecProf[i], VecSalon, VecProf);
                }
            }
        }
    }
    
    public void MenuAdmin(salon[] VecSalon, profesor[] VecProf){
        while (true)
        {
            int OpcN;
            Console.WriteLine("BIENVENIDO AL MENU DE ADMINISTRADOR");
            Console.WriteLine("===========================================");
            Console.WriteLine("1:Ver estado de los salones");
            Console.WriteLine("2:Ver reservas");
            Console.WriteLine("3:Manda a mantenimiento");
            Console.WriteLine("4:Cambiar temperatura");
            Console.WriteLine("5:cambiar hora");
            opc = Console.ReadLine();
            OpcN = int.Parse(opc);
            if (OpcN == 1 || OpcN == 2)
            {
                general(OpcN, VecSalon, VecProf);
            }
            if (OpcN == 3 || OpcN == 4 || OpcN == 5)
            {
                OpcAdmin(OpcN, VecSalon, VecProf);
            }
            Console.WriteLine("opcion" + opc + " es invalida");   
        }
    }

    public void MenuProf( profesor Prof, salon[] VecSalon, profesor[] VecProf){
        while (true)
        {
            int OpcN;
            Console.WriteLine("BIENVENIDO AL MENU DE PROFESOR" + Prof);  
            Console.WriteLine("===========================================");
            Console.WriteLine("1:Ver estado de los salones");
            Console.WriteLine("2:Ver reservas");
            Console.WriteLine("3:Manda a reservar");
            opc = Console.ReadLine();
            OpcN = int.Parse(opc);
            if (OpcN == 1 || OpcN == 2)
            {
                general(OpcN, VecSalon, VecProf);
                break;
            }
            if (OpcN == 3)
            {
                reservar(OpcN, VecSalon, VecProf);
                break;
            }
            Console.WriteLine("opcion" + opc + " es invalida");       
        }
    }

    public void general (int opc, salon[] VecSalon, profesor[] VecProf)
    {
        if (opc == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(VecSalon[i]);
                }
            }

            if (opc == 2)
            {
                
                
                for (int i = 0; i < 10; i++)
                {
                    if(VecProf[i].reservas != null)
                    {
                        Console.WriteLine(VecProf[i]);
                    }
                }
            }

    }

    public void OpcAdmin(int opc, salon[] VecSalon, profesor[] VecProf)
    {
        if (opc == 3)
        {
            string Sal;
            int SalN;
            Console.WriteLine("Que sala decea cambiar a mantenimiento?");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(VecSalon[i].NumSalon);
            }
            Sal = Console.ReadLine();
            SalN = Int16.Parse(Sal);
            for (int i = 0; i < 10; i++)
            {
                if (SalN == VecSalon[i].NumSalon)
                {
                    VecSalon[i].Manten = true;
                    break;
                }
            }
        }
        if (opc == 4)
        {
            string Sal;
            int SalN;
            string val;
            int valN;
            Console.WriteLine("Que sala decea cambiar la temperatura?");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(VecSalon[i].NumSalon);
            }
            Sal = Console.ReadLine();
            SalN = Int16.Parse(Sal);
            for (int i = 0; i < 10; i++)
            {
                if (SalN == VecSalon[i].NumSalon)
                {
                    val = Console.ReadLine();
                    valN = Int16.Parse(val);
                    VecSalon[i].Temp = valN;
                    break;
                }
            }
        }
        if (opc == 5)
        {
            string Sal;
            int SalN;
            Console.WriteLine("Que hora es?\n margen de 24H");
            Sal = Console.ReadLine();
            SalN = Int16.Parse(Sal);
            if (SalN <= 24 && SalN >= 0)
            {
                hora = SalN;
            }
        }

    }

    public void reservar(int opc, salon[] VecSalon, profesor[] VecProf)
    {
        if (opc == 3)
        {
            string Sal;
            int SalN;
            Console.WriteLine("Que sala decea cambiar a reservar?");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(VecSalon[i].NumSalon);
            }
            Sal = Console.ReadLine();
            SalN = Int16.Parse(Sal);
            for (int i = 0; i < 10; i++)
            {
                if (SalN == VecSalon[i].NumSalon)
                {
                    VecSalon[i].EnUso = true;
                    VecSalon[i].luz = true;
                    VecSalon[i].Temp = 23;
                    VecProf[i].reservas = VecSalon[i];
                    break;
                }
            }
        }
    }
        
    #endregion metodos

    }
}