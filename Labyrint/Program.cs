
static void nytt_rum()
{
    Console.WriteLine("Vilken dörr väljer du? dörr a, dörr b eller dörr c?");
}

List<string> visitedRooms = new();

Console.WriteLine("Du vaknar upp och inser att du MÅSTE!!! skita. ");
Console.WriteLine("Du öppnar sovrumsdörren och ser tre dörrar, hitta rätt väg till toan.");

string currentRoom = "Sovrum";

while (currentRoom != "NetherRealm")
{

    if (currentRoom == "Sovrum")
    {

        if (visitedRooms.Contains("Sovrum"))
        {
            // Alla efterföljande
            Console.WriteLine("Du hamnade i sovrumet");
            Console.WriteLine("Vad fan gör du här igen, behövde du inte skita eller?");
            nytt_rum();
        }
        else
        {
            // Första
            visitedRooms.Add("Sovrum");
            
        nytt_rum();
        }

        string dörr = "";
        while (dörr != "a" && dörr != "b" && dörr != "c")
        {
            Console.WriteLine("Du måste svara med ett av alternativen");
            
        dörr = Console.ReadLine();
        
        }
    

        if (dörr == "a")
        {
            currentRoom = "The Void";
        }

        else if (dörr == "b")
        {
            currentRoom = "Djungeln";
        }

        else if (dörr == "c")
        {
            currentRoom = "Himlen";

            Console.WriteLine("Nu står du framför fadern, sonen och den heliga anden och han medelar att du är vid dödsdörren för att nu är det brottom.");
            Console.WriteLine("Han känner medkänsla då han själv har varit i din sitts så han visar genast vägen till de tre dörrarna");
            nytt_rum();

        }
        else
        {
            Console.WriteLine("Du måste svara med ett av alternativen");
        }


    }

    if (currentRoom == "The Void")
    {

        Console.WriteLine("Det verkar som att du har brytit mot naturens lagar och warpat till ett ställe där tid och rum inte existerar. Efter du har varit i detta tomrum i 370 år så hittar du tre dörrar svävande.");

        if (visitedRooms.Contains("The Void"))
        {
            Console.WriteLine("Du hamnade i The Void");
            Console.WriteLine("Vad fan gör du här igen, behövde du inte skita eller?");
            
        }
        else
        {
            visitedRooms.Add("The Void");
        }
        nytt_rum();

       string dörr = Console.ReadLine();

        
        while (dörr != "a" && dörr != "b" && dörr != "c")
        {
            Console.WriteLine("Du måste svara med ett av alternativen");
            
            dörr = Console.ReadLine();
        
        }

        if (dörr == "a")
        {

            currentRoom = "Sovrum";

        }

        else if (dörr == "b")
        {

            currentRoom = "The Abyss";

            Console.WriteLine("Du faller och faller men du träffar aldrig marken. Det verkar som att du har hamnat i en oändlig loop");
            Console.WriteLine("Du börjar ifrågasätta dina livsbeslut men precis då anländer en portal som skickar dig tillbaka");
    
        }

        else if (dörr == "c")
        {
            currentRoom = "Djungeln";
        }

        else 
        {
            Console.WriteLine("Du måste svara med ett av alternativen");
        }

    }

    if (currentRoom == "Djungeln")
    {

            Console.WriteLine("Nu verkar det som att du har hamnat i en djungel");
            Console.WriteLine("Du går runt ett tag och från ingenstans så träffar du på en tribe member och han visar dig vägen till dörrarna");

        if (visitedRooms.Contains("Djungeln"))
        {
            Console.WriteLine("Du hamnade i Djungeln");
            Console.WriteLine("Vad fan gör du här igen, behövde du inte skita eller?");

        }

        else
        {

            visitedRooms.Add("Djungeln");

        }
        nytt_rum();

        string dörr = Console.ReadLine();

        while (dörr != "a" && dörr != "b" && dörr != "c")
        {
            Console.WriteLine("Du måste svara med ett av alternativen");
            
            dörr = Console.ReadLine();
        
        }

        if (dörr == "a")
        {

            currentRoom = "Himeln";

        }

        else if (dörr == "b")
        {

            currentRoom = "Sovrum";

        }

        else if (dörr == "c")
        {

            currentRoom = "The Void";

        }

        else
        {

            Console.WriteLine("Du måste svara med ett av alternativen");

        }
    }

    if (currentRoom == "Himeln")
    {

        Console.WriteLine("Nu står du framför fadern, sonen och den heliga anden och han medelar att du är vid dödsdörren för att nu är det brottom");
        Console.WriteLine("Han känner medkänsla då han själv har varit i din sitts så han visar genast vägen till de tre dörrarna");

        if (visitedRooms.Contains("Himeln"))
        {

            Console.WriteLine("Du hamnade i Himeln");
            Console.WriteLine("Vad fan gör du här igen, behövde du inte skita eller?");

        }

        else 
        {

            visitedRooms.Add("Himeln");

        }
        nytt_rum();

        string dörr = Console.ReadLine();

        while (dörr != "a" && dörr != "b" && dörr != "c")
        {
            Console.WriteLine("Du måste svara med ett av alternativen");
            
            dörr = Console.ReadLine();
        
        }

        if (dörr == "a")
        {

            currentRoom = "Djungeln";

        }

        else if (dörr == "b")
        {

            currentRoom = "NetherRealm";

        }

        else if (dörr == "c")
        {

            currentRoom = "Sovrum";

        }

        else
        {

            Console.WriteLine("Du måste svara med ett av alternativen");

        }

    }
    
}







