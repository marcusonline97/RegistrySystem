using RegistrySystem.ProjectFolder;
using System.Reflection.Metadata.Ecma335;

namespace RS

{
    public class Program // The Main Program
    {

        static void Main(string[] args)
        {
            RegistrySystem registrySystem = new RegistrySystem();
            
            while (registrySystem.IsRunning)
            {
                registrySystem.PrintCurrentMenu();
                registrySystem.HandleInput();
            }
        }
       

    }

       

       

 }

