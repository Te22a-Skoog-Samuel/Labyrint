
static void nytt_rum()
{
Console.WriteLine("Vilken dörr väljer du? dörr a, dörr b eller dörr c");
}

List<string> visitedRooms = new();

Console.WriteLine("Du vaknar upp och inser att du MÅSTE!!! skita. ");
Console.WriteLine("Du öppnar sovrumsdörren och ser tre dörrar, hitta rätt väg till toan.");

string room = "Sovrum";

while (room != "NetherRealm")
{
   
    if (room =="Sovrum")
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
    
    }   

    string dörr = Console.ReadLine();

    if (dörr == "a")
    {
        room = "The Void";

        Console.WriteLine("Det verkar som att du har brytit mot naturens lagar och warpat till ett ställe där tid och rum inte existerar.");
        Console.WriteLine("Efter du har varit i detta tomrum i 370 år så hittar du tre teleportörer.");
        Console.WriteLine("Väljer du teleportör a, b eller c.");
    }
    
}










    


Console.ReadLine();
