using System;
using System.Collections.Generic;

namespace BridgeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IManuscript> documents = new List<IManuscript>();
            var fancyFormatter = new FancyFormatter();
            var backwardsFormatter = new BackwardsFormatter();
            var standardFormatter = new StandardFormatter();

            var faq = new FAQ(fancyFormatter);
            faq.Title = "The Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate an abstraction from an implementation.");
            documents.Add(faq);

            var book = new Book(backwardsFormatter)
            {
                Title = "Lots of Patterns",
                Author = "John Sonmez",
                Text = "Blah blah blah..."
            };
            documents.Add(book);

            var paper = new TermPaper(standardFormatter)
            {
                Class = "Design Patterns",
                Student = "Joe N00b",
                Text = "Blah blah blah...",
                References = "GOF"
            };
            documents.Add(paper);

            foreach (var doc in documents)
            {
                doc.Print();
            }

            Console.ReadKey();
        }
    }
}
