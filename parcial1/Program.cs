using System;
using parcial1.usuarios; 
using parcial1.salones;
using parcial1.menu; 

namespace parcial1
{
    class Program
    {
        static void Main(string[] args)
        {

            int var = 100;
            salon ObjSalon= new salon();
            salon []vecSalon = new salon[10];
            for (int i = 0; i < 10; i++)
            {
                ObjSalon.NumSalon = var + i;
                ObjSalon.Temp = 26;
                ObjSalon.Manten = false;
                ObjSalon.EnUso = false;
                ObjSalon.luz = false;
                vecSalon[i] = ObjSalon;
            }
            profesor []VecProf = new profesor[3];


            admin User1 = new admin();
            User1.Nombre = "Jose";
            User1.CC = 3216847;

            profesor User2 = new profesor();
            User2.Nombre = "Antonio";
            User2.CC = 321654987;
            User2.Materia = "Mat";
            User2.reservas = null;
            VecProf[0] = User2;

            profesor User3 = new profesor();
            User3.Nombre = "Manuel";
            User3.CC = 31471484;
            User3.Materia = "Sistemas";
            User3.reservas = null;
            VecProf[1] = User3;

            profesor User4 = new profesor();
            User4.Nombre = "Leonardo";
            User4.CC = 10151015;
            User4.Materia = "Porg. Objetos";
            User4.reservas = null;
            VecProf[2] = User4;

            

            fachada ObjFachada = new fachada();
             int Dead = 1;
             while (Dead == 1)
             {
                 ObjFachada.menu(User1, VecProf, vecSalon);
                 Dead = 2;
             }

             Console.WriteLine("ADIOS FUE UN GUSTO");
            
            
        }
    }
}
