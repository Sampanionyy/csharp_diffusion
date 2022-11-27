namespace ListeDiffusion
{
    class EnvoiMessage
    {
        public delegate void Envoyer(string e);
        
        public event Envoyer EnvoyerMessage;

        public void Abonner(Envoyer e){
            EnvoyerMessage += e;
        }

        public void Diffuser(string message){

            if(EnvoyerMessage != null){
                EnvoyerMessage(message);

           }
        }
    }
}