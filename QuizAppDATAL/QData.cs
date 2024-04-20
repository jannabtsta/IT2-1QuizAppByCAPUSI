using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppDATAL
{
    public class QData
    {
        public static List<string> R1Questions = new List<string>
        {
            "What is the oldest city in the Philippines?",
            "Who is the leader of the Katipunan?",
            "Who discovered the Philippines?",
            "Which person is known as, \"The Brains of Katipunan'",
            "How many years do Spain ruled the Philippines?"
        };

        public static List<string> R1Choices = new List<string>
        {
            "\na.Baguio City, b.Cebu City, c.Metro Manila",
            "\na.Diego Silang, b.Emilio Jacinto c.Andres Bonifacio",
            "\na.Vasco Da Gama, b.Ferdinand Magellan, c.Christopher Colombus",
            "\na.Jose Rizal, b.Juan Luna, c.Emilio Jacinto",
            "\na.333 years, b.169 years, c.75 years"
        };

        public static List<string> R1Answers = new List<string>
        {
            "b",
            "c",
            "b",
            "c",
            "a"

        };

        public static List<string> R2Questions = new List<string>
        {
            "When did the Philippines gained independence from Spain?",
            "Where was Jose Rizal exiled?",
            "What represents the each ray of the Sun in the Philippine Flag?"

        };

        public static List<string> R2Choices = new List<string>
        {
            "\na.June 12,1989, b.July 4,1946, c.April 12,1521",
            "\na.San Jose, Nueva Ecija, b.Dapitan, Zamboanga Del Norte, c.Antipolo Rizal",
            "\n a.The Provinces who revolted against Spain during the Philippine Revolution,\n " +
            "b.The sign of Spain's Colonialism in the Philippines, \n c.The discovery of the Philippines"
        };

        public static List<string> R2Answers = new List<string>
        {
            "a",
            "b",
            "a"
        };

        public static  List<string> R3Questions = new List<string>
        {
            "Because of which reason, was Rizal not in favor of the revolution planned by the Katipunan?",
            "What event marked the beginning of World War II in the Philippines?",
            "What year did the Philippines ratify its current constitution?"
        };

        public static List<string> R3Choices = new List<string>
        {
            "\na.Unpreparedness of the Katipuneros for an armed struggle" +
            "\nb.Willingness to the wealthy Filipinos to support the struggle" +
            "\nc.Absence of a military tactician who will direct the military operations of the KKK",
            "\na.The bombing of Pearl Harbor, b.The Battle of Midway, c.The Battle of Corregidor",
            "\na.1935, b.1987, c.1946"

        };

        public static List<string> R3Answers = new List<string>
        {
            "a",
            "a",
            "b"
        };
    }
}
