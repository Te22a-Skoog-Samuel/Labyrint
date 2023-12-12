
static void nytt_rum()
{
    Console.WriteLine("Vilken dörr väljer du? dörr a, dörr b eller dörr c?");
}

List<string> visitedRooms = new();

Console.WriteLine("Du vaknar upp och inser att du MÅSTE!!! skita. ");
Console.WriteLine("Du öppnar sovrumsdörren och ser tre dörrar, hitta rätt väg till toan.");

string room = "Sovrum";

while (room != "NetherRealm")
{

    if (room == "Sovrum")
    {

        if (visitedRooms.Contains("Sovrum"))
        {
            // Alla efterföljande
            Console.WriteLine("Vad fan gör du här igen, behövde du inte skita eller?");
            nytt_rum();
        }
        else
        {
            // Första
            visitedRooms.Add("Sovrum");

            nytt_rum();
        }


        string dörr = Console.ReadLine();

        if (dörr == "a")
        {
            room = "The Void";

            Console.WriteLine("Det verkar som att du har brytit mot naturens lagar och warpat till ett ställe där tid och rum inte existerar.");
            Console.WriteLine("Efter du har varit i detta tomrum i 370 år så hittar du tre dörrar svävande.");
            nytt_rum();

        }
    
        else if (dörr == "b")
        {
            room = "Djungeln";

            Console.WriteLine("Nu verkar det som att du har hamnat i en djungel");
            Console.WriteLine("Du går runt ett tag och från ingenstans så träffar du på en tribe member och han visar dig vägen till dörrarna");
            nytt_rum();

        }
    
        else if (dörr == "c")
        {
            room = "Himlen";

            Console.WriteLine("Nu står du framför fadern, sonen och den heliga anden och han medelar att du är vid dödsdörren för att nu är det brottom");
            Console.WriteLine("Han känner medkänsla då han själv har varit i din sitts så han visar genast vägen till de tre dörrarna");
            nytt_rum();
            
        }


    }

}













Console.ReadLine();
