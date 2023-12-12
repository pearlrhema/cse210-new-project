using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new("Lecture", "Health lecture.", "14-12-2023", "12:00pm", new Address("20 calabar Itu St", "Ikot Ekpene", "Akwa Ibom", "NIGERIA"), "Godwin Essien", 50);

        Console.WriteLine(lecture.StandardDetails() + "\n");
        Console.WriteLine(lecture.ShortDescription() + "\n");
        Console.WriteLine(lecture.FullDetails() + "\n");

        Reception reception = new("Reception", "Wedding reception.", "14-12-2023", "11:45pm", new Address("123 Main St", "Bryn Mawr", "Pennsylvania", "USA"), "essiengodwin@gmail.com");

        Console.WriteLine(reception.StandardDetails() + "\n");
        Console.WriteLine(reception.ShortDescription() + "\n");
        Console.WriteLine(reception.FullDetails() + "\n");

        OutdoorGathering outdoorGathering = new("outdoorGathering", "Picknic", "14-12-2023", "2:30pm", new Address("Riviera Golf, 08 BP 2656", "Abidjab", "Abidjan", "Ivory Coast"), "Cloudy with a chance of rain.");

        Console.WriteLine(outdoorGathering.StandardDetails() + "\n");
        Console.WriteLine(outdoorGathering.ShortDescription() + "\n");
        Console.WriteLine(outdoorGathering.FullDetails() + "\n");
    }
}