namespace ListeDiffusion
{
    class ArchivageMessages
    {
        public string Titre { get; private set; }
        private string[] ListeMessages = new string[400];

        public ArchivageMessages(string titre){
            this.Titre = titre;
        }

        public void ArchiverMessage(string message){
            //archive le message reçu dans le tableau
            ListeMessages.Append(message);

        }

        public void ListerMessages(){
            //lister les message reçu dans le tableau

            Console.WriteLine(this.Titre);
            foreach (var message in ListeMessages)
            {
                Console.WriteLine(message);
            }

        }

    }
}