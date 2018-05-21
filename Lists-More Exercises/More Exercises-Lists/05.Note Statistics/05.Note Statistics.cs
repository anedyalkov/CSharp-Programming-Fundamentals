namespace _05.Note_Statistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var frequencies = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToList();

            var notes = new List<string>();
            var naturals = new List<string>();
            var naturalsFrequencies = new List<double>();
            var sharps = new List<string>();
            var sharpsFrequencies = new List<double>();

            for (int i = 0; i < frequencies.Count; i++)
            {
                var currentFrequency = frequencies[i];
                var note = string.Empty;
                switch (currentFrequency)
                {
                    case 261.63:
                        note = "C";
                            break;
                    case 277.18:
                        note = "C#";
                            break;
                    case 293.66:
                        note = "D";
                            break;
                    case 311.13:
                        note = "D#";
                            break;
                    case 329.63:
                        note = "E";
                        break;
                    case 349.23:
                        note = "F";
                        break;
                    case 369.99:
                        note = "F#";
                        break;
                    case 392.00:
                        note = "G";
                        break;
                    case 415.30:
                        note = "G#";
                        break;
                    case 440.00:
                        note = "A";
                        break;
                    case 466.16:
                        note = "A#";
                        break;
                    case 493.88:
                        note = "B";
                        break;
                    default:
                        break;
                }
                notes.Add(note);
                if (note.Contains("#"))
                {
                    sharps.Add(note);
                    sharpsFrequencies.Add(currentFrequency);
                }
                else
                {
                    naturals.Add(note);
                    naturalsFrequencies.Add(currentFrequency);
                }
            }

            var sumNaturalFrequencies = naturalsFrequencies.Sum();
            var sumSharpFrequencies = sharpsFrequencies.Sum();

            var naturalFrequenciesResult = sumNaturalFrequencies == 0 ? 0 : sumNaturalFrequencies;
            var sharpFrequenciesResult = sumSharpFrequencies == 0 ? 0 : sumSharpFrequencies;

            Console.WriteLine($"Notes: {string.Join(" ",notes)}");
            Console.WriteLine($"Naturals: {string.Join(", ",naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ",sharps)}");
            Console.WriteLine($"Naturals sum: {naturalFrequenciesResult}");
            Console.WriteLine($"Sharps sum: {sharpFrequenciesResult}");
        }
    }
}
