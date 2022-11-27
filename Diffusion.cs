namespace ListeDiffusion
{
    class Diffusion
    {
        static void Main()
        {
            //instanciation manuelle des 5 clients 
            Client Sampaniony = new Client("Sampaniony");
            Client Sampaniony1 = new Client("Sampaniony1");
            Client Sampaniony2 = new Client("Sampaniony2");
            Client Sampaniony3 = new Client("Sampaniony3");
            Client Sampaniony4 = new Client("Sampaniony4");

            //instanciation des archives des deux diffuseurs
            ArchivageMessages archiveReunion = new ArchivageMessages("Reunion");
            ArchivageMessages archiveWeekEnd = new ArchivageMessages("WeekEnd");

            EnvoiMessage reunion = new EnvoiMessage();
            EnvoiMessage weekEnd = new EnvoiMessage();

            //Inscription des clients
            reunion.Abonner(Sampaniony.RecevoirMessage); 
            reunion.Abonner(Sampaniony1.RecevoirMessage); 
            reunion.Abonner(Sampaniony2.RecevoirMessage); 

            weekEnd.Abonner(Sampaniony3.RecevoirMessage);
            weekEnd.Abonner(Sampaniony4.RecevoirMessage);

            //creation archive de message des 2 diffusions - ce qui malheureusement ne marche pas
            reunion.Abonner(archiveReunion.ArchiverMessage);
            weekEnd.Abonner(archiveWeekEnd.ArchiverMessage);

            Console.WriteLine(archiveReunion.ListerMessages); // not yet finished :/

            String stopOrContinue;

            //envoi de message
            do {
                Console.WriteLine("Bienvenue dans notre projet !! ");
                Console.WriteLine("Pour informations, les clients suivants sont abonnés au diffuseur REUNION: Sampaniony, Sampaniony1 et Sampanion2");
                Console.WriteLine("Et les suivants sont dans WEEK END: Sampaniony3 et Sampaniony4");

                Console.WriteLine("");
                Console.WriteLine("__Choisir la chaine où envoyer un message__ ");
                Console.Write("1. reunion || 2. week-end : ");
                String choice = Console.ReadLine();

                if(choice == "1" || choice == "2"){
                    Console.Write("Tapez le message à diffuser pour la chaine '" + (choice == "1" ? "reunion'": "week-end'") + ": ");
                    String msgReceived = Console.ReadLine();

                    if(choice == "1"){
                        reunion.Diffuser(msgReceived); 
                    }

                    if(choice == "2"){
                        weekEnd.Diffuser(msgReceived); 
                    }
                }
                else{
                    Console.WriteLine("Mais ça n'existe pas dans le choix, dommage :) ");
                }

                Console.Write("Voulez-vous continuer? Taper 1 si oui: ");
                stopOrContinue = Console.ReadLine();

            } while(stopOrContinue == "1");
            
        }
    
    }

}