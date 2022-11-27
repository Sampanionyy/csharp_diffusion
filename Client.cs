namespace ListeDiffusion
{
    class Client
    {
        public string Nom { get; private set; }

        public Client(string nom){
            this.Nom = nom;
        }


        public void RecevoirMessage(string message){
            //afficher le nom du destinataire et le message reçu
            Console.WriteLine("Client abonné : " + Nom);

            Console.WriteLine("- "+message);
        }

    }
    
}
