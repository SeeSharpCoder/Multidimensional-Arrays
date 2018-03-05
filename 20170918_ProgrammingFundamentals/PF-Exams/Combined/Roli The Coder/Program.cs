using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var eventsDic = new Dictionary<string, string>();
            var participantsDic = new Dictionary<string, List<string>>();

            while (input != "Time for Code")
            {
                var idEventParticipants = input
                                            .Split(' ')
                                            .Select(a => a.Trim())
                                            .Where(a => a != "")
                                            .ToArray();
                var id = idEventParticipants[0];
                var eventt = idEventParticipants[1];

                if (eventt.StartsWith("#"))
                {
                    eventt = eventt.Remove(0, 1);

                    if (!eventsDic.ContainsKey(id))
                    {
                        eventsDic[id] = eventt;
                        participantsDic.Add(eventt, new List<string>());
                    }

                    if (eventsDic.ContainsKey(id) && eventsDic[id].Equals(eventt))
                    {
                        for (int i = 2; i < idEventParticipants.Length; i++)
                        {
                            if (!participantsDic[eventt].Contains(idEventParticipants[i]))
                            {
                                participantsDic[eventt].Add(idEventParticipants[i]);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
            var participantSort = from pair in participantsDic orderby pair.Value.Count descending, pair.Key select pair;

            foreach (var pair in participantSort)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value.Count);

                var participants = from list in pair.Value orderby list ascending select list;

                foreach (var name in participants)
                {
                    Console.WriteLine("{0}", name);
                }
            }
        }
    }
}
